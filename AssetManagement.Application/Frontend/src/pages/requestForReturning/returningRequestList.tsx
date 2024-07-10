import CloseIcon from "@mui/icons-material/Close";
import CheckIcon from "@mui/icons-material/Check";
import AppTable, {
  ColumnDefinition,
  Order,
} from "../../app/components/table/sortTable";
import { ReturningRequestStateEnum } from "../../app/types/enum";
import ConfirmModal from "../../app/components/confirmModal";
import { useState } from "react";
import agent from "../../app/api/agent";

export interface ReturningRequestRowData {
  id: string;
  assetCode?: string;
  assetName?: string;
  requestedBy?: string;
  state?: string;
  assignedDate?: string;
  acceptedBy?: string;
  returnedDate?: string;
  action: {
    id: string;
    state?: string;
  };
}

export interface Props {
  data: ReturningRequestRowData[];
  isLoading: boolean;
  error: any;
  order: Order;
  setOrder: (order: Order) => void;
  orderBy: any;
  setOrderBy: (orderBy: any) => void;
  handleClick: (event: any, rowId: string) => void;
  refetchData: () => void;
}

const ReturningRequestList = (props: Props) => {
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
      id: "requestedBy",
      fieldName: "requestedBy",
      disablePadding: false,
      label: "Requested by",
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
      id: "acceptedBy",
      fieldName: "acceptedBy",
      disablePadding: false,
      label: "Accepted by",
      className: "font-bold ",
      minWidth: "130px",
      style: {
        border: "none",
        borderBottom: "none",
      },
      rowRatio: "w-1/12",
    },
    {
      id: "returnedDate",
      fieldName: "returnedDate",
      disablePadding: false,
      label: "Returned date",
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
          ReturningRequestStateEnum[
            ReturningRequestStateEnum["Waiting for returning"]
          ];
        return (
          <div className="flex w-fit justify-end items-center gap-2">
            <button
              disabled={isDisable}
              color="primary"
              className={`text-red-600 ${isDisable ? "opacity-40" : ""}`}
              onClick={(e) => {
                e.stopPropagation();
                setCurrentRequestId(params?.id);
                setCompleteResponseStates({
                  ...completeResponseStates,
                  isModalOpen: true,
                });
              }}
            >
              <CheckIcon
                sx={{
                  stroke: "currentColor",
                  strokeWidth: 1,
                }}
              />
            </button>
            <button
              disabled={isDisable}
              color="primary"
              className={`text-black ${isDisable ? "opacity-40" : ""}`}
              onClick={(e) => {
                e.stopPropagation();
                setCurrentRequestId(params?.id);
                setIsModalCancelOpen(true);
              }}
            >
              <CloseIcon
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

  const [currentRequestId, setCurrentRequestId] = useState("");
  const [completeResponseStates, setCompleteResponseStates] = useState({
    isModalOpen: false,
    modalMessage: "Do you want to mark this returning request as 'Completed'?",
    confirmMessage: "Yes",
    cancelMessage: "No",
  });

  const [isModalCancelOpen, setIsModalCancelOpen] = useState<boolean>(false);

  const onCompleteResponse = async () => {
    await agent.ReturningRequest.complete(currentRequestId).finally(() => {
      props.refetchData();
    });
  };

  const onCancelResponse = async () => {
    await agent.ReturningRequest.cancel(currentRequestId)
      .finally(() => {
        props.refetchData();
      });
  };


  return (
    <>
      <div className="min-h-60">
        <AppTable<ReturningRequestRowData>
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
          message={completeResponseStates.modalMessage}
          isOpen={completeResponseStates.isModalOpen}
          confirmMessage={completeResponseStates.confirmMessage}
          cancelMessage={completeResponseStates.cancelMessage}
          onClose={() =>
            setCompleteResponseStates({
              ...completeResponseStates,
              isModalOpen: false,
            })
          }
          onConfirm={() => {
            setCompleteResponseStates({
              ...completeResponseStates,
              isModalOpen: false,
            });
            onCompleteResponse();
          }}
        />
        <ConfirmModal
          message="Do you want to cancel this returning request"
          isOpen={isModalCancelOpen}
          confirmMessage="Yes"
          cancelMessage="No"
          onClose={() =>
            setIsModalCancelOpen(false)
          }
          onConfirm={() => {
            setIsModalCancelOpen(false)
            onCancelResponse();
          }}
        />
      </div>
    </>
  );
};

export default ReturningRequestList;
