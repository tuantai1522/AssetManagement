import { Stack } from "@mui/material";
import AssignmentList, { AssignmentRowData } from "./assignmentList";
import { FilterAssignmentRequest, FilterAssignmentResponse, OrderByFieldName } from "../../app/models/assignment/Assignment";
import { AssignmentStateEnum } from "../../app/types/enum";
import { SetURLSearchParams, useLocation, useNavigate, useSearchParams } from "react-router-dom";
import { FormEvent, useState } from "react";
import { Order } from "../../app/components/table/sortTable";
import agent from "../../app/api/agent";
import { convertDateToString } from "../../app/utils/dateUtils";
import AppPagination from "../../app/components/paginationButtons/paginationButtons";
import AppSearchInput from "../../app/components/AppSearchInput";
import { Search } from "@mui/icons-material";
import AppButton from "../../app/components/buttons/Button";
import AssignmentStateFilter from "./asignmentState";
import { AssignDateFilter } from "./assignedDateFilter";
import dayjs, { Dayjs } from "dayjs";
import AssignmentInfo from "../../app/components/assignmentInfo/AssignmentInfo";

function setFilterSearchParam(
  query: FilterAssignmentRequest,
  setSearchParams: SetURLSearchParams
) {
  const params = new URLSearchParams();

  if (query?.search) {
    params.set("search", query.search.toString());
  }

  if (query?.states && query.states.length > 0) {
    const normalizeState: string[] = query.states.map(
      (item) => AssignmentStateEnum[item] ?? item
    );
    normalizeState.forEach((state) => {
      if (state) params.append("states", state);
    });
  }

  if (query?.assignedDate) {
    params.set("assignedDate", query.assignedDate.toString());
  }

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

export default function ManagementAssignmentPage() {

  const [clickOnAssignment, setClickOnAssignment] = useState<boolean>(false);
  const [assignmentId, setAssignmentId] = useState<string>("");
  const [searchParams, setSearchParams] = useSearchParams();
  const navigate = useNavigate();
  const location = useLocation();
  let { passedOrder, passedOrderBy } = location.state || {};

  const initSearch = searchParams.get("search") ?? "";
  const initPageNumber = Number(searchParams.get("pageNumber") ?? "1");
  const initPageSize = Number(searchParams.get("pageSize") ?? "5");
  const initStates = searchParams.getAll("states");
  const initCategories = searchParams.getAll("categories");
  const initOrder =
    passedOrder ?? (searchParams.get("order") as Order) ?? "asc";
  const initOrderBy =
    passedOrderBy ??
    (searchParams.get("orderBy") as OrderByFieldName) ??
    "name";

  let initAssignedDateInput: Dayjs | null = null;
  let initAssignedDate: string = "";
  //assignedDate is in format "YYYY-MM-DD"
  const assignedDateParam = searchParams.get("assignedDate");
  if (assignedDateParam) {
    try {
      initAssignedDateInput = dayjs(assignedDateParam, 'YYYY-MM-DD');
      if (initAssignedDateInput.isValid()) {
        initAssignedDate = initAssignedDateInput.format('YYYY-MM-DD');
      } else {
        initAssignedDateInput = null;
      }
    } catch (e) {
      initAssignedDateInput = null;
    }
  }
  const handleClickOnAssignment = (rowId: string) => {
    setClickOnAssignment(true);
    setAssignmentId(data.items.result[rowId].id);
  };

  const [states, setStates] = useState<string[]>(initStates);

  const [query, setQuery] = useState<FilterAssignmentRequest>({
    search: initSearch,
    assignedDate: initAssignedDate ?? "",
    states:
      initStates
        ?.map((state) => AssignmentStateEnum[state as keyof typeof AssignmentStateEnum])
        ?.filter(
          (mappedState) => mappedState !== undefined && mappedState !== null
        ) ?? [],
    pageNumber: initPageNumber > 0 ? initPageNumber : 1,
    pageSize: initPageSize > 0 ? initPageSize : 5,
    order: initOrder,
    orderBy: initOrderBy,
  });

  const [searchInput, setSearchInput] = useState<string>(initSearch);
  const [assignedDate, setAssignedDate] = useState<Dayjs | null>(initAssignedDateInput);

  const { data, isLoading, error } = agent.Assignment.filter(query);

  const setOrderBy = (orderBy: OrderByFieldName) => {
    const newQuery = { ...query, orderBy: orderBy };
    setQuery((pre) => ({ ...pre, orderBy: orderBy }));
    setFilterSearchParam(newQuery, setSearchParams);
  };

  const setOrder = (order: Order) => {
    const newQuery = { ...query, order: order };
    setQuery((pre) => ({ ...pre, order: order }));
    setFilterSearchParam(newQuery, setSearchParams);
  };

  const handlePageNumberChange = (value: any) => {
    let pageNumber = Number(value);
    pageNumber = !pageNumber || pageNumber <= 0 ? 1 : pageNumber;
    const newQuery: FilterAssignmentRequest = { ...query, pageNumber };
    setQuery(newQuery);
    setFilterSearchParam(newQuery, setSearchParams);
  };

  const handleSearchInputChange = (
    event: React.ChangeEvent<HTMLInputElement>
  ) => {
    const { name, value } = event.target;
    setSearchInput(value);
  };

  const handleSearchSubmit = (e: FormEvent<HTMLFormElement>) => {
    e.preventDefault();
    const newQuery: FilterAssignmentRequest = {
      ...query,
      pageNumber: 1,
      search: searchInput?.trim(),
    };
    setQuery(newQuery);
    setFilterSearchParam(newQuery, setSearchParams);
  };

  const handleStateFilterClick = () => {
    let newQuery: FilterAssignmentRequest;
    if (states.length === 0 || states.includes("all")) {
      newQuery = { ...query, states: [], pageNumber: 1 };
      setQuery(newQuery);
      setFilterSearchParam(newQuery, setSearchParams);
    } else {
      newQuery = {
        ...query,
        states: states
          .map((state) => AssignmentStateEnum[state as keyof typeof AssignmentStateEnum])
          .filter(
            (mappedState) => mappedState !== undefined && mappedState !== null
          ),
        pageNumber: 1
      };
      setQuery(newQuery);
      setFilterSearchParam(newQuery, setSearchParams);
    }
  };

  const handleAssignedDateFilterClick = (event: FormEvent<HTMLFormElement>) => {
    event.preventDefault();
    let newQuery: FilterAssignmentRequest;
    if (assignedDate != null) {
      const newAssignedDate = dayjs(assignedDate).format('YYYY-MM-DD');
      newQuery = { ...query, assignedDate: newAssignedDate, pageNumber: 1 };
      setQuery(newQuery);
      setFilterSearchParam(newQuery, setSearchParams);
    } else {
      newQuery = {
        ...query,
        assignedDate: undefined,
        pageNumber: 1
      };
      setQuery(newQuery);
      setFilterSearchParam(newQuery, setSearchParams);
    }
  };

  return (
    <div className="flex justify-center h-full">
      <div className="container">
        <p className="text-primary text-xl font-bold justify-start items-start">
          Assignment List
        </p>
        <Stack
          direction="row"
          justifyContent="space-between"
          alignItems="center"
          className="mt-3"
        >
          <Stack
            direction="row"
            justifyContent="flex-start"
            alignItems="center"
            spacing={12}
          >
            <AssignmentStateFilter
              states={states}
              setStates={setStates}
              onSubmit={handleStateFilterClick}
            />

            <AssignDateFilter assignedDate={assignedDate} handleAssignedDateChange={setAssignedDate} handleFilterClick={handleAssignedDateFilterClick} />

          </Stack>
          <Stack
            direction="row"
            justifyContent="flex-end"
            alignItems="center"
            spacing={4}
          >
            <form onSubmit={handleSearchSubmit} >
              <Stack
                direction="row"
                justifyContent="flex-start"
                alignItems="center"
                spacing={2}
              >
                <AppSearchInput
                  type="text"
                  placeholder="Search"
                  name="name"
                  value={searchInput}
                  onChange={handleSearchInputChange}
                  className="!rounded-l-md !border !border-gray-400 !border-r-0"
                />

                <button
                  type="submit"
                  className="border border-gray-500 border-l-0 rounded-r-md mx-0 hover:cursor-pointer"
                  style={{ margin: 0, padding: "6px", height: "40px" }}
                >
                  <Search className="mx-0" />
                </button>
              </Stack>
            </form>
            <AppButton
              content="Create new assignment"
              className="py-[6px] min-w-52"
              onClickOn={() => {navigate('create-assignment')}}
            />
          </Stack>
        </Stack>
        <div className="mt-3">
          <AssignmentList
            data={
              data?.items?.result?.map((item: FilterAssignmentResponse) => ({
                id: item.id,
                assetCode: item.assetCode,
                assetName: item.assetName,
                assignedTo: item.assignedTo,
                assignedBy: item.assignedBy,
                assignedDate: convertDateToString(item.assignedDate),
                state:
                  item.state !== undefined ? AssignmentStateEnum[item.state] : undefined,
                action: {
                  id: item.id,
                  state:
                    item.state !== undefined
                      ? AssignmentStateEnum[item.state]
                      : undefined,
                },
              })) as AssignmentRowData[]
            }
            error={error}
            isLoading={isLoading}
            order={query?.order ?? "asc"}
            setOrder={setOrder}
            orderBy={query?.orderBy}
            setOrderBy={setOrderBy}
            handleClick={(event, rowId) => { handleClickOnAssignment(rowId)} }
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
