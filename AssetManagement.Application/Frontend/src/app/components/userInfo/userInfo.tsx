import agent from "../../api/agent";
import { BaseResult } from "../../models/BaseResult";
import { UserInfoResponse } from "../../models/login/UserInfoResponse";

interface Props {
  userId: string;
  onClose: () => void;
}

const UserInfo = ({
  userId,
  onClose,
}: Props) => {
  const {
    data,
    isLoading: userLoading,
  } = agent.Users.details(userId);
  
  const userData: UserInfoResponse = data?.result; 

  return (
    <>
      <div className="fixed w-screen h-screen bg-gray-400 top-0 left-0 opacity-50 "></div>
      <div className="z-10 shadow-2xl absolute top-1/2 -translate-y-1/2">
        <div className="bg-white rounded-lg border-gray-400 border-2 w-[120%]">
          <div className="bg-slate-100 rounded-t-lg border-b-2 border-gray-400 px-12 py-5 flex justify-between items-center">
            <h2 className="text-lg font-bold text-primary">
              Detailed User Information
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
            {userData ? (
              <div className="grid grid-cols-7 gap-4 text-secondary">
                <div className="col-span-2">Staff Code</div>
                <div className="col-span-5">{userData?.staffCode}</div>
                <div className="col-span-2">Full Name</div>
                <div className="col-span-5">
                  {userData?.firstName} {userData?.lastName}
                </div>
                <div className="col-span-2">Username</div>
                <div className="col-span-5">{userData?.username} </div>
                <div className="col-span-2">Date of Birth</div>
                <div className="col-span-5">
                  {new Date(userData?.dateOfBirth).toLocaleString("vi-VI", {
                    year: "numeric",
                    month: "2-digit",
                    day: "2-digit",
                  })}
                </div>
                <div className="col-span-2">Gender</div>
                <div className="col-span-5">{userData?.gender}</div>
                <div className="col-span-2">Joined Date</div>
                <div className="col-span-5">
                  {new Date(userData?.joinedDate).toLocaleString("vi-VN", {
                    year: "numeric",
                    month: "2-digit",
                    day: "2-digit",
                  })}
                </div>
                <div className="col-span-2">Type</div>
                <div className="col-span-5">{userData?.type}</div>
                <div className="col-span-2">Location</div>
                <div className="col-span-5">{userData?.location}</div>
              </div>
            ) : userLoading ? (
              <div className="min-h-60 flex justify-center items-center">
                <div className="animate-spin w-10 h-10 border-4 border-primary border-t-white border-b-white rounded-full"></div>
              </div>
            ) : ""
            }
          </div>
        </div>
      </div>
    </>
  );
};

export default UserInfo;
