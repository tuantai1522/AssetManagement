interface Props {
  styleType?: string;
  isFormSubmit?: boolean;
  content?: string;
  isLoading?: boolean;
  className?: string;
  onClickOn?: () => void;
}

const AppButton = ({
  styleType = "primary",
  isFormSubmit = false,
  content,
  isLoading = false,
  className,
  onClickOn,
}: Props) => {
  return (
    <div>
      {styleType === "primary" ? (
        <button
          type={isFormSubmit ? "submit" : "button"}
          className={`flex gap-2 bg-primary text-white font-semibold py-2 px-4 rounded-lg border-2 transition-all duration-200 border-primary ${className} ${
            isLoading
              ? "disabled pointer-events-none opacity-80"
              : "hover:bg-white hover:border-2 hover:border-primary hover:text-primary hover:font-semibold hover:translate-y-[3px]"
          }`}
          onClick={onClickOn && onClickOn}
        >
          {isLoading ? (
            <div className="animate-spin h-5 w-5 border-4 border-white rounded-full border-b-primary"></div>
          ) : (
            ""
          )}
          <p>{content ?? ""}</p>
        </button>
      ) : (
        <button
          type={isFormSubmit ? "submit" : "button"}
          className={`flex gap-2 bg-white text-gray-400 font-semibold py-2 px-4 rounded-lg border-2 transition-all duration-150 border-gray-400 ${className} ${
            isLoading
              ? "disabled pointer-events-none opacity-50"
              : "hover:bg-white hover:border-2 hover:border-primary hover:text-primary hover:font-semibold hover:translate-y-[3px]"
          }`}
          onClick={onClickOn && onClickOn}
        >
          {isLoading ? (
            <div className="animate-spin h-5 w-5 border-4 border-gray-400 rounded-full border-b-white"></div>
          ) : (
            ""
          )}
          <p>{content ?? ""}</p>
        </button>
      )}
    </div>
  );
};

export default AppButton;
