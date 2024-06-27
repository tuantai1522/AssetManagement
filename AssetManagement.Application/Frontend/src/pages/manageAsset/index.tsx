import AssetList, { AssetRowData } from "./assetList";
import { useEffect, useState } from "react";
import { FilterAssetRequest, FilterAssetResponse, getAssetQueryString } from "../../app/models/Asset";
import agent from "../../app/api/agent";
import { Order } from "../../app/components/table/sortTable";
import { Stack } from "@mui/material";
import { Search } from "@mui/icons-material";
import AppButton from "../../app/components/buttons/Button";
import AppSearchInput from "../../app/components/AppSearchInput";

type OrderByFieldName =
  | "assetCode"
  | "name"
  | "category"
  | "state"
  | "lastUpdate";

export default function ManagementAssetPage() {

  const [order, setOrder] = useState<Order>("asc");
  const [orderBy, setOrderBy] = useState<OrderByFieldName>("assetCode");

  const [query, setQuery] = useState<FilterAssetRequest>({
    sortAssetName: "asc",
    pageNumber: 1,
    pageSize: 5,
  });

  const [searchInput, setSearchInput] = useState<string>("");

  const { data, isLoading, error, mutate } = agent.Asset.filter(query);

  useEffect(() => {
    switch (orderBy) {
      case "assetCode": {
        setQuery((query) => ({
          ...query,
          sortAssetCode: order,
          sortAssetName: undefined,
          sortCategoryName: undefined,
          sortState: undefined,
          sortLastUpdate: undefined,
        }));
        //refresh
        mutate();
        break;
      }
      case "name": {
        setQuery((query) => ({
          ...query,
          sortAssetCode: undefined,
          sortAssetName: order,
          sortCategoryName: undefined,
          sortState: undefined,
          sortLastUpdate: undefined,
        }));
        //refresh
        mutate();
        break;
      }
      case "category": {
        setQuery((query) => ({
          ...query,
          sortAssetCode: undefined,
          sortAssetName: undefined,
          sortCategoryName: order,
          sortState: undefined,
          sortLastUpdate: undefined,
        }));
        //refresh
        mutate();
        break;
      }
      case "state": {
        setQuery((query) => ({
          ...query,
          sortAssetCode: undefined,
          sortAssetName: undefined,
          sortCategoryName: undefined,
          sortState: order,
          sortLastUpdate: undefined,
        }));
        //refresh
        mutate();
        break;
      }
      case "lastUpdate": {
        setQuery((query) => ({
          ...query,
          sortAssetCode: undefined,
          sortAssetName: undefined,
          sortCategoryName: undefined,
          sortState: undefined,
          sortLastUpdate: order,
        }));
        //refresh
        mutate();
        break;
      }
      default:
        break;
    }
  }, [orderBy, order]);

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
    //test
    getAssetQueryString({
      ...query,
      pageNumber: 1,
      name: searchInput?.trim(),
    });
  }

  return (
    <div className="flex justify-center h-full">
      <div className="container">
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
        </div>
      </div>
    </div>
  );
}
