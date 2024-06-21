import { Dispatch, SetStateAction, useState } from "react";
import AppTable, {
  ColumnDefinition,
  Order,
} from "../../../app/components/table/sortTable";
import { FilterUser } from "../../../app/models/User";
import HighlightOffIcon from "@mui/icons-material/HighlightOff";
import EditIcon from '@mui/icons-material/Edit';
import agent from "../../../app/api/agent";
import ConfirmModal from "../../../app/components/confirmModal";
export interface UserListProp {
  data: FilterUser[];
  isLoading: boolean;
  error: any;
  setIsOpenDisablingModal: Dispatch<SetStateAction<boolean>>;
  setCurrentDisablingId: Dispatch<SetStateAction<string>>;
  // setData: (data: FilterUser[]) => void
}

export default function UserList(props: UserListProp) {
  const columns: ColumnDefinition[] = [
    {
      id: "staffCode",
      fieldName: "staffCode",
      disablePadding: true,
      label: "Staff Code",
      className: "font-bold",
      rowRatio: "w-3/12",
      style: {
        border: "none",
        borderBottom: "none",
      },
    },
    {
      id: "fullName",
      fieldName: "fullName",
      disablePadding: false,
      label: "Full Name",
      className: "font-bold",
      style: {
        border: "none",
        borderBottom: "none",
      },
  
      rowRatio: "w-2/12",
      renderCell: (params) => (
        <button
          color="primary"
          className="active:bg-black"
          onClick={(e) => {
            e.stopPropagation();
            alert("child");
          }}
        >
          {" "}
          Test
        </button>
      ),
    },
    {
      id: "username",
      fieldName: "username",
      disablePadding: false,
      label: "Username",
      className: "font-bold ",
      style: {
        border: "none",
        borderBottom: "none",
      },
      rowRatio: "w-2/12",
      disableSort: true,
    },
    {
      id: "joinedDate",
      fieldName: "joinedDate",
      disablePadding: false,
      label: "Joined Date",
      className: "font-bold ",
      style: {
        border: "none",
        borderBottom: "none",
      },
      rowRatio: "w-2/12",
    },
    {
      id: "type",
      fieldName: "types",
      disablePadding: false,
      label: "Type",
      className: "font-bold ",
      style: {
        border: "none",
        borderBottom: "none",
        minWidth: "100px",
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
        width: "1rem",
        borderBottom: "none",
      },
      rowRatio: "w-2/12",
      renderCell: (params) => (
        <div className="flex">
          <button
            color="primary"
            className="text-gray-500"
            onClick={(e) => {
              e.stopPropagation();
              alert("Edit");
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
  
  const rows: FilterUser[] = [];

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
        handleClick={() => {
          alert("Test");
        }}
      />
    </>
  );
}
