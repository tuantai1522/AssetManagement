import { SxProps, TextField } from "@mui/material";
import { UseControllerProps } from "react-hook-form";

interface Props extends UseControllerProps {
  id?: string;
  label?: string;
  placeholder?: string;
  size?: "small" | "medium";
  multiline?: boolean;
  rows?: number;
  type?: React.HTMLInputTypeAttribute;
  error?: boolean;
  helperText?: string;
  className?: string;
  defaultValue?: string | "";
  value?: any | undefined;
  maxRows?: number;
  sx?: SxProps;
  disabled?: boolean;
  onKeyDown?: any;
  onChange?: any;
  isApplyHelperText?: boolean;
}

export default function AppSearchInput({
  isApplyHelperText = true,
  ...props
}: Props) {

  return (
    <TextField
      {...props}
      id={props.id}
      label={props.label}
      sx={{
        '& .MuiOutlinedInput-root': {
          '& > fieldset': {
            border: "1px solid gray",
            // borderRight: 'none',
            borderRadius: "6px 0  0 6px",
          },
          '&.Mui-focused fieldset': {
            border: "2px solid #cf2338",
            // borderRight: 'none',
            borderRadius: "6px 0  0 6px"
          }
        },        
        minWidth: "200px",
        maxWidth: "350px",
        ...props.sx
      }}
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
    />
  );
}
