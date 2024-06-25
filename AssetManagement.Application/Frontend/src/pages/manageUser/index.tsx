// import { useState } from "react";
import { useEffect, useState } from "react";
import agent, { UserQuery } from "../../app/api/agent";
import { Order } from "../../app/components/table/sortTable";
import UserInfo from "../../app/components/userInfo/userInfo";
import ConfirmModal from "../../app/components/confirmModal";
import UserList from "./userList/userList";
import { convertUtcToLocalDate } from "../../app/utils/dateUtils";
import { FilterUser } from "../../app/models/User";
import { Alert, Snackbar, Stack } from "@mui/material";
import UsePagination from "../../app/components/paginationButtons/paginationButtons";
import { Search } from "@mui/icons-material";
import AppSearchInput from "../../app/components/AppSearchInput";
import AppButton from "../../app/components/buttons/Button";
import { useNavigate, useSearchParams } from "react-router-dom";
import UserType from "./userList/userType";
import { BaseResult } from "../../app/models/BaseResult";

type OrderByFieldName =
  | "staffCode"
  | "fullName"
  | "joinedDate"
  | "type"
  | "lastUpdate";

const isOrderByFieldName = (value: any): value is OrderByFieldName => {
  return ["staffCode", "fullName", "joinedDate", "type", "lastUpdate"].includes(
    value
  );
};

const isOrder = (value: any): value is Order => {
  return ["asc", "desc"].includes(value);
};

export default function ManagementUserPage() {
  const navigate = useNavigate();
  const [clickOnUser, setClickOnUser] = useState<boolean>(false);
  const [userId, setUserId] = useState<string>("0");
  const [types, setTypes] = useState<string[]>([]);

  const [query, setQuery] = useState<UserQuery>({
    sortJoinedDate: "desc",
    pageNumber: 1,
    pageSize: 5,
  });
  const { data, isLoading, error, mutate } = agent.Users.filter(query);
  const {
    data: userData,
    isLoading: userLoading,
    error: userError,
  } = agent.Users.details(userId);

  const [isDisablingModalOpen, setIsDisablingModalOpen] = useState(false);
  const [currentDisablingId, setCurrentDisablingId] = useState("");

  const [isErrorModalOpen, setIsErrorModalOpen] = useState(false);
  const [currentErrorMessage, setCurrentErrorMessage] = useState(false);

  const handleDisable = async (id: string) => {
    try {
      await agent.Users.disable(id).then(mutate);
    } catch (e) {
      setCurrentErrorMessage(e?.error?.message);
      setIsErrorModalOpen(true);
    }
  };

  const [searchInput, setSearchInput] = useState<string>("");

  const [order, setOrder] = useState<Order>("desc");
  const [orderBy, setOrderBy] = useState<OrderByFieldName>("joinedDate");

  const [searchParams] = useSearchParams();
  const passedOrderBy = searchParams.get("passedOrderBy") ?? undefined;
  const passedOrder = searchParams.get("passedOrder") ?? undefined;

  useEffect(() => {
    if (passedOrderBy && isOrderByFieldName(passedOrderBy)) {
      setOrderBy(passedOrderBy);
    }
    if (passedOrder && isOrder(passedOrder)) {
      setOrder(passedOrder);
    }
  }, [passedOrderBy, passedOrder])
  

  useEffect(() => {
    switch (orderBy) {
      case "staffCode": {
        setQuery((query) => ({
          ...query,
          sortStaffCode: order,
          sortFullName: undefined,
          sortJoinedDate: undefined,
          sortType: undefined,
          sortLastUpdate: undefined,
        }));
        mutate(query);
        break;
      }
      case "fullName": {
        setQuery((query) => ({
          ...query,
          sortStaffCode: undefined,
          sortFullName: order,
          sortJoinedDate: undefined,
          sortType: undefined,
          sortLastUpdate: undefined,
        }));
        mutate(query);
        break;
      }
      case "joinedDate": {
        setQuery((query) => ({
          ...query,
          sortStaffCode: undefined,
          sortFullName: undefined,
          sortJoinedDate: order,
          sortType: undefined,
          sortLastUpdate: undefined,
        }));
        mutate(query);
        break;
      }
      case "type": {
        setQuery((query) => ({
          ...query,
          sortStaffCode: undefined,
          sortFullName: undefined,
          sortJoinedDate: undefined,
          sortType: order,
          sortLastUpdate: undefined,
        }));
        mutate(query);
        break;
      }
      case "lastUpdate": {
        setQuery((query) => ({
          ...query,
          sortStaffCode: undefined,
          sortFullName: undefined,
          sortJoinedDate: undefined,
          sortType: undefined,
          sortLastUpdate: order,
        }));
        mutate(query);
        break;
      }
      default:
        break;
    }
  }, [orderBy, order]);

  const handlePageNumberChange = (value: any) => {
    const pageNumber = Number(value);
    setQuery((prevQuery) => ({ ...prevQuery, pageNumber }));
    mutate(query);
  };

  const handleQueryInputChange = (
    event: React.ChangeEvent<HTMLInputElement>
  ) => {
    const { name, value } = event.target;
    setSearchInput(value);
  };

  const handleSerchSubmit = () => {
    setQuery((prevQuery) => ({
      ...prevQuery,
      pageNumber: 1,
      name: searchInput?.trim(),
    }));
    mutate();
  };
  const handleClickOnUser = (rowId: string) => {
    setClickOnUser(true);
    setUserId(data.items.result[rowId].id);
  };

  const handleFilterClick = () => {
    if (types.length === 0 || types.includes("All")) {
      setQuery((query) => ({ ...query, type: [], pageNumber: 1 }));
    } else {
      setQuery((query) => ({ ...query, type: types, pageNumber: 1 }));
    }
    mutate(query);
  };

  return (
    <div className="flex justify-center h-full">
      <div className="container">
        <Snackbar
          anchorOrigin={{ vertical: "top", horizontal: "right" }}
          open={isErrorModalOpen}
          autoHideDuration={5000}
          onClose={() => setIsErrorModalOpen(false)}
        >
          <Alert
            onClose={() => setIsErrorModalOpen(false)}
            severity="error"
            variant="outlined"
            sx={{ width: "100%", bgcolor: 'background.paper' }}
          >
            {currentErrorMessage}
          </Alert>
        </Snackbar>
        <p className="text-primary text-xl font-bold justify-start items-start">
          User List
        </p>
        <Stack
          direction="row"
          justifyContent="space-between"
          alignItems="center"
          spacing={2}
          className="mt-3"
        >
          <UserType
            types={types}
            setTypes={setTypes}
            onSubmit={handleFilterClick}
          />
          <Stack
            direction="row"
            justifyContent="flex-end"
            alignItems="center"
            spacing={8}
          >
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
                onChange={handleQueryInputChange}
                className="!rounded-l-md !border !border-gray-400 !border-r-0"
              />

              <div
                onClick={handleSerchSubmit}
                className="border border-gray-500 border-l-0 rounded-r-md mx-0 hover:cursor-pointer"
                style={{ margin: 0, padding: "6px" }}
              >
                <Search className="mx-0" />
              </div>
            </Stack>
            <AppButton
              content="Create new user"
              className="py-[6px]"
              onClickOn={() => {
                navigate(`/manage-user/create-user`);
              }}
            />
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
            <UsePagination
              totalPage={data?.metaData?.totalPageCount ?? 1}
              onChange={handlePageNumberChange}
              currentPage={data?.metaData?.currentPage ?? 1}
            />
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
