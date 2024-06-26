import React, { useEffect } from "react";
import AppButton from "../buttons/Button";
import { useNavigate } from "react-router-dom";
import { Controller, FieldValues, useForm } from "react-hook-form";
import {
  FormControl,
  FormControlLabel,
  FormHelperText,
  MenuItem,
  Radio,
  RadioGroup,
  Select,
} from "@mui/material";
import UserForm from "./userForm";
import { yupResolver } from "@hookform/resolvers/yup";
import { createAssetSchema } from "../../schemas/createAssetSchema";
import AppTextInput from "../AppTextInput";
import { DatePicker, LocalizationProvider } from "@mui/x-date-pickers";
import { AdapterDayjs } from "@mui/x-date-pickers/AdapterDayjs";
import { AssetStatus } from "../../types/enum";

interface Props {
  handleCreateAsset: (data: any) => void;
}

interface IFormType extends FieldValues {
  name: string;
  categoryId: string;
  specification: string;
  installedDate: Date;
  status: string;
}

const CreateAssetForm = (props: Props) => {
  const {
    handleSubmit,
    control,
    formState: { isValid, errors },
  } = useForm({
    resolver: yupResolver<IFormType>(createAssetSchema),
    defaultValues: {},
    mode: "all",
  });
  const navigate = useNavigate();

  const categoryData = [
    {
      categoryId: "abc-123",
      name: "Laptop",
    },
    {
      categoryId: "abc-234",
      name: "Personal Computer",
    },
    {
      categoryId: "abc-456",
      name: "Monitor",
    },
  ];

  return (
    <div className="bg-white w-[35rem] mx-auto">
      <h2 className="text-2xl font-bold text-primary mb-5">Create New Asset</h2>
      <form onSubmit={handleSubmit(props.handleCreateAsset)} className="space-y-6">
        <div className="flex items-center gap-5 pl-2">
          <label className="w-[7rem]">Name</label>
          <Controller
            name="name"
            control={control}
            render={({ field }) => (
              <AppTextInput
                {...field}
                id="asset-name-text-field-form"
                control={control}
                className="grow"
              />
            )}
          />
        </div>

        <div className="flex items-center gap-5 pl-2">
          <label className="w-[7rem]">Type</label>
          <div className="grow">
            <Controller
              control={control}
              name="categoryId"
              render={({ field, fieldState: { error } }) => (
                <FormControl fullWidth>
                  <Select
                    size="small"
                    {...field}
                    id="type-selection-form"
                    error={!!error}
                    value={field.value || ""}
                    onChange={(e) => field.onChange(e.target.value)}
                  >
                    {categoryData.map((cat, i) => (
                      <MenuItem key={i} value={cat.categoryId}>{cat.name}</MenuItem>
                    ))}
                  </Select>
                  {error && (
                    <FormHelperText
                      id="type-select-error"
                      sx={{ color: "#d32f2f" }}
                    >
                      {error.message}
                    </FormHelperText>
                  )}
                </FormControl>
              )}
            />
          </div>
        </div>

        <div className="flex gap-5 pl-2">
          <label className="w-[7rem]">Specification</label>
          <Controller
            name="specification"
            control={control}
            render={({ field }) => (
              <AppTextInput
                {...field}
                id="asset-specification-text-field-form"
                multiline
                rows={3}
                control={control}
                className="grow"
              />
            )}
          />
        </div>
        <div className="flex items-center gap-5 pl-2">
          <label className="w-[7rem]">Installed Date</label>
          <LocalizationProvider dateAdapter={AdapterDayjs}>
            <Controller
              control={control}
              name="installedDate"
              render={({ field, fieldState: { error } }) => (
                <DatePicker
                  {...field}
                  format="DD/MM/YYYY"
                  disableFuture
                  className="grow"
                  slotProps={{
                    textField: {
                      size: "small",
                      id: "dateOfBirth-dpk-form",
                      helperText: error ? error.message : "",
                      error: !!error,
                    },
                  }}
                />
              )}
            />
          </LocalizationProvider>
        </div>

        <div className="flex gap-5 pl-2">
          <label className="w-[7rem]">Status</label>
          <div className="grow">
            <Controller
              control={control}
              name="status"
              render={({ field }) => (
                <RadioGroup
                  {...field}
                  color="warning"
                  id="gender-radio-form"
                  value={field.value || AssetStatus.Available} // Ensure a default value is set if field.
                  onChange={(e) => field.onChange(e.target.value)}
                >
                  <FormControlLabel
                    value={AssetStatus.Available}
                    control={
                      <Radio sx={{ "&.Mui-checked": { color: "#cf2338" } }} />
                    }
                    label="Available"
                  />
                  <FormControlLabel
                    value={AssetStatus.NotAvailable}
                    control={
                      <Radio sx={{ "&.Mui-checked": { color: "#cf2338" } }} />
                    }
                    label="Not available"
                  />
                </RadioGroup>
              )}
            />
          </div>
        </div>
        <div className="flex justify-end space-x-4">
          <AppButton content="Save" isFormSubmit={true} />
          <AppButton
            content="Cancel"
            styleType="Secondary"
            onClickOn={() => {
              navigate(-1);
            }}
          />
        </div>
      </form>
    </div>
  );
};

export default CreateAssetForm;
