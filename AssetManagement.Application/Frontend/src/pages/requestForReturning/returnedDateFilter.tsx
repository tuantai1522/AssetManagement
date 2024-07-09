import { FilterAlt } from "@mui/icons-material";
import { Stack } from "@mui/material";
import {
  DatePicker,
  LocalizationProvider
} from "@mui/x-date-pickers";
import { AdapterDayjs } from "@mui/x-date-pickers/AdapterDayjs";
import { Dayjs } from "dayjs";
import { FormEvent } from "react";

export interface Props {
  returnedDate?: Dayjs | null;
  handleReturnedDateChange: (date: Dayjs | null) => void;
  handleFilterClick: (event: FormEvent<HTMLFormElement>) => void;
}

const ReturnedDateFilter = (props: Props) => {
  const isDateValid =
    props.returnedDate === null ||
    (props.returnedDate !== null && props.returnedDate?.isValid());

  return (
    <form onSubmit={props.handleFilterClick}>
      <Stack
        direction="row"
        justifyContent="flex-start"
        alignItems="center"
        spacing={2}
      >
        <LocalizationProvider dateAdapter={AdapterDayjs}>
          <DatePicker
            label="Returned date"
            format="DD/MM/YYYY"
            className="grow"
            value={props.returnedDate}
            onChange={props.handleReturnedDateChange}
            sx={{
              "& .MuiOutlinedInput-root": {
                "& > fieldset": {
                  border: "1px solid gray",
                  borderRadius: "6px 0  0 6px",
                },
                "&.Mui-focused fieldset": {
                  borderRadius: "6px 0  0 6px",
                },
              },

              width: "200px",
            }}
            slotProps={{
              textField: {
                size: "small",
                id: "assignment-dpk-filter",
              },
              actionBar: {
                actions: ["clear"],
              },
            }}
          />
        </LocalizationProvider>
        <button
          className="border border-gray-500 border-l-0 rounded-r-md mx-0 hover:cursor-pointer"
          style={{ margin: 0, padding: "6px", height: "40px" }}
          title="Filter"
          type="submit"
          // onClick={props.handleFilterClick}
          disabled={!isDateValid}
        >
          <FilterAlt className="mx-0" />
        </button>
      </Stack>
    </form>
  );
};

export default ReturnedDateFilter;
