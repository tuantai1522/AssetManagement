import { Order } from "../../components/table/sortTable";
import { ReturningRequestStateEnum } from "../../types/enum";

export interface FilterReturingRequestResponse {
  id: string;
  assetCode: string;
  assetName: string;
  requestedBy: string;
  state: ReturningRequestStateEnum;
  assignedDate: Date;
  acceptedBy: string;
  returnedDate: Date;
}

export type OrderByFieldName =
  | "assetCode"
  | "assetName"
  | "requestedBy"
  | "state"
  | "assignedDate"
  | "acceptedBy"
  | "returnedDate";

export interface FilterReturningRequestRequest {
  search?: string;
  states?: ReturningRequestStateEnum[];
  returnedDate?: string;
  pageNumber?: number;
  pageSize?: number;
  order?: Order;
  orderBy?: OrderByFieldName;
}

export function getReturningRequestQueryString(
  filter?: FilterReturningRequestRequest
) {
  if (!filter) {
    return "";
  }

  let sortOption: string = "";
  let statesParam = "";

  const searchParam = filter.search ? `search=${filter.search}&` : "";
  const returnedDateParam = filter.returnedDate
    ? `returnedDate=${filter.returnedDate}&`
    : "";

  if (filter.states && filter.states.length > 0) {
    statesParam = filter.states.map((state) => `states=${state}&`).join("");
  }

  switch (filter?.orderBy) {
    case "assetCode": {
      sortOption = `sortAssetCode=${filter?.order === "asc" ? 1 : 2}&`;
      break;
    }
    case "assetName": {
      sortOption = `sortAssetName=${filter?.order === "asc" ? 1 : 2}&`;
      break;
    }
    case "requestedBy": {
      sortOption = `sortRequestedBy=${filter?.order === "asc" ? 1 : 2}&`;
      break;
    }
    case "state": {
      sortOption = `sortState=${filter?.order === "asc" ? 1 : 2}&`;
      break;
    }
    case "assignedDate": {
      sortOption = `sortAssignedDate=${filter?.order === "asc" ? 1 : 2}&`;
      break;
    }
    case "acceptedBy": {
      sortOption = `sortAcceptedBy=${filter?.order === "asc" ? 1 : 2}&`;
      break;
    }
    case "returnedDate": {
      sortOption = `sortReturnedDate=${filter?.order === "asc" ? 1 : 2}&`;
      break;
    }
    default: {
      break;
    }
  }
  const pageParam = `pageNumber=${filter.pageNumber ?? 1}&`;
  const sizeParam = `pageSize=${filter.pageSize ?? 5}`;

  const queryString = `${searchParam}${statesParam}${returnedDateParam}${sortOption}${pageParam}${sizeParam}`;
  return queryString;
}
