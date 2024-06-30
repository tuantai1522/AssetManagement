import AppButton from "../buttons/Button";
import { useNavigate } from "react-router-dom";
import { Controller, useForm } from "react-hook-form";
import {
  FormControl,
  FormControlLabel,
  MenuItem,
  Radio,
  RadioGroup,
  Select,
  Typography,
} from "@mui/material";
import { yupResolver } from "@hookform/resolvers/yup";
import AppTextInput from "../AppTextInput";
import { DatePicker, LocalizationProvider } from "@mui/x-date-pickers";
import { AdapterDayjs } from "@mui/x-date-pickers/AdapterDayjs";
import { AssetUpdationForm } from "../../models/asset/UpdateAssetRequest";
import { updateAssetSchema } from "../../schemas/updateAssetSchema";
import AssetDetailsResponse from "../../models/asset/AssetDetailsResponse";
import dayjs from "dayjs";
import { states } from "../../utils/helper";

interface Props {
  handleUpdateAsset: (data: any) => void;
  assetToUpdate: AssetDetailsResponse;
}

const EditAssetForm = ({ handleUpdateAsset, assetToUpdate }: Props) => {
  //if user access this page without providing id
  if (!assetToUpdate)
    return (
      <div className="min-h-48 flex justify-center items-center">
        <Typography variant="h4" gutterBottom color={"#CF2338"}>
          No data found
        </Typography>
      </div>
    );

  const {
    handleSubmit,
    control,
    formState: { isValid, errors },
    setValue,
    getValues,
  } = useForm({
    resolver: yupResolver<AssetUpdationForm>(updateAssetSchema),
    defaultValues: {
      assetId: assetToUpdate.assetId,
      assetName: assetToUpdate.assetName,
      specification: assetToUpdate.specification,
      installedDate: dayjs(assetToUpdate.installedDate),
      state: assetToUpdate.state,
    },
    mode: "onChange",
  });

  const navigate = useNavigate();

  const handleChangeState = (newValue: string) => {
    setValue("state", newValue); // Update the form state with the new value
  };

  return (
    <div className="bg-white w-[35rem] mx-auto">
      <h2 className="text-2xl font-bold text-primary mb-5">Edit Asset</h2>
      <form onSubmit={handleSubmit(handleUpdateAsset)} className="space-y-6">
        <div>
          <div className="flex items-center gap-5 pl-2">
            <label className="w-[7rem]">Name</label>
            <Controller
              name="assetName"
              control={control}
              render={({ field }) => (
                <AppTextInput
                  {...field}
                  id="assetName"
                  control={control}
                  className="grow"
                  isApplyHelperText={false}
                  defaultValue={assetToUpdate.assetName}
                />
              )}
            />
          </div>
          {errors.assetName && (
            <div className="flex items-end justify-end">
              <span className="text-[#d32f2f] font-normal text-xs w-[410px] mt-1">
                {errors.assetName.message as string}
              </span>
            </div>
          )}
        </div>

        <div>
          <div className="flex items-center gap-5 pl-2">
            <label className="w-[7rem]">Category</label>
            <div className="grow">
              <FormControl fullWidth>
                <Select
                  defaultValue={assetToUpdate.categoryName}
                  size="small"
                  id="assetCategorySelection"
                  readOnly
                  disabled={true}
                >
                  <MenuItem value={assetToUpdate.categoryName}>
                    {assetToUpdate.categoryName}
                  </MenuItem>
                </Select>
              </FormControl>
            </div>
          </div>
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
                  defaultValue={assetToUpdate.specification}
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
                defaultValue={dayjs(assetToUpdate.installedDate)}
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
                  onChange={(e) => {
                    handleChangeState(e.target.value);
                  }}
                >
                  {states.map((key, idx) => (
                    <FormControlLabel
                      value={key.label}
                      id={idx.toString()}
                      control={
                        <Radio
                          checked={
                            key.label.toLowerCase() ===
                            getValues().state.toLowerCase()
                          }
                          sx={{ "&.Mui-checked": { color: "#cf2338" } }}
                        />
                      }
                      label={key.label}
                    />
                  ))}
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

export default EditAssetForm;
