import { ColumnDefinition } from "../../../app/components/table/sortTable";

// export interface 

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
        fieldName: 'type',
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