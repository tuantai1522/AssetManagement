import { useEffect, useRef, useState } from "react";
import agent from "../../../app/api/agent";
import { Stack } from "@mui/material";
import { Search } from "@mui/icons-material";
import AppSearchInput from "../../../app/components/AppSearchInput";
import AppPagination from "../../../app/components/paginationButtons/paginationButtons";
import AppButton from "../../../app/components/buttons/Button";
import {
  FilterUser,
  OrderByFieldName,
  UserQuery,
} from "../../../app/models/user/User";
import UserListInAssignment from "./userListInAssignment";
import { convertUtcToLocalDate } from "../../../app/utils/dateUtils";
import { Order } from "../../../app/components/table/AssetAssignmentTable";

interface Props {
  style?: string;
  selectedValue?: FilterUser;
  setSelectedValue: (value: FilterUser) => void;
  onClickSave: () => void;
  onClickCancel: () => void;
}

export default function UserModal({
  style,
  selectedValue,
  setSelectedValue,
  onClickCancel,
  onClickSave,
}: Props) {
  const [query, setQuery] = useState<UserQuery>({
    pageNumber: 1,
    pageSize: 5,
    orderBy: "joinedDate",
  });

  const [searchInput, setSearchInput] = useState<string>();
  const modalRef = useRef<HTMLDivElement>(null);
  
  const { data, isLoading, error, mutate } = agent.Users.filter(query);

  const setOrderBy = (orderBy: OrderByFieldName) => {
    setQuery((pre) => ({ ...pre, orderBy: orderBy }));
  };

  const setOrder = (order: Order) => {
    setQuery((pre) => ({ ...pre, order: order }));
  };

  const handlePageNumberChange = (value: any) => {
    let pageNumber = Number(value);
    pageNumber = !pageNumber || pageNumber <= 0 ? 1 : pageNumber;
    const newQuery = { ...query, pageNumber };
    setQuery(newQuery);
  };

  const handleSearchInputChange = (
    event: React.ChangeEvent<HTMLInputElement>
  ) => {
    debugger;
    const { name, value } = event.target;
    setSearchInput(value);
  };

  const handleSearchSubmit = () => {
    const newQuery: UserQuery = {
      ...query,
      pageNumber: 1,
      name: searchInput?.trim(),
    };
    setQuery(newQuery);
  };

  useEffect(() => {
    if (modalRef.current) {
      modalRef.current.focus();
    }
  }, []);

  return (
    <div
      className={`flex justify-center absolute bg-white z-10 ${style} cursor-default focus:outline-none`}
      onClick={(e) => e.stopPropagation()}
      ref={modalRef}
      tabIndex={-1}
    >
      <div className="container w-max p-5 border-[1px] border-gray-800 min-h-96">
        <Stack
          direction="row"
          justifyContent="space-between"
          alignItems="center"
          className="w-full"
        >
          <p className="text-primary text-xl font-bold justify-start items-start">
            Select User
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
                if (event.code === "Enter" || event.code === 'NumpadEnter') {
                  event.preventDefault();
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
          <UserListInAssignment
            data={data?.items?.result?.map((item: FilterUser) => ({
              ...item,
              joinedDate: convertUtcToLocalDate(item?.joinedDate),
              action: {
                id: item.id,
                name: item.fullName,
              },
            }))}
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
