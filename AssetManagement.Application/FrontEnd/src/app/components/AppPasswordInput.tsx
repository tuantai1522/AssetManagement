import { Visibility, VisibilityOff } from "@mui/icons-material";
import { IconButton, InputAdornment, TextField } from "@mui/material";
import { useState } from "react";
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
  defaultValue?: string | "";
  value?: any | undefined;
  maxRows?: number;
  sx?: any;
  disabled?: boolean;
  onKeyDown?: any;
  isApplyHelperText?: boolean;
}

export default function AppPasswordInput({
  isApplyHelperText = true,
  ...props
}: Props) {
  const { fieldState, field } = useController({ ...props, defaultValue: "" });

  const [visible, setVisible] = useState(false);
  const handleClick = () => setVisible(!visible);

  return (
    <TextField
      {...props}
      {...field}
      id={props.id}
      label={props.label}
      sx={props.sx ? props.sx : ""}
      multiline={props.multiline}
      rows={props.rows}
      maxRows={props.maxRows}
      type={visible ? "text" : "password"}
      size={props.size ?? "small"}
      placeholder={props.placeholder}
      disabled={props.disabled}
      variant="outlined"
      onKeyDown={props.onKeyDown}
      value={props.value}
      className={props.className}
      error={isApplyHelperText ? props.error || !!fieldState.error : undefined}
      helperText={
        isApplyHelperText
          ? props.error
            ? props.helperText
            : fieldState.error?.message
          : undefined
      }
      InputProps={{
        endAdornment: (
          <InputAdornment position="end">
            <IconButton onClick={handleClick}>
              {visible ? <VisibilityOff /> : <Visibility />}
            </IconButton>
          </InputAdornment>
        ),
      }}
    />
  );
}
