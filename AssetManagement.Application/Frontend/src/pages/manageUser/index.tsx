// import { useState } from "react";
import { useEffect, useState } from "react";
import agent, { UserQuery } from "../../app/api/agent";
import { Order } from "../../app/components/table/sortTable";
import UserInfo from "../../app/components/userInfo/userInfo";
import ConfirmModal from "../../app/components/confirmModal";
import UserList from "./userList/userList";
import { convertUtcToLocalDate } from "../../app/utils/dateUtils";
import { FilterUser } from "../../app/models/User";
import { IconButton, Stack } from "@mui/material";
import UsePagination from "../../app/components/paginationButtons/paginationButtons";
import { Search } from "@mui/icons-material";

type OrderByFieldName = "staffCode" | "fullName" | "joinedDate" | "type" | "lastUpdate";

export default function ManagementUserPage() {
  const [clickOnUser, setClickOnUser] = useState<boolean>(false)
  const [userId, setUserId] = useState<string>("0")

  const [query, setQuery] = useState<UserQuery>({
    sortJoinedDate: "desc",
    pageNumber: 1,
    pageSize: 5
  });
  const { data, isLoading, error, mutate } = agent.Users.filter(query);
  const {data:userData, isLoading:userLoading, error:userError} = agent.Users.details(userId);

  const [isDisablingModalOpen, setIsDisablingModalOpen] = useState(false);
  const [currentDisablingId, setCurrentDisablingId] = useState("");

  const handleDisable = (id: string) => {
    agent.Users.disable(id);
    mutate();
  };

  const [searchInput, setSearchInput] = useState<string>("");

  const [order, setOrder] = useState<Order>("desc");
  const [orderBy, setOrderBy] = useState<OrderByFieldName>("joinedDate");

  const { data, isLoading, error, mutate } = agent.Users.filter(query);
  const { data: userData, isLoading: userLoading, error: userError } = agent.Users.details(userId);

  useEffect(() => {
    switch (orderBy) {
      case "staffCode":
        {
          setQuery((query) => ({ ...query, sortStaffCode: order, sortFullName: undefined, sortJoinedDate: undefined, sortType: undefined, sortLastUpdate: undefined }));
          mutate(query);
          break;
        }
      case "fullName":
        {
          setQuery((query) => ({ ...query, sortStaffCode: undefined, sortFullName: order, sortJoinedDate: undefined, sortType: undefined, sortLastUpdate: undefined }));
          mutate(query);
          break;
        }
      case "joinedDate":
        {
          setQuery((query) => ({ ...query, sortStaffCode: undefined, sortFullName: undefined, sortJoinedDate: order, sortType: undefined, sortLastUpdate: undefined }));
          mutate(query);
          break;
        }
      case "type":
        {
          setQuery((query) => ({ ...query, sortStaffCode: undefined, sortFullName: undefined, sortJoinedDate: undefined, sortType: order, sortLastUpdate: undefined }));
          mutate(query);
          break;
        }
      case "lastUpdate":
        {
          setQuery((query) => ({ ...query, sortStaffCode: undefined, sortFullName: undefined, sortJoinedDate: undefined, sortType: undefined, sortLastUpdate: order }));
          mutate(query);
          break;
        }
      default:
        break;
    }

  }, [orderBy, order])

  const handlePageNumberChange = (value: any) => {
    const pageNumber = Number(value);
    setQuery((prevQuery) => ({ ...prevQuery, pageNumber }));
    mutate(query);
  };

  const handleQueryInputChange = (event: React.ChangeEvent<HTMLInputElement>) => {
    const { name, value } = event.target;
    setSearchInput(value);
  }

  const handleSerchSubmit = () => {
    setQuery((prevQuery) => ({
      ...prevQuery,
      name: searchInput,
      pageNumber: 1,
    }));
    mutate(query);
  }

  const handleClickOnUser = (rowId: string) => {
    setClickOnUser(true);
    setUserId(data.items.result[rowId].id);
  }
  return (
    <div className="flex justify-center h-full">
      <div className="container">
        <p className="text-primary text-xl font-bold justify-start items-start">User List</p>
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
            <input type="text" placeholder="Search" name="name" value={searchInput} onChange={handleQueryInputChange} />
            <IconButton aria-label="Search" onClick={handleSerchSubmit} size="small">
              <Search />
            </IconButton>

          </Stack>

        </Stack>
        <div className="mt-3">
          <UserList
            data={data?.items?.result?.map((item: FilterUser) => ({
              ...item,
              joinedDate: convertUtcToLocalDate(item?.joinedDate),
            }))}
            error={error}
            isLoading={isLoading}
            order={order}
            setOrder={setOrder}
            orderBy={orderBy}
            setOrderBy={setOrderBy}
            setIsOpenDisablingModal={setIsDisablingModalOpen}
            setCurrentDisablingId={setCurrentDisablingId}
            handleClick={(event, rowId) => handleClickOnUser(rowId)}
          />

          <Stack
            direction="row"
            justifyContent="flex-end"
            alignItems="baseline"
          >
            <UsePagination totalPage={data?.metaData?.totalPageCount ?? 1} onChange={handlePageNumberChange} />
          </Stack>
        </div>
      </div>
      <ConfirmModal
        message="Do you want to disable this user?"
        confirmMessage="Disable"
        isOpen={isDisablingModalOpen}
        onClose={() => setIsDisablingModalOpen(false)}
        onConfirm={() => {
          setIsDisablingModalOpen(false);
          handleDisable(currentDisablingId);
        }}
      />
      <UserInfo
        isOpen={clickOnUser}
        isLoading={userLoading}
        userData={userData?.result}
        onClose={() => {
          setClickOnUser(false);
        }}
      ></UserInfo>
    </div>
  );
}
