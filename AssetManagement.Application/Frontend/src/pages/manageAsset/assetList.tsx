import AppTable, { ColumnDefinition, Order } from "../../app/components/table/sortTable";
import { FilterAssetResponse } from "../../app/models/Asset";

export interface AssetListProp {
    data: FilterAssetResponse[];
    isLoading: boolean;
    error: any;
    order: Order;
    setOrder: (order: Order) => void;
    orderBy: any;
    setOrderBy: (orderBy: any) => void;
    handleClick: (event: any, rowId: string) => void;
}

export default function AssetList(props: AssetListProp) {

    const columns: ColumnDefinition[] = [
        {
            id: 'assetCode',
            fieldName: "assetCode",
            disablePadding: true,
            label: 'Asset Code',
            className: "font-bold",
            rowRatio: "w-1/12",
            style: {
                border: "none",
                borderBottom: "none",
                minWidth: "100px"
            }
        },
        {
            id: 'assetName',
            fieldName: 'assetName',
            disablePadding: false,
            label: 'Asset Name',
            className: "font-bold",
            style: {
                border: "none",
                borderBottom: "none",
                minWidth: "300px"
            },
            rowRatio: "w-4/12",
        },
        {
            id: 'categoryName',
            fieldName: 'categoryName',
            disablePadding: false,
            label: 'Category',
            className: "font-bold ",
            style: {
                border: "none",
                borderBottom: "none",
                minWidth: "150px"
            },
            rowRatio: "w-2/12",
            disableSort: true,
        },
        {
            id: "state",
            fieldName: "state",
            disablePadding: false,
            label: 'State',
            className: "font-bold ",
            style: {
                border: "none",
                borderBottom: "none",
                minWidth: "150px",
            },
            rowRatio: "w-2/12",
        }
    ];

    return (
        <div className="min-h-60">
            <AppTable<FilterAssetResponse>
                order={props.order}
                setOrder={props.setOrder}
                orderByFieldName={props.orderBy}
                setOrderByFieldName={props.setOrderBy}
                columns={columns}
                rows={props.data}
                handleClick={props.handleClick}
            />
        </div>
    );
}
