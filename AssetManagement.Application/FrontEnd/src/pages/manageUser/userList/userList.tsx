import { useState } from "react";
import AppTable, { ColumnDefinition, Order } from "../../../app/components/table/sortTable";
import { FilterUser } from "../../../app/models/User";
import { Button } from "@mui/material";
export interface UserListProp {
    data: FilterUser[],
    isLoading: boolean,
    error: any,
    order: Order,
    setOrder: (order: Order) => void,
    orderBy: any,
    setOrderBy: (orderBy: any) => void,
}

const columns: ColumnDefinition[] = [
    {
        id: 'staffCode',
        fieldName: "staffCode",
        disablePadding: true,
        label: 'Staff Code',
        className: "font-bold",
        rowRatio: "w-3/12",
        style: {
            border: "none",
            borderBottom: "none"
        }
    },
    {
        id: 'fullName',
        fieldName: 'fullName',
        disablePadding: false,
        label: 'Full Name',
        className: "font-bold",
        style: {
            border: "none",
            borderBottom: "none"
        },

        rowRatio: "w-2/12",
        // renderCell: <button color="primary" className="active:bg-black" onClick={e => {
        //     e.stopPropagation();
        //     alert("child");
        // }
        // } > Test</button>

    },
    {
        id: 'username',
        fieldName: 'username',
        disablePadding: false,
        label: 'Username',
        className: "font-bold ",
        style: {
            border: "none",
            borderBottom: "none"
        },
        rowRatio: "w-2/12",
        disableSort: true,
    },
    {
        id: 'joinedDate',
        fieldName: 'joinedDate',
        disablePadding: false,
        label: 'Joined Date',
        className: "font-bold ",
        style: {
            border: "none",
            borderBottom: "none"
        },
        rowRatio: "w-2/12",
    },
    {
        id: 'type',
        fieldName: 'types',
        disablePadding: false,
        label: 'Type',
        className: "font-bold ",
        style: {
            border: "none",
            borderBottom: "none",
            minWidth: "100px",
        },
        rowRatio: "w-2/12",
    },

];

const rows: FilterUser[] = []

export default function UserList(props: UserListProp) {

    // const [order, setOrder] = useState<Order>("desc");
    // const [orderBy, setOrderBy] = useState<string>("joinedDate");

    return (
        <>
            <AppTable<FilterUser>
                order={props.order}
                setOrder={props.setOrder}
                orderByFieldName={props.orderBy}
                setOrderByFieldName={props.setOrderBy}
                columns={columns}
                rows={props.data}
                handleClick={() => { }}
            />
        </>
    );
}