import React from "react";

interface Props {
  styleType?: string;
  isFormSubmit?: boolean;
  content?: string;
  isLoading?: boolean;
  className?: string;
  onClickOn?: React.MouseEventHandler<HTMLButtonElement>;
}

const AppPaginatedButton = ({
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
          className={`flex gap-2 bg-primary text-white py-1 px-3 transition-all duration-200 ${className} ${
            isLoading
              ? "disabled pointer-events-none opacity-80"
              : "hover:bg-white hover:border hover:border-primary hover:text-primary hover hover:translate-y-[1px]"
          }`}
          onClick={onClickOn}
        >
          {isLoading ? (
            <div className="animate-spin h-5 w-5 border-4 border-white border-b-primary"></div>
          ) : (
            ""
          )}
          <p>{content ?? ""}</p>
        </button>
      ) : (
        <button
          type={isFormSubmit ? "submit" : "button"}
          className={`flex gap-2 bg-white text-primary py-1 px-3 transition-all duration-150 border-primary ${className} ${
            isLoading
              ? "disabled pointer-events-none opacity-50"
              : "hover:bg-white hover:border hover:border-primary hover:text-primary hover hover:translate-y-[1px]"
          }`}
          onClick={onClickOn}
        >
          {isLoading ? (
            <div className="animate-spin h-5 w-5 border border-primary border-b-white"></div>
          ) : (
            ""
          )}
          <p>{content ?? ""}</p>
        </button>
      )}
    </div>
  );
};

export default AppPaginatedButton;
