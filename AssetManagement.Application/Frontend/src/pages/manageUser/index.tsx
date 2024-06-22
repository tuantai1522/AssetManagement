// import { useState } from "react";
import { useEffect, useState } from "react";
import agent from "../../app/api/agent";
import { Order } from "../../app/components/table/sortTable";
import UserList from "./userList/userList";
import { convertUtcToLocalDate } from "../../app/utils/dateUtils";
import { FilterUser } from "../../app/models/User";

interface Query {
  name?: string,
  type?: string,
  sortStaffCode?: Order,
  sortFullName?: Order,
  sortJoinedDate?: Order,
  sortType?: Order,
  pageNumber?: number,
  pageSize?: number
}

type OrderByFieldName = "staffCode" | "fullName" | "joinedDate" | "type";

export default function ManagementUserPage() {

  const [query, setQuery] = useState<Query>({
    sortJoinedDate: "desc",
    pageNumber: 1,
    pageSize: 5
  });

  const [order, setOrder] = useState<Order>("desc");
  const [orderBy, setOrderBy] = useState<OrderByFieldName>("joinedDate");

  useEffect(() => {
    switch (orderBy) {
      case "staffCode":
        {
          setQuery((query) => ({ ...query, sortStaffCode: order, sortFullName: undefined, sortJoinedDate: undefined, sortType: undefined }));
          mutate();
          break;
        }
      case "fullName":
        {
          setQuery((query) => ({ ...query, sortStaffCode: undefined, sortFullName: order, sortJoinedDate: undefined, sortType: undefined }));
          mutate();
          break;
        }
      case "joinedDate":
        {
          setQuery((query) => ({ ...query, sortStaffCode: undefined, sortFullName: undefined, sortJoinedDate: order, sortType: undefined }));
          mutate(); mutate();
          break;
        }
      case "type":
        {
          setQuery((query) => ({ ...query, sortStaffCode: undefined, sortFullName: undefined, sortJoinedDate: undefined, sortType: order }));
          mutate();
          break;
        }
      default:
        break;
    }

  }, [orderBy, order])

  const { data, isLoading, error, mutate } = agent.Users.filter(query);

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
          />
        </div>
      </div>
    </div>
  );
}


