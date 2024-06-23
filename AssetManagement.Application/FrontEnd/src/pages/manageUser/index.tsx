// import { useState } from "react";
import { useState } from "react";
import agent from "../../app/api/agent";
import UserInfo from "../../app/components/userInfo/userInfo";
import UserList from "./userList/userList";

export default function ManagementUserPage() {
  const [clickOnUser, setClickOnUser] = useState<boolean>(false)
  const [userId, setUserId] = useState<string>("0")

  const { data, isLoading, error } = agent.Users.filter();

  const {data:userData, isLoading:userLoading, error:userError} = agent.Users.details(userId);

  const handleClickOnUser = (rowId:string) => {
    setClickOnUser(true);
    setUserId(data.items.result[rowId].id);
  }
  return (
    <div className="flex justify-center h-full">
      <div className="container">
        <p className="text-primary text-xl font-bold justify-start items-start">
          User List
        </p>
        <div className="mt-3">
          <UserList
            data={data?.items?.result}
            error={error}
            isLoading={isLoading}
            onClickOnUser={(rowId) => handleClickOnUser(rowId)}
          />
        </div>
      </div>

      <UserInfo
        isOpen={clickOnUser}
        isLoading = {userLoading}
        userData={userData?.result}
        onClose={() => {
          setClickOnUser(false);
        }}
      ></UserInfo>
    </div>
  );
}
