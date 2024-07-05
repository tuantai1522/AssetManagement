import { Order } from "../../components/table/sortTable";
import { AssignmentStateEnum } from "../../types/enum";

export type OrderByFieldNameMyAssignment = "assetCode" | "name" | "category" | "assignedDate" | "state" | "lastUpdate";
  
export interface MyAssignmentDetailResponse {
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

export interface FilterMyAssignmentRequest {
    pageNumber?: number;
    pageSize?: number;
    order?: Order;
    orderBy?: OrderByFieldNameMyAssignment;
}

export interface FilterMyAssignmentResponse {
    id: string;
    assetCode: string;
    name?: string;
    category?: string;
    assignedDate: Date;
    state?: AssignmentStateEnum;
}

export function getMyAssignmentQueryString(filter?: FilterMyAssignmentRequest) {
    if (!filter) {
        return "";
    }
    
    let sortOption: string = "";
    
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
        case "assignedDate": {
        sortOption = `sortAssignedDate=${filter?.order === "asc" ? 1 : 2}&`;
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
    
    const queryString = `${sortOption}${pageParam}${sizeParam}`;
    return queryString;
    }
