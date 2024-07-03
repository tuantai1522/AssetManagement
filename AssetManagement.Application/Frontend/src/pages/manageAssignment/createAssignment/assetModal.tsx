import { useState } from "react";
import {
  AssetState,
  FilterAssetRequest,
  FilterAssetResponse,
  OrderByFieldName,
} from "../../../app/models/asset/Asset";
import agent from "../../../app/api/agent";
import { Stack } from "@mui/material";
import { Search } from "@mui/icons-material";
import AppSearchInput from "../../../app/components/AppSearchInput";
import AppPagination from "../../../app/components/paginationButtons/paginationButtons";
import { AssetRowData } from "../../manageAsset/assetList";
import AssetListInAssignment from "./assetListInAssignment";
import AppButton from "../../../app/components/buttons/Button";
import { Order } from "../../../app/components/table/AssetAssignmentTable";

interface Props {
  style?: string;
  selectedValue?: FilterAssetResponse;
  setSelectedValue: (value: FilterAssetResponse) => void;
  onClickSave: () => void;
  onClickCancel: () => void;
}

export default function AssetModal({
  style,
  selectedValue,
  setSelectedValue,
  onClickCancel,
  onClickSave,
}: Props) {
  const [query, setQuery] = useState<FilterAssetRequest>({
    pageNumber: 1,
    pageSize: 5,
    states: [AssetState.Available],
  });

  const [searchInput, setSearchInput] = useState<string>();

  const { data, isLoading, error, mutate } = agent.Asset.filter(query);

  const setOrderBy = (orderBy: OrderByFieldName) => {
    setQuery((pre) => ({ ...pre, orderBy: orderBy }));
  };

  const setOrder = (order: Order) => {
    setQuery((pre) => ({ ...pre, order: order }));
  };

  const handlePageNumberChange = (value: any) => {
    let pageNumber = Number(value);
    pageNumber = !pageNumber || pageNumber <= 0 ? 1 : pageNumber;
    const newQuery: FilterAssetRequest = { ...query, pageNumber };
    setQuery(newQuery);
  };

  const handleSearchInputChange = (
    event: React.ChangeEvent<HTMLInputElement>
  ) => {
    const { name, value } = event.target;
    setSearchInput(value);
  };

  const handleSearchSubmit = () => {
    const newQuery: FilterAssetRequest = {
      ...query,
      pageNumber: 1,
      search: searchInput?.trim(),
    };
    setQuery(newQuery);
  };

  return (
    <div
      className={`flex justify-center absolute bg-white z-10 ${style}`}
      onClick={(e) => e.stopPropagation()}
    >
      <div className="container w-max p-5 border-[1px] border-gray-800 min-h-96">
        <Stack
          direction="row"
          justifyContent="space-between"
          alignItems="center"
          className="w-full"
        >
          <p className="text-primary text-xl font-bold justify-start items-start">
            Select Asset
          </p>
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
              onKeyDown={(event: any) => {
                if (event.code === "Enter") {
                  handleSearchSubmit();
                }
              }}
              className="!rounded-l-md !border !border-gray-400 !border-r-0"
            />
            <div
              onClick={handleSearchSubmit}
              className="border border-gray-500 border-l-0 rounded-r-md mx-0 hover:cursor-pointer"
              style={{ margin: 0, padding: "6px" }}
            >
              <Search className="mx-0" />
            </div>
          </Stack>
        </Stack>
        <div className="mt-3">
          <AssetListInAssignment
            data={
              data?.items?.result?.map((item: FilterAssetResponse) => ({
                id: item.id,
                assetCode: item.assetCode,
                name: item.name,
                category: item.category,
                state:
                  item.state !== undefined ? AssetState[item.state] : undefined,
                action: {
                  id: item.id,
                  state:
                    item.state !== undefined
                      ? AssetState[item.state]
                      : undefined,
                  category: item.category,
                  name: item.name,
                },
              })) as AssetRowData[]
            }
            error={error}
            isLoading={isLoading}
            order={query?.order ?? "asc"}
            setOrder={setOrder}
            orderBy={query?.orderBy}
            setOrderBy={setOrderBy}
            selectedValue={selectedValue}
            handleClick={(value) => setSelectedValue(value)}
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
        <div className="flex justify-end gap-3 mt-5">
          <AppButton
            content="Save"
            onClickOn={onClickSave}
            isDisabled={!selectedValue}
          ></AppButton>
          <AppButton
            content="Cancel"
            styleType="secondary"
            onClickOn={onClickCancel}
          ></AppButton>
        </div>
      </div>
    </div>
  );
}
