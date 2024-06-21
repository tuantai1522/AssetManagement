// import { useState } from "react";
import { useState } from "react";
import agent from "../../app/api/agent";
import { Order } from "../../app/components/table/sortTable";
import UserList from "./userList/userList";

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

  

  const { data, isLoading, error } = agent.Users.filter();

  return (
    <div className="flex justify-center h-full">
      <div className="container">
        <p className="text-primary text-xl font-bold justify-start items-start">User List</p>
        <div className="mt-3">
          <UserList
            data={data?.items?.result}
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
