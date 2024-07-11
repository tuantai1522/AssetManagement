import ReplayIcon from "@mui/icons-material/Replay";
import CloseIcon from "@mui/icons-material/Close";
import CheckIcon from "@mui/icons-material/Check";
import AppTable, {
  ColumnDefinition,
  Order,
} from "../../app/components/table/sortTable";
import { AssignmentStateEnum } from "../../app/types/enum";
import { AssignmentRespondRequest } from "../../app/models/assignment/AssignmentRespondRequest";
import { useState } from "react";
import agent from "../../app/api/agent";
import ConfirmModal from "../../app/components/confirmModal";

export interface MyAssignmentRowData {
  id: string;
  assetCode: string;
  name: string;
  category: string;
  assignedDate: Date;
  state: AssignmentStateEnum;
  action: {
    id: string;
    state: AssignmentStateEnum;
  };
}

export interface MyAssignmentListProp {
  data: MyAssignmentRowData[];
  isLoading: boolean;
  error: any;
  order: Order;
  setOrder: (order: Order) => void;
  orderBy: any;
  setOrderBy: (orderBy: any) => void;
  handleClick: (event: any, rowId: string) => void;
  refetchData: () => void;
}

export default function MyAssignmentList(props: MyAssignmentListProp) {
  const columns: ColumnDefinition[] = [
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
      rowRatio: "w-4/12",
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
    {
      id: "assignedDate",
      fieldName: "assignedDate",
      disablePadding: false,
      label: "Assigned Date",
      className: "font-bold ",
      minWidth: "150px",
      rowRatio: "w-2/12",
    },
    {
      id: "state",
      fieldName: "state",
      disablePadding: false,
      label: "State",
      className: "font-bold ",
      minWidth: "150px",
      rowRatio: "w-2/12",
    },
    {
      id: "action",
      fieldName: "action",
      disablePadding: false,
      label: "",
      minWidth: "40px",
      disableSort: true,
      renderCell: (params) => {
        const isDisableReturning =
          params?.state !== AssignmentStateEnum.Accepted;
        return (
          <div className="flex justify-end gap-1">
            <button
              disabled={
                params?.state !== AssignmentStateEnum["Waiting for acceptance"]
              }
              className={`text-red-600 ${
                params?.state !== AssignmentStateEnum["Waiting for acceptance"]
                  ? "opacity-40"
                  : ""
              }`}
              onClick={(e) => {
                e.stopPropagation();
                setCurrentAssignmentId(params?.id);
                setResponseStates({
                  ...responseStates,
                  isAccepted: true,
                  respondModalMessage: "Do you want to accept this assignment?",
                  isRespondModalOpen: true,
                  confirmButtonMessage: "Accept",
                });
              }}
            >
              {" "}
              <CheckIcon
                sx={{
                  stroke: "currentColor", // Use the current color for stroke
                  strokeWidth: 1, // Adjust stroke width as needed
                }}
              />
            </button>

            <button
              disabled={
                params?.state !== AssignmentStateEnum["Waiting for acceptance"]
              }
              className={`text-black  ${
                params?.state !== AssignmentStateEnum["Waiting for acceptance"]
                  ? "opacity-40"
                  : ""
              }`}
              onClick={(e) => {
                e.stopPropagation();
                setCurrentAssignmentId(params?.id);
                setResponseStates({
                  ...responseStates,
                  isAccepted: false,
                  respondModalMessage:
                    "Do you want to decline this assignment?",
                  isRespondModalOpen: true,
                  confirmButtonMessage: "Decline",
                });
              }}
            >
              {" "}
              <CloseIcon
                sx={{
                  stroke: "currentColor", // Use the current color for stroke
                  strokeWidth: 1, // Adjust stroke width as needed
                }}
              />
            </button>

            <button
              disabled={isDisableReturning}
              className={`text-blue-500`}
              onClick={(e) => {
                e.stopPropagation();
                setCurrentAssignmentId(params?.id);
                setResponseStates({
                  ...responseStates,
                  isOpenReturnModal: true,
                });
              }}
            >
              {" "}
              <ReplayIcon
                color="primary"
                className={`${isDisableReturning && "opacity-50"}`}
                sx={{
                  stroke: "currentColor",
                  strokeWidth: 1,
                }}
              />
            </button>
          </div>
        );
      },
    },
  ];

  const [currentAssignmentId, setCurrentAssignmentId] = useState("");
  const [responseStates, setResponseStates] = useState({
    isRespondModalOpen: false,
    respondModalMessage: "",
    isAccepted: true,
    confirmButtonMessage: "Accept",
    isOpenReturnModal: false,
    returnModalMessage:
      "Do you want to create a returning request for this asset?",
    returnButton: "Yes",
  });

  const onConfirmResponse = async (isAccepted: boolean) => {
    const request: AssignmentRespondRequest = {
      isAccepted: isAccepted,
    };
    await agent.Assignment.respond(currentAssignmentId, request)
      .then(() => {})
      .catch((e: any) => {
        console.log(e);
      })
      .finally(() => {
        props.refetchData();
      });
  };

  const onConfirmReturn = async () => {
    try {
      if (!currentAssignmentId) return;
      await agent.ReturningRequest.userCreateRequest(currentAssignmentId);
      setResponseStates({ ...responseStates, isOpenReturnModal: false });
      props.refetchData();
    } catch (error) {
      console.log("Error when confirm return: ", error);
    }
  };

  return (
    <>
      <div className="min-h-60">
        <AppTable<MyAssignmentRowData>
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
      <div className="flex justify-center h-full">
        <ConfirmModal
          message={responseStates.respondModalMessage}
          isOpen={responseStates.isRespondModalOpen}
          confirmMessage={responseStates.confirmButtonMessage}
          onClose={() =>
            setResponseStates({ ...responseStates, isRespondModalOpen: false })
          }
          onConfirm={() => {
            setResponseStates({ ...responseStates, isRespondModalOpen: false });
            onConfirmResponse(responseStates.isAccepted);
          }}
        />
        <ConfirmModal
          isOpen={responseStates.isOpenReturnModal}
          message={responseStates.returnModalMessage}
          onClose={() =>
            setResponseStates({ ...responseStates, isOpenReturnModal: false })
          }
          confirmMessage="Yes"
          cancelMessage="No"
          onConfirm={onConfirmReturn}
        />
      </div>
    </>
  );
}
