import { TextField } from "@mui/material";
import { useController, UseControllerProps } from "react-hook-form";

interface Props extends UseControllerProps {
  id?: string;
  label?: string;
  placeholder?: string;
  size?: "small" | "medium";
  multiline?: boolean;
  rows?: number;
  type?: string;
  error?: boolean;
  helperText?: string;
  className?: string;
  InputProps?: any | undefined;
  defaultValue?: string | "";
  value?: any | undefined;
  maxRows?: number;
  sx?: any;
  disabled?: boolean;
  onKeyDown?: any;
  onChange?: any;
  isApplyHelperText?: boolean;
}

export default function AppTextInput({
  isApplyHelperText = true,
  ...props
}: Props) {
  const { fieldState, field } = useController({ ...props, defaultValue: "" });

  return (
    <TextField
      {...props}
      {...field}
      label={props.label}
      sx={props.sx ? props.sx : ""}
      multiline={props.multiline}
      rows={props.rows}
      maxRows={props.maxRows}
      type={props.type}
      size={props.size ?? "small"}
      placeholder={props.placeholder}
      disabled={props.disabled}
      variant="outlined"
      onKeyDown={props.onKeyDown}
      value={props.value}
      className={props.className}
      onChange={props.onChange}
      error={isApplyHelperText ? props.error || !!fieldState.error : undefined}
      helperText={
        isApplyHelperText
          ? props.error
            ? props.helperText
            : fieldState.error?.message
          : undefined
      }
      {...(props.InputProps && `inputProps=${props.InputProps}`)}
    />
  );
}
