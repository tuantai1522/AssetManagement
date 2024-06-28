import { Order } from "../../components/table/sortTable";

export interface Asset {
    id: string,
    assetCode: string,
    name: string,
    categoryName: string, 
    specification: string,
    installedDate: Date,
    state: string,
    location: string,
    createdAt: Date,
    lastUpdated: Date
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
  sortAssetCode?: Order;
  sortAssetName?: Order;
  sortCategoryName?: Order;
  sortState?: Order;
  sortLastUpdate?: Order;
  pageNumber?: number;
  pageSize?: number;
}

export function getAssetQueryString(filter?: FilterAssetRequest) {
  if (!filter) {
    return "";
  }

  const searchParam = filter.search ? `search=${filter.search}&` : "";
  let statesParam = "";
  if (filter.states && filter.states.length > 0) {
      statesParam = filter.states.map((state) => `states=${state}&`).join("");
  }
  let categoriesParam = "";
  if (filter.categories && filter.categories.length > 0) {
    statesParam = filter.categories
      .map((category) => `categories=${category}&`)
      .join("");
  }
  const sortAssetCodeParam = filter.sortAssetCode
    ? `sortAssetCode=${filter.sortAssetCode === "asc" ? 1 : 2}&`
    : "";
  const sortAssetNameParam = filter.sortAssetName
    ? `sortAssetName=${filter.sortAssetName === "asc" ? 1 : 2}&`
    : "";
  const sortCategoryNameParam = filter.sortCategoryName
    ? `sortCategory=${filter.sortCategoryName === "asc" ? 1 : 2}&`
    : "";
  const sortStateParam = filter.sortState
    ? `sortState=${filter.sortState === "asc" ? 1 : 2}&`
    : "";
  const sortLastUpdateParam = filter.sortLastUpdate
    ? `sortLastUpdate=${filter.sortLastUpdate === "asc" ? 1 : 2}&`
    : "";
  const pageParam = `pageNumber=${filter.pageNumber ?? 1}&`;
  const sizeParam = `pageSize=${filter.pageSize ?? 5}`;

  const queryString = `${searchParam}${statesParam}${categoriesParam}${sortAssetCodeParam}${sortAssetNameParam}${sortCategoryNameParam}${sortStateParam}${sortLastUpdateParam}${pageParam}${sizeParam}`;
  // console.log(`queryString: ${queryString}`);
  return queryString;
}

export enum AssetState {
  "Available" = 1,
  "Not Available" = 2,
  "Waiting For Recycling" = 3,
  "Recycled" = 4,
  "Assigned" = 5,
}
