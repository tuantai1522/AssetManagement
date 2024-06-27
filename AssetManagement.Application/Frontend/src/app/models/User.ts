import { Order } from "../components/table/sortTable";

export interface User {
  id: string;
  userName: string;
  role: string;
  token?: string;
  isPasswordChanged: boolean;
}

export interface FilterUser {
  id: string;
  staffCode: string;
  fullName?: string;
  username?: string;
  joinedDate?: Date;
  types: string[];
}

export interface UserQuery {
  name?: string;
  type?: string[];
  sortStaffCode?: Order;
  sortFullName?: Order;
  sortJoinedDate?: Order;
  sortType?: Order;
  sortLastUpdate?: Order;
  pageNumber?: number;
  pageSize?: number;
}

export function getUserQueryString(filter?: UserQuery) {
  if (!filter) {
    return "";
  }

  const nameParam = filter.name ? `name=${filter.name}&` : "";
  let typeParam = "";
  if (filter.type && filter.type.length > 0) {
    typeParam = filter.type.map((type) => `types=${type}&`).join("");
  }
  const sortStaffCodeParam = filter.sortStaffCode
    ? `sortStaffCode=${filter.sortStaffCode === "asc" ? 1 : 2}&`
    : "";
  const sortFullNameParam = filter.sortFullName
    ? `sortFullName=${filter.sortFullName === "asc" ? 1 : 2}&`
    : "";
  const sortJoinedDateParam = filter.sortJoinedDate
    ? `sortJoinedDate=${filter.sortJoinedDate === "asc" ? 1 : 2}&`
    : "";
  const sortTypeParam = filter.sortType
    ? `sortType=${filter.sortType === "asc" ? 1 : 2}&`
    : "";
    const sortLastUpdate = filter.sortLastUpdate
    ? `sortLastUpdate=${filter.sortLastUpdate === "asc" ? 1 : 2}&`
    : "";

  const pageParam = `pageNumber=${filter.pageNumber ?? 1}&`;
  const sizeParam = `pageSize=${filter.pageSize ?? 5}`;

  const queryString = `${nameParam}${typeParam}${sortStaffCodeParam}${sortFullNameParam}${sortJoinedDateParam}${sortTypeParam}${sortLastUpdate}${pageParam}${sizeParam}`;  return queryString;
}
