import AppButton from "../../app/components/buttons/Button";

export default function ManagementUserPage() {
  return (
    <div className="flex justify-center items-center h-full">
      {/* <ConfirmModal
        message="Do you want to disable this user?"
        confirmMessage="Disable"
        isOpen={true}
        onClose={() => {}}
        onConfirm={() => {}}
      /> */}
      {/* <NotifyModal
        message="You have succesfully change the password"
        title="Change Password"
        isOpen={true}
        onClose={() => {}}
      />  */}
      <AppButton
          styleType="primary"
          content="Login"
          isFormSubmit
          className="w-40"  
      >

      </AppButton>
    </div>
  );
}
