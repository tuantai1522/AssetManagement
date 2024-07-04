import agent from "../../api/agent";
import { AssignmentDetailResponse, AssignmentState } from "../../models/assignment/Assignment";
import AppLoader from "../AppLoader";

interface Props {
  assignmentId: string;
  onClose: () => void;
}


const AssignmentInfo = ({ assignmentId, onClose }: Props) => {
  const { data, isLoading } = agent.Assignment.detail(assignmentId);

  const assignmentDetailData: AssignmentDetailResponse | null = data?.result;

  return (
    <>
      <div className="fixed w-screen h-screen bg-gray-400 top-0 left-0 opacity-50"></div>
        <div className="z-10 shadow-2xl absolute top-1/2 -translate-y-1/2 rounded-xl min-w-[35rem]">
          {assignmentDetailData ? (
            <div className="rounded-xl border-black border-2">
              <div className="bg-slate-200 rounded-t-xl border-b-2 border-black px-12 py-5 flex justify-between items-center">
                <h2 className="text-xl font-bold text-primary">
                  Detailed Assignment Information
                </h2>
                <div
                  id="assignment-info-x"
                  onClick={onClose}
                  className="rounded-md border-4 border-primary text-primary cursor-pointer transition-all hover:text-white hover:bg-primary"
                >
                  <svg
                    xmlns="http://www.w3.org/2000/svg"
                    fill="none"
                    viewBox="0 0 24 24"
                    strokeWidth="5"
                    stroke="currentColor"
                    className="size-4"
                  >
                    <path
                      strokeLinecap="round"
                      strokeLinejoin="round"
                      d="M6 18 18 6M6 6l12 12"
                    />
                  </svg>
                </div>
              </div>
              <div className="bg-slate-50 rounded-b-xl w-full h-full px-12 py-7">
                <div className="grid grid-cols-9 gap-4 text-gray-600">
                  <div className="col-span-3">Asset Code</div>
                  <div className="col-span-6">{assignmentDetailData.assetCode}</div>
                  <div className="col-span-3">Asset Name</div>
                  <div className="col-span-6">{assignmentDetailData.assetName} </div>
                  <div className="col-span-3">Specification</div>
                  <div className="col-span-6">{assignmentDetailData.specification} </div>
                  <div className="col-span-3">Assigned to</div>
                  <div className="col-span-6">{assignmentDetailData.assignedTo} </div>
                  <div className="col-span-3">Assigned by</div>
                  <div className="col-span-6">{assignmentDetailData.assignedBy} </div>
                  <div className="col-span-3">Assigned Date</div>
                  <div className="col-span-6">
                    {new Date(assignmentDetailData.assignedDate).toLocaleString("vi-VI", {
                      year: "numeric",
                      month: "2-digit",
                      day: "2-digit",
                    })}
                  </div>
                  <div className="col-span-3">State</div>
                  <div className="col-span-6">{AssignmentState[assignmentDetailData.state]}</div>
                  <div className="col-span-3">Note</div>
                  <div className="col-span-6">{assignmentDetailData.note}</div>
                </div>
              </div>
            </div>
      ) : (
        isLoading && (
          <div className="flex justify-center items-center">
            <AppLoader />
          </div>
        )
      )}
    </div>
    </>
  );
};

export default AssignmentInfo;
