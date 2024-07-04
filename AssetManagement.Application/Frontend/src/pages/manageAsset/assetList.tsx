import { Edit, HighlightOff } from "@mui/icons-material";
import AppTable, {
  ColumnDefinition,
  Order,
} from "../../app/components/table/sortTable";
import { AssetState } from "../../app/models/asset/Asset";
import { useNavigate } from "react-router-dom";
import { Dispatch, SetStateAction } from "react";

export interface AssetRowData {
  id: string;
  assetCode: string;
  name?: string;
  category?: string;
  state?: string;
  specification?: string;
  installedDate?: Date;
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
  handleClick: (event: any, rowId: string) => void;

  setIsOpenDeletingModal: Dispatch<SetStateAction<boolean>>;
  setCurrentDeletingId: Dispatch<SetStateAction<string>>;
}

export default function AssetList(props: AssetListProp) {
  const navigate = useNavigate();

  const columns: ColumnDefinition[] = [
    {
      id: "assetCode",
      fieldName: "assetCode",
      disablePadding: true,
      label: "Asset Code",
      className: "font-bold",
      rowRatio: "w-1/12",
      minWidth: "120px",
      style: {
        border: "none",
        borderBottom: "none",
      },
    },
    {
      id: "name",
      fieldName: "name",
      disablePadding: false,
      label: "Asset Name",
      className: "font-bold",
      minWidth: "300px",
      style: {
        border: "none",
        borderBottom: "none",
      },
      rowRatio: "w-6/12",
    },
    {
      id: "category",
      fieldName: "category",
      disablePadding: false,
      label: "Category",
      className: "font-bold ",
      minWidth: "150px",
      style: {
        border: "none",
        borderBottom: "none",
      },
      rowRatio: "w-2/12",
    },
    {
      id: "state",
      fieldName: "state",
      disablePadding: false,
      label: "State",
      className: "font-bold ",
      minWidth: "150px",
      style: {
        border: "none",
        borderBottom: "none",
      },
      rowRatio: "w-2/12",
    },
    {
      id: "action",
      fieldName: "action",
      disablePadding: false,
      label: "",
      className: "font-bold",
      rowRatio: "w-1/12",
      minWidth: "40px",
      style: {
        border: "none",
        borderBottom: "none",
        maxWidth: "120px",
      },
      disableSort: true,
      renderCell: (params) => (
        <div className="flex w-fit justify-end items-center">
          <button
            disabled={
              AssetState.Available !==
              AssetState[params?.state as keyof typeof AssetState]
            }
            color="primary"
            className={`text-gray-500 ${
              AssetState.Available !==
              AssetState[params?.state as keyof typeof AssetState]
                ? "opacity-50 cursor-not-allowed"
                : ""
            }`}
            onClick={(e) => {
              e.stopPropagation();
              const data = {
                assetId: params?.id,
                assetName: params?.name,
                installedDate: params?.installedDate,
                specification: params?.specification,
                state: params?.state,
                categoryName: params?.category,
              };

              navigate("/manage-asset/edit-asset", {
                state: { assetToUpdate: data },
              });
            }}
          >
            <Edit />
          </button>

          <button
            disabled={
              AssetState.Assigned ===
              AssetState[params?.state as keyof typeof AssetState]
            }
            color="primary"
            className={`text-red-500 ${
              AssetState.Assigned ===
              AssetState[params?.state as keyof typeof AssetState]
                ? "opacity-50 cursor-not-allowed"
                : ""
            }`}
            onClick={(e) => {
              e.stopPropagation();
              props.setCurrentDeletingId(params?.id);
              props.setIsOpenDeletingModal(true);
            }}
          >
            <HighlightOff />
          </button>
        </div>
      ),
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
