import { useState } from "react";
import AppTable, { ColumnDefinition, Order } from "../../../app/components/table/sortTable";
import { FilterUser } from "../../../app/models/User";
import agent from "../../../app/api/agent";
import { Chip } from "@mui/material";

export interface UserListProp {
    data: FilterUser[],
    isLoading: boolean,
    error: any,
    // setData: (data: FilterUser[]) => void
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
        renderCell: <Chip color="primary" label="Test" />

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

    // const [users, setUsers] = useState<FilterUser[]>([]);

    const [order, setOrder] = useState<Order>("desc");
    const [orderBy, setOrderBy] = useState<string>("joinedDate");


    return (
        <>
            <AppTable<FilterUser>
                order={order}
                setOrder={setOrder}
                orderByFieldName={orderBy}
                setOrderByFieldName={setOrderBy}
                columns={columns}
                rows={props.data}
                handleClick={() => { }}
            />
        </>
    );
}