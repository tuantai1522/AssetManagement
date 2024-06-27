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
import { yupResolver } from "@hookform/resolvers/yup";
import { createAssetSchema } from "../../schemas/createAssetSchema";
import AppTextInput from "../AppTextInput";
import { DatePicker, LocalizationProvider } from "@mui/x-date-pickers";
import { AdapterDayjs } from "@mui/x-date-pickers/AdapterDayjs";
import { AssetStateEnum } from "../../types/enum";
import { Category } from "../../models/category/Category";
import agent from "../../api/agent";
import { AssetCreationForm } from "../../models/asset/AssetCreationRequest";

interface Props {
  handleCreateAsset: (data: any) => void;
}

const CreateAssetForm = ({ handleCreateAsset }: Props) => {
  const categories = agent.Category.all();

  const {
    handleSubmit,
    control,
    formState: { isValid, errors },
  } = useForm({
    resolver: yupResolver<AssetCreationForm>(createAssetSchema),
    defaultValues: {},
    mode: "all",
  });
  const navigate = useNavigate();

  return (
    <div className="bg-white w-[35rem] mx-auto">
      <h2 className="text-2xl font-bold text-primary mb-5">Create New Asset</h2>
      <form onSubmit={handleSubmit(handleCreateAsset)} className="space-y-6">
        <div>
          <div className="flex items-center gap-5 pl-2">
            <label className="w-[7rem]">Name</label>
            <Controller
              name="name"
              control={control}
              render={({ field }) => (
                <AppTextInput
                  {...field}
                  id="assetName"
                  control={control}
                  className="grow"
                  isApplyHelperText={false}
                />
              )}
            />
          </div>
          {errors.name && (
            <div className="flex items-end justify-end">
              <span className="text-[#d32f2f] font-normal text-xs w-[410px] mt-1">
                {errors.name.message as string}
              </span>
            </div>
          )}
        </div>

        <div>
          <div className="flex items-center gap-5 pl-2">
            <label className="w-[7rem]">Category</label>
            <div className="grow">
              <Controller
                control={control}
                name="categoryId"
                render={({ field, fieldState: { error } }) => (
                  <FormControl fullWidth>
                    <Select
                      size="small"
                      {...field}
                      id="assetCategorySelection"
                      // error={!!error}
                      value={field.value || ""}
                      onChange={(e) => field.onChange(e.target.value)}
                    >
                      {categories.data &&
                        (
                          (categories.data.items.result as Category[]) ?? []
                        ).map((category, index) => (
                          <MenuItem key={index} value={category.id}>
                            {category.name}
                          </MenuItem>
                        ))}
                    </Select>
                  </FormControl>
                )}
              />
            </div>
          </div>
          {errors.categoryId && (
            <div className="flex items-end justify-end">
              <span className="text-[#d32f2f] font-normal text-xs w-[410px] mt-1">
                {errors.categoryId.message as string}
              </span>
            </div>
          )}
        </div>
        <div>
          <div className="flex gap-5 pl-2">
            <label className="w-[7rem]">Specification</label>
            <Controller
              name="specification"
              control={control}
              render={({ field }) => (
                <AppTextInput
                  {...field}
                  id="assetSpecification"
                  isApplyHelperText={false}
                  multiline
                  rows={3}
                  control={control}
                  className="grow"
                />
              )}
            />
          </div>
          {errors.specification && (
            <div className="flex items-end justify-end">
              <span className="text-[#d32f2f] font-normal text-xs w-[410px] mt-1">
                {errors.specification.message as string}
              </span>
            </div>
          )}
        </div>
        <div>
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
                        id: "assetInstalledDate",
                      },
                    }}
                  />
                )}
              />
            </LocalizationProvider>
          </div>
          {errors.installedDate && (
            <div className="flex items-end justify-end">
              <span className="text-[#d32f2f] font-normal text-xs w-[410px] mt-1">
                {errors.installedDate.message as string}
              </span>
            </div>
          )}
        </div>

        <div className="flex gap-5 pl-2">
          <label className="w-[7rem]">State</label>
          <div className="grow">
            <Controller
              control={control}
              name="state"
              render={({ field }) => (
                <RadioGroup
                  {...field}
                  color="warning"
                  id="asset-state-radio"
                  value={field.value || AssetStateEnum.Available} // Ensure a default value is set if field.
                  onChange={(e) => field.onChange(e.target.value)}
                >
                  <FormControlLabel
                    value={AssetStateEnum.Available}
                    control={
                      <Radio sx={{ "&.Mui-checked": { color: "#cf2338" } }} />
                    }
                    label="Available"
                  />
                  <FormControlLabel
                    value={AssetStateEnum.NotAvailable}
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
