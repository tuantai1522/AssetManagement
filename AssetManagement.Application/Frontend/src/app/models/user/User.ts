import { Order } from "../../components/table/sortTable";

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
  types?: string[];
  sortStaffCode?: Order;
  sortFullName?: Order;
  sortJoinedDate?: Order;
  sortType?: Order;
  sortLastUpdate?: Order;
  pageNumber?: number;
  pageSize?: number;
  order?: Order;
  orderBy?: string;
}

export type OrderByFieldName =
  | "staffCode"
  | "fullName"
  | "joinedDate"
  | "type"
  | "lastUpdate";

export function getUserQueryString(filter?: UserQuery) {
  if (!filter) {
    return "";
  }

  let sortStaffCodeParam: string = "";
  let sortFullNameParam: string = "";
  let sortJoinedDateParam: string = "";
  let sortTypeParam: string = "";
  let sortLastUpdate: string = "";

  const nameParam = filter.name ? `name=${filter.name}&` : "";
  let typeParam = "";
  if (filter.types && filter.types.length > 0) {
    typeParam = filter.types.map((type) => `types=${type}&`).join("");
  }

  switch (filter?.orderBy) {
    case "staffCode": {
      sortStaffCodeParam = `sortStaffCode=${filter?.order === "asc" ? 1 : 2}&`;
      break;
    }
    case "fullName": {
      sortFullNameParam = `sortFullName=${filter?.order === "asc" ? 1 : 2}&`;
      break;
    }
    case "joinedDate": {
      sortJoinedDateParam = `sortJoinedDate=${
        filter?.order === "asc" ? 1 : 2
      }&`;
      break;
    }
    case "type": {
      sortTypeParam = `sortType=${filter?.order === "asc" ? 1 : 2}&`;
      break;
    }
    case "lastUpdate": {
      sortTypeParam = `sortLastUpdate=${filter?.order === "asc" ? 1 : 2}&`;
      break;
    }
    default: {
      break;
    }
  }

  const pageParam = `pageNumber=${filter.pageNumber ?? 1}&`;
  const sizeParam = `pageSize=${filter.pageSize ?? 5}`;

  const queryString = `${nameParam}${typeParam}${sortStaffCodeParam}${sortFullNameParam}${sortJoinedDateParam}${sortTypeParam}${sortLastUpdate}${pageParam}${sizeParam}`;
  return queryString;
}
