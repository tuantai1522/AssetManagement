import { Stack } from "@mui/material";
import ReturningRequestList, { ReturningRequestRowData } from "./returningRequestList";
import { ReturningRequestStateEnum } from "../../app/types/enum";
import { SetURLSearchParams, useLocation, useSearchParams } from "react-router-dom";
import { FormEvent, useState } from "react";
import { Order } from "../../app/components/table/sortTable";
import agent from "../../app/api/agent";
import { convertDateToString } from "../../app/utils/dateUtils";
import AppPagination from "../../app/components/paginationButtons/paginationButtons";
import AppSearchInput from "../../app/components/AppSearchInput";
import { Search } from "@mui/icons-material";
import ReturningRequestState from "./returningRequestState";
import ReturnedDateFilter from "./returnedDateFilter";
import dayjs, { Dayjs } from "dayjs";
import { FilterReturningRequestRequest, FilterReturingRequestResponse, OrderByFieldName } from "../../app/models/returningRequest/ReturningRequest";

function setFilterSearchParam(
  query: FilterReturningRequestRequest,
  setSearchParams: SetURLSearchParams
) {
  const params = new URLSearchParams();

  if (query?.search) {
    params.set("search", query.search.toString());
  }

  if (query?.states && query.states.length > 0) {
    const normalizeState: string[] = query.states.map(
      (item) => ReturningRequestStateEnum[item] ?? item
    );
    normalizeState.forEach((state) => {
      if (state) params.append("states", state);
    });
  }

  if (query?.returnedDate) {
    params.set("returnedDate", query.returnedDate.toString());
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

const ManagementRequestForReturningPage = () => {

  const [searchParams, setSearchParams] = useSearchParams();
  const location = useLocation();
  let { passedOrder, passedOrderBy } = location.state || {};

  const initSearch = searchParams.get("search") ?? "";
  const initPageNumber = Number(searchParams.get("pageNumber") ?? "1");
  const initPageSize = Number(searchParams.get("pageSize") ?? "5");
  const initStates = searchParams.getAll("states");
  const initOrder =
    passedOrder ?? (searchParams.get("order") as Order) ?? "asc";
  const initOrderBy =
    passedOrderBy ??
    (searchParams.get("orderBy") as OrderByFieldName) ??
    "name";

  let initReturnedDateInput: Dayjs | null = null;
  let initReturnedDate: string = "";
  //returnedDate is in format "YYYY-MM-DD"
  const returnedDateParam = searchParams.get("returnedDate");
  if (returnedDateParam) {
    try {
      initReturnedDateInput = dayjs(returnedDateParam, 'YYYY-MM-DD');
      if (initReturnedDateInput.isValid()) {
        initReturnedDate = initReturnedDateInput.format('YYYY-MM-DD');
      } else {
        initReturnedDateInput = null;
      }
    } catch (e) {
      initReturnedDateInput = null;
    }
  }

  const [states, setStates] = useState<string[]>(initStates);

  const [query, setQuery] = useState<FilterReturningRequestRequest>({
    search: initSearch,
    returnedDate: initReturnedDate ?? "",
    states:
      initStates
        ?.map((state) => ReturningRequestStateEnum[state as keyof typeof ReturningRequestStateEnum])
        ?.filter(
          (mappedState) => mappedState !== undefined && mappedState !== null
        ) ?? [],
    pageNumber: initPageNumber > 0 ? initPageNumber : 1,
    pageSize: initPageSize > 0 ? initPageSize : 5,
    order: initOrder,
    orderBy: initOrderBy,
  });

  const [searchInput, setSearchInput] = useState<string>(initSearch);
  const [returnedDate, setReturnedDate] = useState<Dayjs | null>(initReturnedDateInput);

  const { data, isLoading, error } = agent.ReturningRequest.filter(query);

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
    const newQuery: FilterReturningRequestRequest = { ...query, pageNumber };
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
    const newQuery: FilterReturningRequestRequest = {
      ...query,
      pageNumber: 1,
      search: searchInput?.trim(),
    };
    setQuery(newQuery);
    setFilterSearchParam(newQuery, setSearchParams);
  };

  const handleStateFilterClick = () => {
    let newQuery: FilterReturningRequestRequest;
    if (states.length === 0 || states.includes("all")) {
      newQuery = { ...query, states: [], pageNumber: 1 };
      setQuery(newQuery);
      setFilterSearchParam(newQuery, setSearchParams);
    } else {
      newQuery = {
        ...query,
        states: states
          .map((state) => ReturningRequestStateEnum[state as keyof typeof ReturningRequestStateEnum])
          .filter(
            (mappedState) => mappedState !== undefined && mappedState !== null
          ),
        pageNumber: 1
      };
      setQuery(newQuery);
      setFilterSearchParam(newQuery, setSearchParams);
    }
  };

  const handleReturnedDateFilterClick = (event: FormEvent<HTMLFormElement>) => {
    event.preventDefault();
    let newQuery: FilterReturningRequestRequest;
    if (returnedDate != null) {
      const newAssignedDate = dayjs(returnedDate).format('YYYY-MM-DD');
      newQuery = { ...query, returnedDate: newAssignedDate, pageNumber: 1 };
      setQuery(newQuery);
      setFilterSearchParam(newQuery, setSearchParams);
    } else {
      newQuery = {
        ...query,
        returnedDate: undefined,
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
          Request List
        </p>
        <Stack
          direction="row"
          justifyContent="space-between"
          alignItems="center"
          spacing={12}
          className="mt-3"
        >
          <Stack
            direction="row"
            justifyContent="flex-start"
            alignItems="center"
            spacing={12}
          >
            <ReturningRequestState
              states={states}
              setStates={setStates}
              onSubmit={handleStateFilterClick}
            />

            <ReturnedDateFilter returnedDate={returnedDate} handleReturnedDateChange={setReturnedDate} handleFilterClick={handleReturnedDateFilterClick} />

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
          </Stack>
        </Stack>
        <div className="mt-3">
          <ReturningRequestList
            data={
              data?.items?.result?.map((item: FilterReturingRequestResponse) => ({
                id: item.id,
                assetCode: item.assetCode,
                assetName: item.assetName,
                requestedBy: item.requestedBy,
                acceptedBy: item.acceptedBy,
                returnedDate: convertDateToString(item.returnedDate),
                state:
                  item.state !== undefined ? ReturningRequestStateEnum[item.state] : undefined,
                action: {
                  id: item.id,
                  state:
                    item.state !== undefined
                      ? ReturningRequestStateEnum[item.state]
                      : undefined,
                },
              })) as ReturningRequestRowData[]
            }
            error={error}
            isLoading={isLoading}
            order={query?.order ?? "asc"}
            setOrder={setOrder}
            orderBy={query?.orderBy}
            setOrderBy={setOrderBy}
            handleClick={(event, rowId) => { } }
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
    </div>
  );
}

export default ManagementRequestForReturningPage;
