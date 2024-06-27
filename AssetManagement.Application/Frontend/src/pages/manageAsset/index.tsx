import AssetList, { AssetRowData } from "./assetList";
import { useEffect, useState } from "react";
import { FilterAssetRequest, FilterAssetResponse, getAssetQueryString } from "../../app/models/Asset";
import agent from "../../app/api/agent";
import { Order } from "../../app/components/table/sortTable";
import { Stack } from "@mui/material";
import { Search } from "@mui/icons-material";
import AppButton from "../../app/components/buttons/Button";
import AppSearchInput from "../../app/components/AppSearchInput";
import { SetURLSearchParams, useSearchParams } from "react-router-dom";
import AppPagination from "../../app/components/paginationButtons/paginationButtons";
import AssetStateFilter from "./assetStateFilter";

type OrderByFieldName =
  | "assetCode"
  | "name"
  | "category"
  | "state"
  | "lastUpdate";

function setFilterSearchParam(query: FilterAssetRequest, setSearchParams: SetURLSearchParams, order?: Order, orderBy?: OrderByFieldName) {
  const params = new URLSearchParams();

  if (query?.search) {
    params.set("search", query.search.toString());
  }

  if (query?.states && query.states.length > 0) {
    query.states.forEach((state) => {
      params.append("states", state);
    });
  }

  if (orderBy) {
    params.set("orderBy", orderBy.toString());
  }

  if (order) {
    params.set("order", order.toString());
  }

  if (query?.pageNumber) {
    params.set("pageNumber", query.pageNumber.toString());
  }

  if (query?.pageSize) {
    params.set("pageSize", query.pageSize.toString());
  }

  setSearchParams(params);
}

export default function ManagementAssetPage() {

  const [searchParams, setSearchParams] = useSearchParams();

  const initSearch = searchParams.get("search") ?? "";
  const initPageNumber = Number(searchParams.get("pageNumber") ?? "1");
  const initPageSize = Number(searchParams.get("pageSize") ?? "5");
  const initStates = searchParams.getAll("states");

  const [order, setOrder] = useState<Order>(searchParams.get("order") as Order ?? "asc");
  const [orderBy, setOrderBy] = useState<OrderByFieldName>(searchParams.get("orderBy") as OrderByFieldName ?? "assetCode");
  const [states, setStates] = useState<string[]>(initStates);

  const [query, setQuery] = useState<FilterAssetRequest>({
    search: initSearch,
    states: initStates,
    pageNumber: initPageNumber > 0 ? initPageNumber : 1,
    pageSize: initPageSize > 0 ? initPageSize : 5,
  });

  const [searchInput, setSearchInput] = useState<string>(initSearch);

  const { data, isLoading, error, mutate } = agent.Asset.filter(query);

  useEffect(() => {
    let newQuery: FilterAssetRequest = query;
    switch (orderBy) {
      case "assetCode": {
        newQuery = {
          ...query,
          sortAssetCode: order,
          sortAssetName: undefined,
          sortCategoryName: undefined,
          sortState: undefined,
          sortLastUpdate: undefined,
        };
        break;
      }
      case "name": {
        newQuery = {
          ...query,
          sortAssetCode: undefined,
          sortAssetName: order,
          sortCategoryName: undefined,
          sortState: undefined,
          sortLastUpdate: undefined,
        }
        break;
      }
      case "category": {
        newQuery = {
          ...query,
          sortAssetCode: undefined,
          sortAssetName: undefined,
          sortCategoryName: order,
          sortState: undefined,
          sortLastUpdate: undefined,
        }
        break;
      }
      case "state": {
        newQuery = {
          ...query,
          sortAssetCode: undefined,
          sortAssetName: undefined,
          sortCategoryName: undefined,
          sortState: order,
          sortLastUpdate: undefined,
        }
        break;
      }
      case "lastUpdate": {
        newQuery = {
          ...query,
          sortAssetCode: undefined,
          sortAssetName: undefined,
          sortCategoryName: undefined,
          sortState: undefined,
          sortLastUpdate: order,
        }
        break;
      }
      default:
        break;
    }
    if (newQuery !== query) {
      setQuery(newQuery);
      //update search param
      setFilterSearchParam(newQuery, setSearchParams, order, orderBy);
    }
  }, [orderBy, order]);

  const handlePageNumberChange = (value: any) => {
    let pageNumber = Number(value);
    pageNumber = !pageNumber || pageNumber <= 0 ? 1 : pageNumber;
    const newQuery: FilterAssetRequest = { ...query, pageNumber };
    setQuery(newQuery);
    //update search param
    setFilterSearchParam(newQuery, setSearchParams, order, orderBy);
  };

  const handleSearchInputChange = (
    event: React.ChangeEvent<HTMLInputElement>
  ) => {
    const { name, value } = event.target;
    setSearchInput(value);
  };

  const handleSearchSubmit = () => {
    const newQuery: FilterAssetRequest = { ...query, pageNumber: 1, search: searchInput?.trim(), };
    setQuery(newQuery);
    //update search param
    setFilterSearchParam(newQuery, setSearchParams, order, orderBy);
  }

  const handleStateFilterClick = () => {
    let newQuery: FilterAssetRequest;
    if (states.length === 0 || states.includes("all")) {
      newQuery = { ...query, states: [], pageNumber: 1 };
      setQuery(newQuery);
      setFilterSearchParam(newQuery, setSearchParams, order, orderBy);
    } else {
      newQuery = { ...query, states: states, pageNumber: 1 };
      setQuery(newQuery);
      setFilterSearchParam(newQuery, setSearchParams, order, orderBy);
    }
  };

  return (
    <div className="flex justify-center h-full">
      <div className="container mb-12">
        <p className="text-primary text-xl font-bold justify-start items-start">
          Asset List
        </p>
        <Stack
          direction="row"
          justifyContent="space-between"
          alignItems="center"
          spacing={2}
          className="mt-3"
        >
          <Stack
            direction="row"
            justifyContent="flex-start"
            alignItems="center"
            spacing={2}
          >
            <AssetStateFilter
              states={states}
              setStates={setStates}
              onSubmit={handleStateFilterClick}
            />
          </Stack>
          <Stack
            direction="row"
            justifyContent="flex-end"
            alignItems="center"
            spacing={8}>
            <Stack
              direction="row"
              justifyContent="flex-start"
              alignItems="center"
              spacing={2}>
              <AppSearchInput type="text" placeholder="Search" name="name" value={searchInput} onChange={handleSearchInputChange}
                className="!rounded-l-md !border !border-gray-400 !border-r-0"
              />

              <div onClick={handleSearchSubmit} className="border border-gray-500 border-l-0 rounded-r-md mx-0 hover:cursor-pointer" style={{ margin: 0, padding: "6px" }}>
                <Search className="mx-0" />
              </div>
            </Stack>
            <AppButton
              content="Create new user"
              className="py-[6px]"
            />
          </Stack>
        </Stack>
        <div className="mt-3">
          <AssetList
            data={data?.items?.result?.map((item: FilterAssetResponse) => ({
              id: item.id,
              assetCode: item.assetCode,
              name: item.name,
              category: item.category,
              state: item.state,
              action: {
                id: item.id,
                state: item.state,
              }
            })) as AssetRowData[]}
            error={error}
            isLoading={isLoading}
            order={order}
            setOrder={setOrder}
            orderBy={orderBy}
            setOrderBy={setOrderBy}
            handleClick={(event, rowId) => { }}
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
