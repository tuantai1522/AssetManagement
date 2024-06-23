// import { useState } from "react";
import { useEffect, useState } from "react";
import agent, { UserQuery } from "../../app/api/agent";
import { Order } from "../../app/components/table/sortTable";
import ConfirmModal from "../../app/components/confirmModal";
import UserList from "./userList/userList";
import { convertUtcToLocalDate } from "../../app/utils/dateUtils";
import { FilterUser } from "../../app/models/User";
import { Pagination, Stack } from "@mui/material";

type OrderByFieldName = "staffCode" | "fullName" | "joinedDate" | "type" | "lastUpdate";

export default function ManagementUserPage() {
  const [query, setQuery] = useState<UserQuery>({
    sortJoinedDate: "desc",
    pageNumber: 1,
    pageSize: 5
  });
  const { data, isLoading, error, mutate } = agent.Users.filter(query);

  const [isDisablingModalOpen, setIsDisablingModalOpen] = useState(false);
  const [currentDisablingId, setCurrentDisablingId] = useState("");

  const handleDisable = (id: string) => {
    agent.Users.disable(id);
    mutate();
  };

  const [order, setOrder] = useState<Order>("desc");
  const [orderBy, setOrderBy] = useState<OrderByFieldName>("joinedDate");

  useEffect(() => {
    switch (orderBy) {
      case "staffCode":
        {
          setQuery((query) => ({ ...query, sortStaffCode: order, sortFullName: undefined, sortJoinedDate: undefined, sortType: undefined, sortLastUpdate: undefined }));
          mutate();
          break;
        }
      case "fullName":
        {
          setQuery((query) => ({ ...query, sortStaffCode: undefined, sortFullName: order, sortJoinedDate: undefined, sortType: undefined, sortLastUpdate: undefined }));
          mutate();
          break;
        }
      case "joinedDate":
        {
          setQuery((query) => ({ ...query, sortStaffCode: undefined, sortFullName: undefined, sortJoinedDate: order, sortType: undefined, sortLastUpdate: undefined }));
          mutate(); 
          break;
        }
      case "type":
        {
          setQuery((query) => ({ ...query, sortStaffCode: undefined, sortFullName: undefined, sortJoinedDate: undefined, sortType: order, sortLastUpdate: undefined }));
          mutate();
          break;
        }
        case "lastUpdate":
        {
          setQuery((query) => ({ ...query, sortStaffCode: undefined, sortFullName: undefined, sortJoinedDate: undefined, sortType: undefined, sortLastUpdate: order }));
          mutate();
          break;
        }
      default:
        break;
    }

  }, [orderBy, order])

  useEffect(() => {
    const reloadData = async () => {
      await mutate(query);
    };

    reloadData();

    return () => {
    };
  }, [query.pageNumber]);

  const handlePageNumberChange = (value: any) => {
    const pageNumber = Number(value);
    setQuery((prevQuery) => ({ ...prevQuery, pageNumber }));
  };

  return (
    <div className="flex justify-center h-full">
      <div className="container">
        <p className="text-primary text-xl font-bold justify-start items-start">User List</p>
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
          />

          <Stack
            direction="row"
            justifyContent="flex-end"
            alignItems="baseline"
          >
            <Pagination count={data?.metaData?.totalPageCount ?? 1} onChange={(event, value) => handlePageNumberChange(value)} variant="outlined" shape="rounded" />
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
      {/* <NotifyModal
        message="You have succesfully change the password"
        title="Change Password"
        isOpen={true}
        onClose={() => {}}
      />  */}
    </div>
  );
}
