import { Alert, Snackbar } from "@mui/material";
import { Dispatch, SetStateAction } from "react";

interface Props {
  verticalPosition?: "top" | "bottom";
  horizontalPosition?: "left" | "right";
  isOpen: boolean;
  duration?: number; // in milliseconds
  onClose: () => void;
  severity: "error" | "info" | "success" | "warning";
  message: string;
}

const Toast = ({
  verticalPosition = "top",
  horizontalPosition = "right",
  isOpen,
  duration = 6000,
  onClose,
  severity,
  message,
}: Props) => {
  return (
    <Snackbar
      anchorOrigin={{
        vertical: verticalPosition,
        horizontal: horizontalPosition,
      }}
      open={isOpen}
      autoHideDuration={duration}
      onClose={onClose}
    >
      <Alert
        onClose={onClose}
        severity={severity}
        variant="outlined"
        sx={{ width: "100%", bgcolor: "background.paper" }}
      >
        {message}
      </Alert>
    </Snackbar>
  );
};

export default Toast;
