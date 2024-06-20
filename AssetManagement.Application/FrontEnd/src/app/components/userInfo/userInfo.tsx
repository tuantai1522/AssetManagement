import agent from "../../api/agent";
import { UserInfoResponse } from "../../models/response/UserInfoResponse";

interface Props {
  isOpen?: boolean;
  userData? : UserInfoResponse;
  isLoading?: boolean
  errorMessage?: string ;
  onClose: () => void;
}

const UserInfo = ({isOpen, userData, isLoading, errorMessage, onClose }: Props) => {
    if (!isOpen) return null;
  return (
    <>
      <div className="fixed w-screen h-screen bg-gray-400 top-0 left-0 opacity-50 "></div>
      <div className="z-10 shadow-2xl">
        <div className="bg-white rounded-lg border-gray-400 border-2 w-[120%]">
          <div className="bg-slate-100 rounded-t-lg border-b-2 border-gray-400 px-12 py-5 flex justify-between items-center">
            <h2 className="text-lg font-bold text-primary">
              Detailed User Infomation
            </h2>
            <div className="border-2 border-primary rounded-sm text-primary cursor-pointer transition-all hover:text-white hover:bg-primary">
              <svg
                xmlns="http://www.w3.org/2000/svg"
                fill="none"
                viewBox="0 0 24 24"
                strokeWidth="4.5"
                stroke="currentColor"
                className="size-4"
                onClick={onClose}
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
            {userData 
            ?
            <div className="grid grid-cols-7 gap-4 text-secondary">
                <div className="col-span-2">Staff Code</div>
                <div className="col-span-5">{userData?.staffCode}</div>
                <div className="col-span-2">Full Name</div>
                <div className="col-span-5">{userData?.fullName} </div>
                <div className="col-span-2">Username</div>
                <div className="col-span-5">{userData?.username} </div>
                <div className="col-span-2">Date of Birth</div>
                <div className="col-span-5">{new Date(userData?.dateOfBirth).toLocaleString("vi-VI", {
                    year: "numeric",
                    month: "2-digit",
                    day: "2-digit",
                })}
                </div>
                <div className="col-span-2">Gender</div>
                <div className="col-span-5">{userData?.gender}
                </div>
                <div className="col-span-2">Joined Date</div>
                <div className="col-span-5">{new Date(userData?.joinedDate).toLocaleString('vi-VN', {
                    year: "numeric",
                    month: "2-digit",
                    day: "2-digit",
                })}
                </div>
                <div className="col-span-2">Type</div>
                <div className="col-span-5">{userData?.types[0]}
                </div>
                <div className="col-span-2">Location</div>
                <div className="col-span-5">{userData?.location}
                </div>
            </div>
            : isLoading 
            ?
            <div className="min-h-60 flex justify-center items-center">
                <div className="animate-spin w-10 h-10 border-4 border-primary border-t-white border-b-white rounded-full"></div>
            </div>
            :
            errorMessage
            ?
            <div className="min">
                <p className="text-primary font-semibold text-lg">
                    Oops!
                </p>
                <p className="text-secondary">
                    Sorry, {errorMessage}
                </p>
            </div>
            :
            ""
            }
          </div>
        </div>
      </div>
    </>
  );
};

export default UserInfo;