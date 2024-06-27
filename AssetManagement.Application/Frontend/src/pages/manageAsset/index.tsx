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

type OrderByFieldName =
  | "assetCode"
  | "name"
  | "category"
  | "state"
  | "lastUpdate";

function setFilterSearchParam(query: FilterAssetRequest, setSearchParams: SetURLSearchParams, order?: Order, orderBy?: OrderByFieldName) {
  const params = new URLSearchParams();

  if (orderBy !== undefined) {
    params.set("orderBy", orderBy.toString());
  }

  if (order !== undefined) {
    params.set("order", order.toString());
  }

  if (query.pageNumber !== undefined) {
    params.set("pageNumber", query.pageNumber.toString());
  }

  if (query.pageSize !== undefined) {
    params.set("pageSize", query.pageSize.toString());
  }

  setSearchParams(params);
}

export default function ManagementAssetPage() {

  const [searchParams, setSearchParams] = useSearchParams({});

  const [order, setOrder] = useState<Order>(searchParams.get("order") as Order);
  const [orderBy, setOrderBy] = useState<OrderByFieldName>(searchParams.get("orderBy") as OrderByFieldName);

  const [query, setQuery] = useState<FilterAssetRequest>({
    pageNumber: Number(searchParams.get("pageNumber") ?? 1),
    pageSize: Number(searchParams.get("pageSize") ?? 5),
  });

  const [searchInput, setSearchInput] = useState<string>("");

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
    const pageNumber = Number(value);
    const newQuery = { ...query, pageNumber }
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
    setQuery((prevQuery) => ({
      ...prevQuery,
      pageNumber: 1,
      name: searchInput?.trim(),
    }));
    // mutate();
    //fake api 
    getAssetQueryString({
      ...query,
      pageNumber: 1,
      name: searchInput?.trim(),
    });
  }

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
          <div></div>
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
