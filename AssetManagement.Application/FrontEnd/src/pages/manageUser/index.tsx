import ConfirmModal from "../../app/components/confirmModal";

export default function ManagementUserPage() {
  return (
    <div className="relative bg-black w-full h-full">
      <ConfirmModal
        message="Do you want to disable this user?"
        confirmMessage="Disable"
        isOpen={true}
        onClose={() => {}}
        onConfirm={() => {}}
      />
    </div>
  );
}
