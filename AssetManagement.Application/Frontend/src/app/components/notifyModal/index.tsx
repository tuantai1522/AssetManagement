import Button from "../buttons/Button";

interface Props {
  title: string;
  message: string;
  isOpen: boolean;
  onClose: () => void;
}

const NotifyModal = ({ title, message, isOpen, onClose }: Props) => {
  if (!isOpen) return null;
  return (
    <>
      <div className="fixed w-screen h-screen bg-gray-400 top-0 left-0 opacity-50"></div>
      <div className="z-10 shadow-2xl absolute top-1/2 -translate-y-1/2">
        <div className="bg-white rounded-lg border border-black">
          <div className="bg-slate-100 rounded-t-lg border-b border-black px-12 py-5">
            <h2 className="text-lg font-bold text-primary">{title}</h2>
          </div>
          <div className="w-full h-full px-12 py-7">
            <p className="mb-7">{message}</p>
            <div className="flex justify-end">
              <Button
                styleType="secondary"
                onClickOn={onClose}
                content="Close"
              />
            </div>
          </div>
        </div>
      </div>
    </>
  );
};

export default NotifyModal;
