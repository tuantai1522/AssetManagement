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
              <button
                className="bg-primary text-white px-4 py-2 rounded hover:bg-red-600"
                onClick={onConfirm}
              >
                {confirmMessage}
              </button>
              <button
                className="border border-black text-gray-700 px-4 py-2 rounded hover:bg-gray-300"
                onClick={onClose}
              >
                {cancelMessage}
              </button>
            </div>
          </div>
        </div>
      </div>
    </>
  );
};

export default ConfirmModal;
