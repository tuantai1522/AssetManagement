import Button  from "../buttons/Button";

interface Props {
  message: string;
  titleMessage?: string;
  confirmMessage?: string;
  cancelMessage?: string;
  isOpen: boolean;
  onClose: () => void;
  onConfirm: () => void;
}

const ConfirmModal = ({
  message,
  titleMessage = "Are you sure?",
  confirmMessage = "OK",
  cancelMessage = "Cancel",
  isOpen,
  onClose,
  onConfirm,
}: Props) => {
  if (!isOpen) return null;

  return (
    <>
      <div className="fixed w-screen h-screen bg-slate-200 top-0 left-0 opacity-0">
        
      </div>
      <div className="z-10">
        <div className="bg-white rounded-lg border border-black w-[32rem]">
          <div className="bg-slate-100 rounded-t-lg border-b border-black px-12 py-5">
            <h2 className="text-lg font-bold text-primary">{titleMessage}</h2>
          </div>
          <div className="w-full h-full px-12 py-5">
            <p className="mb-6">{message}</p>
            <div className="flex space-x-4">
              <Button
                content={confirmMessage}
                onClickOn={onConfirm}
              />
              <Button
                styleType="secondary"
                content={cancelMessage}
                onClickOn={onClose}
              />
            </div>
          </div>
        </div>
      </div>
    </>
  );
};

export default ConfirmModal;
