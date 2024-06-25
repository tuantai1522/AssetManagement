import { Order } from "../components/table/sortTable";

export interface FilterAssetResponse {
  id: string;
  assetCode: string;
  assetName?: string;
  categoryName?: string;
  state?: string;
}

export interface FilterAssetRequest {
  name?: string;
  states?: string[];
  categoryIds?: string[];
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

  const nameParam = filter.name ? `name=${filter.name}&` : "";
  let statesParam = "";
  if (filter.states && filter.states.length > 0) {
    statesParam = filter.states.map((state) => `states=${state}&`).join("");
  }
  let categoryIdsParam = "";
  if (filter.categoryIds && filter.categoryIds.length > 0) {
    statesParam = filter.categoryIds
      .map((categoryId) => `categoryIds=${categoryId}&`)
      .join("");
  }
  const sortAssetCodeParam = filter.sortAssetCode
    ? `sortAssetCode=${filter.sortAssetCode === "asc" ? 1 : 2}&`
    : "";
  const sortAssetNameParam = filter.sortAssetName
    ? `sortAssetName=${filter.sortAssetName === "asc" ? 1 : 2}&`
    : "";
  const sortCategoryNameParam = filter.sortCategoryName
    ? `sortCategoryName=${filter.sortCategoryName === "asc" ? 1 : 2}&`
    : "";
  const sortStateParam = filter.sortState
    ? `sortState=${filter.sortState === "asc" ? 1 : 2}&`
    : "";
    const sortLastUpdateParam = filter.sortLastUpdate
    ? `sortLastUpdate=${filter.sortLastUpdate === "asc" ? 1 : 2}&`
    : "";
  const pageParam = `pageNumber=${filter.pageNumber ?? 1}&`;
  const sizeParam = `pageSize=${filter.pageSize ?? 5}`;

  const queryString = `${nameParam}${statesParam}${categoryIdsParam}${sortAssetCodeParam}${sortAssetNameParam}${sortCategoryNameParam}${sortStateParam}${sortLastUpdateParam}${pageParam}${sizeParam}`;
  console.log(`queryString: ${queryString}`);
  return queryString;
}
