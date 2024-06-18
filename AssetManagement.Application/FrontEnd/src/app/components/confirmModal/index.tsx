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
  titleMessage,
  confirmMessage,
  cancelMessage,
  isOpen,
  onClose,
  onConfirm,
}: Props) => {
  if (!isOpen) return null;

  return (
    <div className="absolute translate-x-1/2 translate-y-3/4 bg-white rounded-lg border border-black w-[32rem]">
      <div className="bg-slate-100 rounded-t-lg border-b border-black px-12 py-5">
        <h2 className="text-lg font-bold text-primary">
          {titleMessage ?? "Are you sure?"}
        </h2>
      </div>
      <div className="w-full h-full px-12 py-5">
        <p className="mb-6">{message}</p>
        <div className="flex space-x-4">
          <button
            className="bg-primary text-white px-4 py-2 rounded hover:bg-red-600"
            onClick={onConfirm}
          >
            {confirmMessage ?? "OK"}
          </button>
          <button
            className="border border-black text-gray-700 px-4 py-2 rounded hover:bg-gray-300"
            onClick={onClose}
          >
            {cancelMessage ?? "Cancel"}
          </button>
        </div>
      </div>
    </div>
  );
};

export default ConfirmModal;
