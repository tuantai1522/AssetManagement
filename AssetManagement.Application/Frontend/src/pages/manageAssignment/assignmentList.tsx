import { Edit, HighlightOff, Replay } from "@mui/icons-material";
import AppTable, {
  ColumnDefinition,
  Order,
} from "../../app/components/table/sortTable";
import { IconButton, Stack } from "@mui/material";
import { AssetState } from "../../app/models/asset/Asset";
import { AssignmentStateEnum } from "../../app/types/enum";
import { useState } from "react";
import ConfirmModal from "../../app/components/confirmModal";
import agent from "../../app/api/agent";

export interface AssignmentRowData {
  id: string;
  assetCode?: string;
  assetName?: string;
  assignedTo?: string;
  assignedBy?: string;
  state?: string;
  assignedDate?: string;
  action: {
    id: string;
    state?: string;
  };
}

export interface AssignmentListProp {
  data: AssignmentRowData[];
  isLoading: boolean;
  error: any;
  order: Order;
  setOrder: (order: Order) => void;
  orderBy: any;
  setOrderBy: (orderBy: any) => void;
  handleClick: (event: any, rowId: string) => void;
  refetchData: () => void;
}

export default function AssignmentList(props: AssignmentListProp) {
  const [currentAssignmentId, setCurrentAssignmentId] = useState("");
  const [responseStates, setResponseStates] = useState({
    isOpenReturnModal: false,
    returnModalMessage:
      "Do you want to create a returning request for this asset?",
    confirmReturnButtonMessage: "Yes",
  });

  const onConfirmReturn = async () => {
    try {
      if (!currentAssignmentId) return;
      await agent.RequestReturn.adminCreateRequest(currentAssignmentId);
      setResponseStates({ ...responseStates, isOpenReturnModal: false });
      props.refetchData();
    } catch (error) {
      console.log("Error when confirm return: ", error);
    }
  };

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
      id: "assetName",
      fieldName: "assetName",
      disablePadding: false,
      label: "Asset Name",
      className: "font-bold",
      minWidth: "220px",
      style: {
        border: "none",
        borderBottom: "none",
      },
      rowRatio: "w-4/12",
    },
    {
      id: "assignedTo",
      fieldName: "assignedTo",
      disablePadding: false,
      label: "Assigned to",
      className: "font-bold ",
      minWidth: "130px",
      style: {
        border: "none",
        borderBottom: "none",
      },
      rowRatio: "w-1/12",
    },
    {
      id: "assignedBy",
      fieldName: "assignedBy",
      disablePadding: false,
      label: "Assigned by",
      className: "font-bold ",
      minWidth: "130px",
      style: {
        border: "none",
        borderBottom: "none",
      },
      rowRatio: "w-1/12",
    },
    {
      id: "assignedDate",
      fieldName: "assignedDate",
      disablePadding: false,
      label: "Assigned date",
      className: "font-bold ",
      minWidth: "130px",
      style: {
        border: "none",
        borderBottom: "none",
      },
      rowRatio: "w-1/12",
    },
    {
      id: "state",
      fieldName: "state",
      disablePadding: false,
      label: "State",
      className: "font-bold ",
      minWidth: "180px",
      style: {
        border: "none",
        borderBottom: "none",
      },
      rowRatio: "w-3/12",
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
      },
      disableSort: true,
      renderCell: (params) => {
        const isDisable =
          params?.state !==
          AssignmentStateEnum[AssignmentStateEnum["Waiting for acceptance"]];
        return (
          <div className="flex w-fit justify-end items-center">
            <button
              disabled={isDisable}
              color="primary"
              className={isDisable ? "text-gray-300" : "text-gray-500"}
              onClick={(e) => {
                e.stopPropagation();
                alert(params?.id);
              }}
            >
              <Edit />
            </button>
            <button
              disabled={isDisable}
              color="primary"
              className={isDisable ? "text-red-200" : "text-red-500"}
              onClick={(e) => {
                e.stopPropagation();
                alert(params?.id);
              }}
            >
              <HighlightOff />
            </button>
            <button
              className="text-blue-600"
              onClick={(e) => {
                e.stopPropagation();
                setCurrentAssignmentId(params?.id);
                setResponseStates({
                  ...responseStates,
                  isOpenReturnModal: true,
                });
              }}
            >
              <Replay color="primary" />
            </button>
          </div>
        );
      },
    },
  ];

  return (
    <>
      <div className="min-h-60">
        <AppTable<AssignmentRowData>
          order={props.order}
          setOrder={props.setOrder}
          orderByFieldName={props.orderBy}
          setOrderByFieldName={props.setOrderBy}
          columns={columns}
          rows={props.data}
          handleClick={props.handleClick}
          isLoading={props.isLoading}
          tableStyle={{ minWidth: 600 }}
        />
      </div>
      <div className="flex justify-center h-full">
        <ConfirmModal
          message={responseStates.returnModalMessage}
          isOpen={responseStates.isOpenReturnModal}
          confirmMessage={responseStates.confirmReturnButtonMessage}
          onClose={() =>
            setResponseStates({ ...responseStates, isOpenReturnModal: false })
          }
          onConfirm={() => {
            onConfirmReturn();
          }}
        />
      </div>
    </>
  );
}
