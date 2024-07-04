import {
  Checkbox,
  FormControlLabel,
  Grid,
  Popover,
  Stack,
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
    let newChecked: string[] = [];
    if (value === "all") {
      if (props?.items?.length > checkedItems?.length - 1) {
        newChecked = ["all", ...props?.items?.map((i, index) => i.id) ?? []];
      } else {
        newChecked = [];
      }
    } else {
      const currentIndex = checkedItems.findIndex((item) => item === value);

      //chưa được chọn trước đó => thêm vào danh sách được chọn
      if (currentIndex === -1) {
        newChecked = [...checkedItems, value];
        if (newChecked.length === props.items.length) {
          newChecked = ["all", ...newChecked]
        }
      }
      //đã chọn trước đó => bỏ chọn
      else {
        newChecked = checkedItems.filter((i) => i !== value && i !== "all");
      }
    }

    setCheckedItems(newChecked);
    props.onChangeSelectedBox(newChecked);
  };

  return (
    <>
      <Grid width={160} sx={{ ...props.sx }}>
        <Grid item>
          <Stack
            direction="row"
            justifyContent="flex-start"
            alignItems="center"
            spacing={2}
          >
            <TextField
              fullWidth
              defaultValue={props.name}
              id={props.id}
              size="small"
              variant="outlined"
              InputProps={{
                readOnly: true,
              }}
              className="hover:text-red-600"
              onClick={handleClick}
              sx={{
                '& .MuiOutlinedInput-root': {
                  '& > fieldset': {
                    border: "1px solid gray",
                    borderRadius: "6px 0  0 6px",
                  },
                  '&.Mui-focused fieldset': {
                    border: "2px solid #cf2338",
                    borderRadius: "6px 0  0 6px"
                  },
                  '&.Mui-focused fieldset:hover': {
                    border: "2px solid #cf2338",
                    borderRadius: "6px 0  0 6px",
                    cursor: "pointer"
                  }
                },
                minWidth: "190px",
                maxWidth: "250px",
              }}
            />
            <button
              className="border border-gray-500 border-l-0 rounded-r-md mx-0 hover:cursor-pointer"
              style={{ margin: 0, padding: "6px", height: "40px"}}
              title="Filter"
              onClick={props.onSubmit}
            >
              <FilterAltIcon className="mx-0" />
            </button>
          </Stack>
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
            <Grid width={230}>
              <Grid item >
                <FormControlLabel
                  value={"all"}
                  sx={{ padding: 1 }}
                  control={
                    <Checkbox
                      sx={{
                        '&.Mui-checked': {
                          color: "#CF2338",
                        },
                      }}
                      checked={props.checked?.indexOf("all") !== -1 ?? false}
                      onClick={() => handleChecked("all")}
                    />
                  }
                  label={"All"}
                />
              </Grid>
              {props.items?.map((option) => (
                <Grid item key={option.id}>
                  <FormControlLabel
                    value={option.id}
                    sx={{
                      padding: 1,
                    }}
                    control={
                      <Checkbox
                        checked={props.checked?.indexOf(option.id) !== -1 ?? false}
                        onClick={() => handleChecked(option.id)}
                        sx={{
                          '&.Mui-checked': {
                            color: "#CF2338",
                          },
                        }}
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
