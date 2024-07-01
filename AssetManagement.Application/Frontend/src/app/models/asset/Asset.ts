import { Order } from "../../components/table/sortTable";

export interface Asset {
  id: string;
  assetCode: string;
  name: string;
  categoryName: string;
  specification: string;
  installedDate: Date;
  state: string;
  location: string;
  createdAt: Date;
  lastUpdated: Date;
}

export interface FilterAssetResponse {
  id: string;
  assetCode: string;
  name?: string;
  category?: string;
  state?: AssetState;
}

export interface FilterAssetRequest {
  search?: string;
  states?: AssetState[];
  categories?: string[];
  pageNumber?: number;
  pageSize?: number;
  order?: Order;
  orderBy?: OrderByFieldName;
}

export enum AssetState {
  "Available" = 1,
  "Not available" = 2,
  "Waiting for recycling" = 3,
  "Recycled" = 4,
  "Assigned" = 5,
}

export type OrderByFieldName =
  | "assetCode"
  | "name"
  | "category"
  | "state"
  | "lastUpdate";

export function getAssetQueryString(filter?: FilterAssetRequest) {
  if (!filter) {
    return "";
  }

  let sortOption: string = "";
  let statesParam = "";
  let categoriesParam = "";

  const searchParam = filter.search ? `search=${filter.search}&` : "";

  if (filter.states && filter.states.length > 0) {
    statesParam = filter.states.map((state) => `states=${state}&`).join("");
  }

  if (filter.categories && filter.categories.length > 0) {
    categoriesParam = filter.categories
      .map((category) => `categories=${category}&`)
      .join("");
  }
  switch (filter?.orderBy) {
    case "assetCode": {
      sortOption = `sortAssetCode=${filter?.order === "asc" ? 1 : 2}&`;
      break;
    }
    case "name": {
      sortOption = `sortAssetName=${filter?.order === "asc" ? 1 : 2}&`;
      break;
    }
    case "category": {
      sortOption = `sortCategory=${filter?.order === "asc" ? 1 : 2}&`;
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

  const queryString = `${searchParam}${statesParam}${categoriesParam}${sortOption}${pageParam}${sizeParam}`;
  return queryString;
}
