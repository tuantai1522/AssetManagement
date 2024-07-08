import {  Radio } from "@mui/material";
import { AssetState, FilterAssetResponse } from "../../../app/models/asset/Asset";
import UserAssignmentTable, { ColumnDefinition, Order } from "../../../app/components/table/AssetAssignmentTable";

export interface AssetRowData {
  id: string;
  assetCode: string;
  name?: string;
  category?: string;
  state?: string;
  action: {
    id: string;
    state?: string;
  };
}

export interface AssetListProp {
  data: AssetRowData[];
  isLoading: boolean;
  error: any;
  order: Order;
  setOrder: (order: Order) => void;
  orderBy: any;
  setOrderBy: (orderBy: any) => void;
  selectedValue: FilterAssetResponse | undefined;
  handleClick: (value:any) => void;
}


export default function AssetListInAssignment(props: AssetListProp) {
  const handleKeyPress = (event: React.KeyboardEvent<HTMLButtonElement>) => {
    if (event.key === 'Enter') {
      event.preventDefault();
      event.stopPropagation();
    }
  };
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
            disabled={params?.state === AssetState.Assigned}
            color="primary"
            className="text-red-500"
            onClick={(e) => {
              e.stopPropagation();
              props.handleClick(params)
            }}
            onKeyDown={handleKeyPress}
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
      id: "assetCode",
      fieldName: "assetCode",
      disablePadding: true,
      label: "Asset Code",
      className: "font-bold",
      rowRatio: "w-1/12",
      minWidth: "120px",
    },
    {
      id: "name",
      fieldName: "name",
      disablePadding: false,
      label: "Asset Name",
      className: "font-bold",
      minWidth: "300px",
      rowRatio: "w-6/12",
    },
    {
      id: "category",
      fieldName: "category",
      disablePadding: false,
      label: "Category",
      className: "font-bold ",
      minWidth: "150px",
      rowRatio: "w-2/12",
    },
  ];

  return (
    <div className="min-h-60">
      <UserAssignmentTable<AssetRowData>
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
