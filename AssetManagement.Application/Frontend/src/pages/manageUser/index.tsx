import { useEffect, useState } from "react";
import agent from "../../app/api/agent";
import { Order } from "../../app/components/table/sortTable";
import UserInfo from "../../app/components/userInfo/userInfo";
import ConfirmModal from "../../app/components/confirmModal";
import UserList from "./userList/userList";
import { convertUtcToLocalDate } from "../../app/utils/dateUtils";
import { FilterUser, OrderByFieldName, UserQuery } from "../../app/models/user/User";
import { Alert, Snackbar, Stack } from "@mui/material";
import UsePagination from "../../app/components/paginationButtons/paginationButtons";
import { Search } from "@mui/icons-material";
import AppSearchInput from "../../app/components/AppSearchInput";
import AppButton from "../../app/components/buttons/Button";
import { useLocation, SetURLSearchParams, useNavigate, useSearchParams } from "react-router-dom";
import UserType from "./userList/userType";
import { BaseResult } from "../../app/models/BaseResult";

const isOrderByFieldName = (value: any): value is OrderByFieldName => {
  return ["staffCode", "fullName", "joinedDate", "type", "lastUpdate"].includes(
    value
  );
};

const isOrder = (value: any): value is Order => {
  return ["asc", "desc"].includes(value);
};

function setFilterSearchParam(query: UserQuery, setSearchParams: SetURLSearchParams) {
  const params = new URLSearchParams();

  if (query?.name) {
    params.set("name", query.name.toString());
  }

  if (query?.types && query.types.length > 0) {
    query?.types?.forEach((item) => {
      if (item)
        params.append("types", item);
    });
  }

  if (query?.orderBy) {
    params.set("orderBy", query?.orderBy.toString());
  }

  if (query?.order) {
    params.set("order", query?.order.toString());
  }

  if (query?.pageNumber) {
    params.set("pageNumber", query.pageNumber.toString());
  }

  if (query?.pageSize) {
    params.set("pageSize", query.pageSize.toString());
  }

  setSearchParams(params);
}

export default function ManagementUserPage() {
  const [searchParams, setSearchParams] = useSearchParams();
  const navigate = useNavigate();

  const initQueryName = searchParams.get("name") ?? "";
  const initPageNumber = Number(searchParams.get("pageNumber") ?? "1");
  const initPageSize = Number(searchParams.get("pageSize") ?? "5");
  const initTypes = searchParams.getAll("types");
  const initOrder = searchParams.get("order") as Order;
  const initOrderBy = searchParams.get("orderBy") as OrderByFieldName;

  const [clickOnUser, setClickOnUser] = useState<boolean>(false);
  const [userId, setUserId] = useState<string>("0");
  const [types, setTypes] = useState<string[]>(initTypes);

  const [query, setQuery] = useState<UserQuery>({
    name: initQueryName,
    types: initTypes,
    pageNumber: initPageNumber > 0 ? initPageNumber : 1,
    pageSize: initPageSize > 0 ? initPageSize : 5,
    order: initOrder ?? "desc",
    orderBy: initOrderBy ?? "joinedDate"
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
  const [currentErrorMessage, setCurrentErrorMessage] = useState("");

  const [searchInput, setSearchInput] = useState<string>(initQueryName);

  const passedOrderBy = searchParams.get("passedOrderBy") ?? undefined;
  const passedOrder = searchParams.get("passedOrder") ?? undefined;

  useEffect(() => {
    if (passedOrderBy && isOrderByFieldName(passedOrderBy)) {
      setOrderBy(passedOrderBy);
    }
    if (passedOrder && isOrder(passedOrder)) {
      setOrder(passedOrder);
    }
    
    if (window.location.search) {
      navigate(window.location.pathname, {
        replace: true,
      });
    }
  }, [navigate, searchParams, passedOrderBy, passedOrder]);

  const handleDisable = async (id: string) => {
    try {
      await agent.Users.disable(id).then(mutate);
    } catch (e) {
      const err = e as BaseResult<any>;
      if (err?.error) {
        if (err?.error?.message) setCurrentErrorMessage(err?.error?.message);
      } else {
        setCurrentErrorMessage(
          "An unexpected error happened. Please try again!"
        );
      }
      setIsErrorModalOpen(true);
    }
  };

  const setOrderBy = (orderBy: OrderByFieldName) => {
    const newQuery = { ...query, orderBy: orderBy }
    setQuery((pre) => ({ ...pre, orderBy: orderBy }));
    setFilterSearchParam(newQuery, setSearchParams);
  }

  const setOrder = (order: Order) => {
    const newQuery = { ...query, order: order }
    setQuery((pre) => ({ ...pre, order: order }));
    setFilterSearchParam(newQuery, setSearchParams);

  }

  const handlePageNumberChange = (value: any) => {
    const pageNumber = Number(value);
    const newQuery = { ...query, pageNumber }
    setQuery(newQuery);
    setFilterSearchParam(newQuery, setSearchParams);
  };

  const handleQueryInputChange = (
    event: React.ChangeEvent<HTMLInputElement>
  ) => {
    const { name, value } = event.target;
    setSearchInput(value);
  };

  const handleSerchSubmit = () => {
    const newQuery = {
      ...query,
      pageNumber: 1,
      name: searchInput?.trim(),
    }
    setQuery(newQuery);
    setFilterSearchParam(newQuery, setSearchParams);
  };

  const handleClickOnUser = (rowId: string) => {
    setClickOnUser(true);
    setUserId(data.items.result[rowId].id);
  };

  const handleFilterClick = () => {
    let newQuery: UserQuery = query;
    if (types.length === 0 || types.includes("all")) {
      newQuery = { ...query, types: [], pageNumber: 1 };
    } else {
      newQuery = { ...query, types: types, pageNumber: 1 };
    }
    setQuery(newQuery);
    setFilterSearchParam(newQuery, setSearchParams);
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
            sx={{ width: "100%", bgcolor: "background.paper" }}
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
            order={query?.order ?? "asc"}
            setOrder={setOrder}
            orderBy={query?.orderBy}
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
