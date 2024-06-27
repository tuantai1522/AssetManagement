import { Edit, HighlightOff } from "@mui/icons-material";
import AppTable, { ColumnDefinition, Order } from "../../app/components/table/sortTable";
import { IconButton, Stack, Tooltip } from "@mui/material";

export interface AssetRowData {
    id: string;
    assetCode: string;
    name?: string;
    category?: string;
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
            minWidth: "100px",
            style: {
                border: "none",
                borderBottom: "none",
            }
        },
        {
            id: 'name',
            fieldName: 'name',
            disablePadding: false,
            label: 'Asset Name',
            className: "font-bold",
            minWidth: "300px",
            style: {
                border: "none",
                borderBottom: "none",
            },
            rowRatio: "w-6/12",
        },
        {
            id: 'category',
            fieldName: 'category',
            disablePadding: false,
            label: 'Category',
            className: "font-bold ",
            minWidth: "150px",
            style: {
                border: "none",
                borderBottom: "none",
            },
            rowRatio: "w-2/12"
        },
        {
            id: "state",
            fieldName: "state",
            disablePadding: false,
            label: 'State',
            className: "font-bold ",
            minWidth: "150px",
            style: {
                border: "none",
                borderBottom: "none",
            },
            rowRatio: "w-2/12",
        },
        {
            id: 'action',
            fieldName: "action",
            disablePadding: false,
            label: '',
            className: "font-bold",
            rowRatio: "w-1/12",
            minWidth: "100px",
            style: {
                border: "none",
                borderBottom: "none",
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
                            disabled={params?.state === "Assigned"}
                            color="primary"
                            className="text-gray-500"
                            onClick={(e) => {
                                e.stopPropagation()
                                alert(params?.id)
                            }}
                        >
                            {" "}
                            <Edit />
                        </button>

                        <button
                            disabled={params?.state === "Assigned"}
                            color="primary"
                            className="text-red-500"
                            onClick={(e) => {
                                e.stopPropagation();
                                alert(params?.id)
                            }}
                        >
                            {" "}
                            <HighlightOff />
                        </button>
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
                isLoading={props.isLoading}
            />
        </div>
    );
}
