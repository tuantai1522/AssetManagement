import { useState } from "react";
import ConfirmModal from "../../app/components/confirmModal";
import agent from "../../app/api/agent";

export default function ManagementUserPage() {
  const [isDisablingModalOpen, setDisablingModalOpen] = useState(false);
  const [currentDisablingId, setCurrentDisablingId] = useState("");

  const handleDisable = (id: string) => {
    if (!id && id !== "") agent.Users.disable(id);
  };

  return (
    <div className="flex justify-center items-center h-full">
      <button
        onClick={() => {
          setCurrentDisablingId("");
          setDisablingModalOpen(true);
        }}
      >
        Delete
      </button>
      <ConfirmModal
        message="Do you want to disable this user?"
        confirmMessage="Disable"
        isOpen={isDisablingModalOpen}
        onClose={() => setDisablingModalOpen(false)}
        onConfirm={() => {
          setDisablingModalOpen(false);
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
