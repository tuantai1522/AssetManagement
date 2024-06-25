import { Edit, HighlightOff } from "@mui/icons-material";
import AppTable, { ColumnDefinition, Order } from "../../app/components/table/sortTable";
import { IconButton, Stack, Tooltip } from "@mui/material";

export interface AssetRowData {
    id: string;
    assetCode: string;
    assetName?: string;
    categoryName?: string;
    state?: string;
    action: {
        id: string;
        state?: string;
    }
}

export interface AssetListProp {
    data: AssetRowData[];
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
            rowRatio: "w-6/12",
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
            fieldName: "action",
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
                        <Tooltip title="Edit">
                            <span>
                                <IconButton
                                    disabled={params?.state === "Assigned"}
                                    onClick={(e) => {
                                        e.stopPropagation()
                                        alert(params?.id)
                                    }}>
                                    <Edit className={params?.state === "Assigned" ? "" : "text-gray-500"} />
                                </IconButton>
                            </span>
                        </Tooltip>
                        <Tooltip title="Remove">
                            <span>
                                <IconButton
                                    disabled={params?.state === "Assigned"}
                                    onClick={(e) => {
                                        e.stopPropagation()
                                        alert(params?.id)
                                    }}>
                                    <HighlightOff className={params?.state === "Assigned" ? "" : "text-red-500"} />
                                </IconButton>
                            </span>
                        </Tooltip>
                    </Stack>
                )
            }
        },
    ];

    return (
        <div className="min-h-60">
            <AppTable<AssetRowData>
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
