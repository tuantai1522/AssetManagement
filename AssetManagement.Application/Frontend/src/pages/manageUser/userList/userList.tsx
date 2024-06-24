import { Dispatch, SetStateAction, useState } from "react";
import AppTable, {
  ColumnDefinition,
  Order,
} from "../../../app/components/table/sortTable";
import { FilterUser } from "../../../app/models/User";
import { Button } from "@mui/material";
import HighlightOffIcon from "@mui/icons-material/HighlightOff";
import EditIcon from '@mui/icons-material/Edit';
import { useLocation, useNavigate } from "react-router-dom";
export interface UserListProp {
  data: FilterUser[];
  isLoading: boolean;
  error: any;
  order: Order;
  setOrder: (order: Order) => void;
  orderBy: any;
  setOrderBy: (orderBy: any) => void;
  handleClick: (event: any, rowId: string) => void;
  setIsOpenDisablingModal: Dispatch<SetStateAction<boolean>>;
  setCurrentDisablingId: Dispatch<SetStateAction<string>>;

}

const rows: FilterUser[] = [];

export default function UserList(props: UserListProp) {
  const navigate = useNavigate();
  const location = useLocation();

  const columns: ColumnDefinition[] = [
    {
      id: 'staffCode',
        fieldName: "staffCode",
        disablePadding: true,
        label: 'Staff Code',
        className: "font-bold",
        rowRatio: "w-1/12",
        style: {
            border: "none",
            borderBottom: "none",
            minWidth: "100px"
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
          borderBottom: "none",
          minWidth: "250px"
      },

      rowRatio: "w-4/12",
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
      id: "joinedDate",
      fieldName: "joinedDate",
      disablePadding: false,
      label: 'Joined Date',
      className: "font-bold ",
      style: {
        border: "none",
        borderBottom: "none",
        minWidth: "120px",
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
          minWidth: "80px",
      },
      rowRatio: "w-2/12",
    },
    {
      id: "disable",
      fieldName: "id",
      disablePadding: false,
      label: "",
      className: "font-bold",
      bodyStyle: {
        borderBottom: "none",
      },
      rowRatio: "w-1/12",
      renderCell: (params) => (
        <div className="ml-5 flex w-fit justify-end">
          <button
            color="primary"
            className="text-gray-500"
            onClick={(e) => {
              e.stopPropagation();
              const callbackUrl = location.pathname;
              navigate(`/manage-user/edit-user/${params}?callbackUrl=${encodeURIComponent(callbackUrl)}`);
            }}
          >
            {" "}
            <EditIcon />
          </button>
          <button
            color="primary"
            className="text-red-500"
            onClick={(e) => {
              e.stopPropagation();
              props.setCurrentDisablingId(params);
              props.setIsOpenDisablingModal(true);
            }}
          >
            {" "}
            <HighlightOffIcon />
          </button>
        </div>
      ),
    },
  ];
  

  return (
    <div className="min-h-60">
      <AppTable<FilterUser>
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
