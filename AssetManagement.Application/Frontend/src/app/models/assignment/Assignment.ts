import { Order } from "../../components/table/sortTable";
import { AssignmentStateEnum } from "../../types/enum";

export interface AssignmentDetailResponse {
  id: string;
  assetCode: string;
  assetName: string;
  specification: string;
  assignedTo: string;
  assignedBy: string;
  assignedDate: Date;
  state: AssignmentStateEnum;
  note: string;
}

export interface FilterAssignmentResponse {
  id: string;
  assetCode?: string;
  assetName?: string;
  assignedTo?: string;
  assignedBy?: string;
  state?: AssignmentStateEnum;
  assignedDate?: Date;
}

export type OrderByFieldName =
  | "assetCode"
  | "assetName"
  | "assignedTo"
  | "assignedBy"
  | "state"
  | "assignedDate"
  | "lastUpdate";

export interface FilterAssignmentRequest {
  search?: string;
  states?: AssignmentStateEnum[];
  assignedDate?: string;
  pageNumber?: number;
  pageSize?: number;
  order?: Order;
  orderBy?: OrderByFieldName;
}

export function getAssignmentQueryString(filter?: FilterAssignmentRequest) {
  if (!filter) {
    return "";
  }

  let sortOption: string = "";
  let statesParam = "";

  const searchParam = filter.search ? `search=${filter.search}&` : "";
  const assignedDateParam = filter.assignedDate
    ? `assignedDate=${filter.assignedDate}&`
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
    case "assignedTo": {
      sortOption = `sortAssignedTo=${filter?.order === "asc" ? 1 : 2}&`;
      break;
    }
    case "assignedBy": {
      sortOption = `sortAssignedBy=${filter?.order === "asc" ? 1 : 2}&`;
      break;
    }
    case "assignedDate": {
      sortOption = `sortAssignedDate=${filter?.order === "asc" ? 1 : 2}&`;
      break;
    }
    case "state": {
      sortOption = `sortState=${filter?.order === "asc" ? 1 : 2}&`;
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

  const queryString = `${searchParam}${statesParam}${assignedDateParam}${sortOption}${pageParam}${sizeParam}`;
  return queryString;
}
