import {
  Checkbox,
  FormControlLabel,
  Grid,
  Popover,
  TextField,
} from "@mui/material";
import { UseControllerProps } from "react-hook-form";

import FilterAltIcon from "@mui/icons-material/FilterAlt";
import { useState } from "react";
import SelectedItem from "../models/SelectedItem";

interface Props extends UseControllerProps {
  id?: string;
  sx?: any;

  items: Array<SelectedItem>;
  checked?: string[];
  onChangeSelectedBox: (event: any) => void;
  onSubmit: (event: any) => void;
}

export default function AppSelectedInput({ ...props }: Props) {
  //Open close list selected box
  const [anchorEl, setAnchorEl] = useState<HTMLDivElement | null>(null);

  const handleClick = (event: React.MouseEvent<HTMLDivElement>) => {
    setAnchorEl(event.currentTarget);
  };

  const handleClose = () => {
    setAnchorEl(null);
  };

  const open = Boolean(anchorEl);

  //Work with selected box
  const [checkedItems, setCheckedItems] = useState(props.checked || []);

  const handleChecked = (value: string) => {
    const currentIndex = checkedItems.findIndex((item) => item === value);
    let newChecked: string[] = [];

    //chưa được chọn trước đó => thêm vào danh sách được chọn
    if (currentIndex === -1) newChecked = [...checkedItems, value];
    //đã chọn trước đó => bỏ chọn
    else newChecked = checkedItems.filter((i) => i !== value);

    setCheckedItems(newChecked);
    props.onChangeSelectedBox(newChecked);
  };

  return (
    <>
      <Grid width={240} sx={{ ...props.sx }}>
        <Grid item>
          <Grid container justifyContent="center" alignItems="center">
            <Grid item xs={10}>
              <TextField
                fullWidth
                defaultValue={props.name}
                id={props.id}
                size="small"
                variant="outlined"
                InputProps={{
                  readOnly: true,
                }}
                onClick={handleClick}
              />
            </Grid>
            <Grid
              item
              xs={2}
              sx={{
                border: 1,
                cursor: "pointer",
                display: "flex",
                alignItems: "center",
                justifyContent: "center",
                padding: 0.9,
                borderRadius: 1,
              }}
              onClick={props.onSubmit}
            >
              <FilterAltIcon />
            </Grid>
          </Grid>
        </Grid>
        <Grid item>
          <Popover
            open={open}
            anchorEl={anchorEl}
            onClose={handleClose}
            anchorOrigin={{
              vertical: "bottom",
              horizontal: "left",
            }}
            transformOrigin={{
              vertical: "top",
              horizontal: "left",
            }}
          >
            <Grid width={240}>
              {props.items.map((option) => (
                <Grid item key={option.id}>
                  <FormControlLabel
                    value={option.id}
                    sx={{ padding: 1 }}
                    control={
                      <Checkbox
                        checked={props.checked?.indexOf(option.name) !== -1 ?? false}
                        onClick={() => handleChecked(option.name)}
                      />
                    }
                    label={option.name}
                  />
                </Grid>
              ))}
            </Grid>
          </Popover>
        </Grid>
      </Grid>
    </>
  );
}
