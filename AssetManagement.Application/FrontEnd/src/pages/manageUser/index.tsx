// import { useState } from "react";
import { useState } from "react";
import agent from "../../app/api/agent";
import ConfirmModal from "../../app/components/confirmModal";
import UserList from "./userList/userList";

export default function ManagementUserPage() {
  // const [users, setUsers] = useState<FilterUser[]>([]);
  const { data, isLoading, error, mutate } = agent.Users.filter();
  console.log(`Data: ${JSON.stringify(data, null, 2)}`);

  const [isDisablingModalOpen, setIsDisablingModalOpen] = useState(false);
  const [currentDisablingId, setCurrentDisablingId] = useState("");

  const handleDisable = (id: string) => {
    agent.Users.disable(id);
    mutate();
  };

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
            setIsOpenDisablingModal={setIsDisablingModalOpen}
            setCurrentDisablingId={setCurrentDisablingId}
          />
        </div>
      </div>
      <ConfirmModal
        message="Do you want to disable this user?"
        confirmMessage="Disable"
        isOpen={isDisablingModalOpen}
        onClose={() => setIsDisablingModalOpen(false)}
        onConfirm={() => {
          setIsDisablingModalOpen(false);
          handleDisable(currentDisablingId);
        }}
      />
      {/* <NotifyModal
        message="You have succesfully change the password"
        title="Change Password"
        isOpen={true}
        onClose={() => {}}
      />  */}
    </div>
  );
}
