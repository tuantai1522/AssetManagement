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

  let sortOption: string = "";

  const nameParam = filter.name ? `name=${filter.name}&` : "";
  let typeParam = "";
  if (filter.types && filter.types.length > 0) {
    typeParam = filter.types.map((type) => `types=${type}&`).join("");
  }

  switch (filter?.orderBy) {
    case "staffCode": {
      sortOption = `sortStaffCode=${filter?.order === "asc" ? 1 : 2}&`;
      break;
    }
    case "fullName": {
      sortOption = `sortFullName=${filter?.order === "asc" ? 1 : 2}&`;
      break;
    }
    case "joinedDate": {
      sortOption = `sortJoinedDate=${filter?.order === "asc" ? 1 : 2}&`;
      break;
    }
    case "type": {
      sortOption = `sortType=${filter?.order === "asc" ? 1 : 2}&`;
      break;
    }
    case "lastUpdate": {
      sortOption = `sortLastUpdate=${filter?.order === "asc" ? 1 : 2}&`;
      break;
    }
    default: {
      break;
    }
  }

  const pageParam = `pageNumber=${filter.pageNumber ?? 1}&`;
  const sizeParam = `pageSize=${filter.pageSize ?? 5}`;

  const queryString = `${nameParam}${typeParam}${sortOption}${pageParam}${sizeParam}`;
  return queryString;
}
