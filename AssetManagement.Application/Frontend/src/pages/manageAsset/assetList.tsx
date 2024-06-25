import { Edit, HighlightOff } from "@mui/icons-material";
import AppButton from "../../app/components/buttons/Button";
import AppTable, { ColumnDefinition, Order } from "../../app/components/table/sortTable";
import { FilterAssetResponse } from "../../app/models/Asset";
import { Stack } from "@mui/material";

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
            rowRatio: "w-2/12"
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
        },
        {
            id: 'action',
            fieldName: "id",
            disablePadding: true,
            label: '',
            className: "font-bold",
            rowRatio: "w-1/12",
            style: {
                border: "none",
                borderBottom: "none",
                minWidth: "100px",
                maxWidth: "120px"
            },
            renderCell: (params) => {
                return (
                    <Stack
                        direction="row"
                        justifyContent="space-between"
                        alignItems="center"
                        spacing={2}
                    >
                        <button 
                        className="text-gray-500"
                        onClick={(e) => {
                            e.stopPropagation()
                            alert(params)
                        }}>
                            <Edit />
                        </button>
                        <button
                        className="text-red-500"
                        onClick={(e) => {
                            e.stopPropagation()
                            alert(params)
                        }}>
                            <HighlightOff />
                        </button>
                    </Stack>
                )
            }
        },
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
