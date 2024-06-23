import { InputAdornment, MenuItem, TextField } from "@mui/material";
import { useController, UseControllerProps } from "react-hook-form";

import FilterAltIcon from "@mui/icons-material/FilterAlt";

interface Item {
  id: string;
  name: string;
}

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
  onChange?: any;
  isApplyHelperText?: boolean;

  items: Array<Item>;
}

export default function AppSelectedInput({
  isApplyHelperText = true,
  ...props
}: Props) {
  const { fieldState, field } = useController({ ...props, defaultValue: "" });

  return (
    <TextField
      {...props}
      {...field}
      select
      SelectProps={{
        IconComponent: () => null,
      }}
      defaultValue={props.items && props.items[0].name}
      label={props.label}
      id={props.id}
      sx={{ ...props.sx, width: 180 }}
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
      InputProps={{
        endAdornment: (
          <InputAdornment position="end">
            <FilterAltIcon></FilterAltIcon>
          </InputAdornment>
        ),
      }}
    >
      {props.items.map((option) => (
        <MenuItem key={option.id} value={option.name}>
          {option.name}
        </MenuItem>
      ))}
    </TextField>
  );
}
