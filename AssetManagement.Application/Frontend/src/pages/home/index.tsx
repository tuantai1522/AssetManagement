import MyAssignmentList, { MyAssignmentRowData } from "./myAssignmentList";
import { useEffect, useState } from "react";
import agent from "../../app/api/agent";
import { Order } from "../../app/components/table/sortTable";
import { Stack } from "@mui/material";
import { SetURLSearchParams, useSearchParams } from "react-router-dom";
import AppPagination from "../../app/components/paginationButtons/paginationButtons";
import AssignmentInfo from "../../app/components/assignmentInfo/AssignmentInfo";
import {
  FilterMyAssignmentRequest,
  FilterMyAssignmentResponse,
  OrderByFieldNameMyAssignment,
} from "../../app/models/myAssignment/myAssignment";
import { AssignmentStateEnum } from "../../app/types/enum";
import { number } from "yup";
import { convertUtcToLocalDate } from "../../app/utils/dateUtils";
import ConfirmModal from "../../app/components/confirmModal";

function setFilterSearchParam(
  query: FilterMyAssignmentRequest,
  setSearchParams: SetURLSearchParams
) {
  const params = new URLSearchParams();

  if (query?.orderBy) {
    params.set("orderBy", query.orderBy.toString());
  }

  if (query?.order) {
    params.set("order", query.order.toString());
  }

  if (query?.pageNumber) {
    params.set("pageNumber", query.pageNumber.toString());
  }

  if (query?.pageSize) {
    params.set("pageSize", query.pageSize.toString());
  }

  setSearchParams(params);
}

export default function HomePage() {
  const [searchParams, setSearchParams] = useSearchParams();
  
  const initPageNumber = Number(searchParams.get("pageNumber") ?? "1");
  const initPageSize = Number(searchParams.get("pageSize") ?? "5");
  const initOrder = (searchParams.get("order") as Order) ?? "desc";
  const initOrderBy = (searchParams.get("orderBy") as OrderByFieldNameMyAssignment) ?? "assignedDate";

  //Details
  const [clickOnAssignment, setClickOnAssignment] = useState<boolean>(false);
  // const [assetId, setAssetId] = useState<string>("0");
  const [assignmentId, setAssignmentId] = useState<string>("")


  const [query, setQuery] = useState<FilterMyAssignmentRequest>({
    pageNumber: initPageNumber > 0 ? initPageNumber : 1,
    pageSize: initPageSize > 0 ? initPageSize : 5,
    order: initOrder,
    orderBy: initOrderBy,
  });


  const { data, isLoading, error, mutate } = agent.MyAssignment.filter(query);
  
  useEffect(() => {
    if (!isLoading) {
      window.history.replaceState({}, "");
    }
  }, [isLoading]);

  const setOrderBy = (orderBy: OrderByFieldNameMyAssignment) => {
    const newQuery = { ...query, orderBy: orderBy };
    setQuery((pre) => ({ ...pre, orderBy: orderBy }));
    setFilterSearchParam(newQuery, setSearchParams);
  };

  const setOrder = (order: Order) => {
    const newQuery = { ...query, order: order };
    setQuery((pre) => ({ ...pre, order: order }));
    setFilterSearchParam(newQuery, setSearchParams);
  };

  const handleClickOnAssignment = (rowId: string) => {
    setClickOnAssignment(true);
    setAssignmentId(data.items.result[rowId].id);
  };

  const handlePageNumberChange = (value: any) => {
    let pageNumber = Number(value);
    pageNumber = !pageNumber || pageNumber <= 0 ? 1 : pageNumber;
    const newQuery: FilterMyAssignmentRequest = { ...query, pageNumber };
    setQuery(newQuery);
    setFilterSearchParam(newQuery, setSearchParams);
  };

  return (
    <div className="flex justify-center h-full">
      <div className="container">
        <p className="text-primary text-xl font-bold justify-start items-start">
          My Assignment
        </p>
        <div className="mt-3">
          <MyAssignmentList
            data={
              data?.items?.result?.map((item: FilterMyAssignmentResponse) => ({
                id: item.id,
                assetCode: item.assetCode,
                name: item.name,
                category: item.category,
                assignedDate: convertUtcToLocalDate(item.assignedDate),
                state: AssignmentStateEnum[item.state as number],
                action: {
                  id: item.id,
                  state: item.state,
                },
              })) as MyAssignmentRowData[]
            }
            error={error}
            isLoading={isLoading}
            order={query?.order ?? "asc"}
            setOrder={setOrder}
            orderBy={query?.orderBy}
            setOrderBy={setOrderBy}
            handleClick={(event, rowId) => handleClickOnAssignment(rowId)}
            refetchData={mutate}
          />

          <Stack
            direction="row"
            justifyContent="flex-end"
            alignItems="baseline"
          >
            <AppPagination
              totalPage={data?.metaData?.totalPageCount ?? 1}
              onChange={handlePageNumberChange}
              currentPage={data?.metaData?.currentPage ?? 1}
            />
          </Stack>
        </div>
      </div>
      {clickOnAssignment && (
        <AssignmentInfo
          assignmentId={assignmentId}
          onClose={() => {
            setClickOnAssignment(false);
          }}
        />
      )}
    </div>
  );
}
