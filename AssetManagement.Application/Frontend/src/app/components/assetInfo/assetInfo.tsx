import agent from "../../api/agent";
import AssetDetailsResponse from "../../models/asset/AssetDetailsResponse";
import { states } from "../../utils/helper";
import AppLoader from "../AppLoader";

interface Props {
  assetId: string;
  onClose: () => void;
}

interface AssignmentResponse {
  date: Date;
  assignedTo: string;
  assignedBy: string;
  returnedDate: Date;
}

const assignments: Array<AssignmentResponse> = [
  {
    date: new Date("2022-01-16"),
    assignedTo: "John Doe",
    assignedBy: "Jane Smith",
    returnedDate: new Date("2023-01-15"),
  },
  {
    date: new Date("2023-01-20"),
    assignedTo: "Emily Johnson",
    assignedBy: "Jane Smith",
    returnedDate: new Date("2023-01-16"),
  },
];

const AssetInfo = ({ assetId, onClose }: Props) => {
  const { data, isLoading: assetLoading } = agent.Asset.details(assetId);

  const assetData: AssetDetailsResponse = data?.result;

  //mutate state of asset
  const item = states.find((x) => x.value === assetData?.state);

  return (
    <>
      <div className="fixed w-screen h-screen bg-gray-400 top-0 left-0 opacity-50 "></div>
      {assetData ? (
        <div className="z-10 shadow-2xl absolute top-0 translate-x-[15%]">
          <div className="bg-white rounded-lg border-gray-400 border-2">
            <div className="bg-slate-100 rounded-t-lg border-b-2 border-gray-400 px-12 py-5 flex justify-between items-center">
              <h2 className="text-lg font-bold text-primary">
                Detailed Asset Information
              </h2>
              <div
                onClick={onClose}
                className="border-2 border-primary rounded-sm text-primary cursor-pointer transition-all hover:text-white hover:bg-primary"
              >
                <svg
                  xmlns="http://www.w3.org/2000/svg"
                  fill="none"
                  viewBox="0 0 24 24"
                  strokeWidth="4.5"
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
            <div className="w-full h-full px-12 py-7">
              <div className="grid grid-cols-6 gap-4 text-secondary">
                <div className="col-span-1">Asset Code</div>
                <div className="col-span-5">{assetData?.assetCode}</div>
                <div className="col-span-1">Asset Name</div>
                <div className="col-span-5">{assetData?.assetName} </div>
                <div className="col-span-1">Category</div>
                <div className="col-span-5">{assetData?.categoryName} </div>
                <div className="col-span-1">Installed Date</div>
                <div className="col-span-5">
                  {new Date(assetData?.installedDate).toLocaleString("vi-VI", {
                    year: "numeric",
                    month: "2-digit",
                    day: "2-digit",
                  })}
                </div>
                <div className="col-span-1">State</div>
                <div className="col-span-5">{item?.label}</div>
                <div className="col-span-1">Location</div>
                <div className="col-span-5">{assetData?.location}</div>
                <div className="col-span-1">Specification</div>
                <div className="col-span-5">{assetData?.specification}</div>
                <div className="col-span-1">History</div>
                <div className="col-span-5 grid grid-cols-4 gap-2">
                  <div className="font-extrabold  border-b border-black border-solid">
                    Date
                  </div>
                  <div className="font-extrabold  border-b border-black border-solid">
                    Assigned to
                  </div>
                  <div className="font-extrabold  border-b border-black border-solid">
                    Assigned by
                  </div>
                  <div className="font-extrabold  border-b border-black border-solid">
                    Returned date
                  </div>

                  {assignments.map((row, index) => {
                    return (
                      <>
                        <div className="col-span-1 border-b border-black border-solid">
                          {new Date(row?.date).toLocaleString("vi-VI", {
                            year: "numeric",
                            month: "2-digit",
                            day: "2-digit",
                          })}
                        </div>
                        <div className="col-span-1 border-b border-black border-solid">
                          {row.assignedTo}
                        </div>
                        <div className="col-span-1 border-b border-black border-solid">
                          {row.assignedBy}
                        </div>
                        <div className="col-span-1 border-b border-black border-solid">
                          {row?.returnedDate
                            ? new Date(row?.returnedDate).toLocaleString(
                                "vi-VI",
                                {
                                  year: "numeric",
                                  month: "2-digit",
                                  day: "2-digit",
                                }
                              )
                            : ""}
                        </div>
                      </>
                    );
                  })}
                </div>
              </div>
            </div>
          </div>
        </div>
      ) : (
        assetLoading && (
          <div className="flex justify-center items-center">
            <AppLoader />
          </div>
        )
      )}
    </>
  );
};

export default AssetInfo;
