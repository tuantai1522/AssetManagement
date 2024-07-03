import {  Radio } from "@mui/material";
import { AssetState, FilterAssetResponse } from "../../../app/models/asset/Asset";
import UserAssignmentTable, { ColumnDefinition, Order } from "../../../app/components/table/AssetAssignmentTable";
import { FilterUser } from "../../../app/models/user/User";



export interface UserListProp {
  data: FilterUser[];
  isLoading: boolean;
  error: any;
  order: Order;
  setOrder: (order: Order) => void;
  orderBy: any;
  setOrderBy: (orderBy: any) => void;
  selectedValue: FilterUser | undefined;
  handleClick: (value:any) => void;
}


export default function UserListInAssignment(props: UserListProp) {
  const columns: ColumnDefinition[] = [
    {
      id: "action",
      fieldName: "action",
      disablePadding: false,
      label: "",
      style: {
        width: "24px",
      },
      disableSort: true,
      renderCell: (params) => (
        <div>
          <button
            color="primary"
            className="text-red-500"
            onClick={(e) => {
              e.stopPropagation();
              props.handleClick(params)
            }}
          >
            <Radio
              checked = {params.id === props.selectedValue?.id}
              sx={{
                "&.MuiRadio-root": {
                  padding: "0px"
                },
                "&.Mui-checked": {
                  color: "#cf2338",
                },
              }}
            />
          </button>
        </div>
      ),
    },
    {
      id: "staffCode",
      fieldName: "staffCode",
      disablePadding: true,
      label: "Staff Code",
      className: "font-bold",
      rowRatio: "w-1/12",
      minWidth: "120px",
    },
    {
      id: "fullName",
      fieldName: "fullName",
      disablePadding: false,
      label: "Full Name",
      className: "font-bold",
      minWidth: "300px",
      rowRatio: "w-6/12",
    },
    {
      id: "type",
      fieldName: "types",
      disablePadding: false,
      label: "Type",
      className: "font-bold ",
      minWidth: "150px",
      rowRatio: "w-2/12",
    },
  ];

  return (
    <div className="min-h-60">
      <UserAssignmentTable<FilterUser>
        order={props.order}
        setOrder={props.setOrder}
        orderByFieldName={props.orderBy}
        setOrderByFieldName={props.setOrderBy}
        columns={columns}
        rows={props.data}
        handleClick={(event, data) => {
            props.handleClick(data.data);
        }}
        isLoading={props.isLoading}
      />
    </div>
  );
}
