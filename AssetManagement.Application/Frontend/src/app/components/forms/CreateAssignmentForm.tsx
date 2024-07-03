import { yupResolver } from "@hookform/resolvers/yup";
import { Controller, useForm } from "react-hook-form";
import { createAssignmentSchema } from "../../schemas/createAssignmentSchema";
import { AssignmentCreationForm } from "../../models/assignment/AssignmentCreationRequest";
import { useNavigate } from "react-router-dom";
import AppTextInput from "../AppTextInput";
import { DatePicker, LocalizationProvider } from "@mui/x-date-pickers";
import { AdapterDayjs } from "@mui/x-date-pickers/AdapterDayjs";
import AppButton from "../buttons/Button";
import { FilterUser } from "../../models/user/User";
import { FilterAssetResponse } from "../../models/asset/Asset";
import { Search } from "@mui/icons-material";
import { InputAdornment } from "@mui/material";
import dayjs from "dayjs";
import { useEffect, useState } from "react";
import UserModal from "../../../pages/manageAssignment/createAssignment/userModal";
import AssetModal from "../../../pages/manageAssignment/createAssignment/assetModal";

interface Props {
  handleCreateAssignment: (data: any) => void;
}
export default function CreateAssignmentForm({
  handleCreateAssignment,
}: Props) {
  const {
    handleSubmit,
    control,
    setValue,
    getValues,
    trigger,
    formState: { isValid, errors },
  } = useForm({
    resolver: yupResolver<AssignmentCreationForm>(createAssignmentSchema),
    mode: "all",
  });
  const navigate = useNavigate();

  useEffect(() => {
    setValue("assignedDate", dayjs(new Date()));
  }, []);

  const handleSelectUser = (user: FilterUser) => {
    setValue("userId", user?.id);
  };

  const handleSelectAsset = (asset: FilterAssetResponse) => {
    setValue("assetId", asset?.id);
  };

  const [selectedUserValue, setSelectedUserValue] = useState<
  FilterUser | undefined
  >(undefined);
  const [isOpenUserSelection, setIsOpenUserSelection] = useState<boolean>(false);

  console.log(selectedUserValue);

  const [selectedAssetValue, setSelectedAssetValue] = useState<
  FilterAssetResponse | undefined
>(undefined);
  const [isOpenAssetSelection, setIsOpenAssetSelection] = useState<boolean>(false);

  const handleCancelAssetModal = () => {
    setIsOpenAssetSelection(false);
    setSelectedAssetValue(undefined);
  }

  const handleCancelUserModal = () => {
    setIsOpenUserSelection(false);
    setSelectedUserValue(undefined);
  }

  return (
    <div className="bg-white w-[35rem]">
      <h2 className="text-2xl font-bold text-primary mb-5">
        Create New Assignment
      </h2>
      <form
        onSubmit={handleSubmit(handleCreateAssignment)}
        className="space-y-6"
      >
        <div>
          <div className="flex items-center gap-5 cursor-pointer">
            <label className="w-[7rem]">User</label>
            <div className="relative grow flex" onClick={() => setIsOpenUserSelection(true)}>
              <Controller
                name="user"
                control={control}
                render={({ field }) => (
                  <AppTextInput
                    {...field}
                    id="user"
                    control={control}
                    className="grow cursor-none"
                    isApplyHelperText={false}
                    InputProps={{
                      readOnly: true,
                      endAdornment: (
                        <InputAdornment position="end">
                          <Search className="mx-0" />
                        </InputAdornment>
                      ),
                    }}
                  />
                )}
              />
              {isOpenUserSelection &&
                <UserModal style={"top-0"} selectedValue={selectedUserValue} setSelectedValue={(value) =>{setSelectedUserValue(value)}} onClickCancel={handleCancelUserModal} onClickSave={() => setIsOpenUserSelection(false)}/>
              }
            </div>
          </div>
          {errors.user && (
            <div className="flex items-end justify-end">
              <span className="text-[#d32f2f] font-normal text-xs w-[420px] mt-1">
                {errors.user.message as string}
              </span>
            </div>
          )}
        </div>

        <div>
          <div className="flex items-center gap-5">
            <label className="w-[7rem]">Asset</label>
            <div className="relative grow flex" onClick={() => setIsOpenAssetSelection(true)}>
              <Controller
                name="asset"
                control={control}
                render={({ field }) => (
                  <>
                    <AppTextInput
                      {...field}
                      id="asset"
                      control={control}
                      className="grow"
                      isApplyHelperText={false}
                      InputProps={{
                        readOnly: true,
                        endAdornment: (
                          <InputAdornment position="end">
                            <Search className="mx-0" />
                          </InputAdornment>
                        ),
                      }}
                    />
                  </>
                )}
              />
              {isOpenAssetSelection &&
                <AssetModal style={"top-0"} selectedValue={selectedAssetValue} setSelectedValue={(value) =>{setSelectedAssetValue(value)}} onClickCancel={handleCancelAssetModal} onClickSave={() => setIsOpenAssetSelection(false)}/>
              }
            </div>
          </div>
          {errors.asset && (
            <div className="flex items-end justify-end">
              <span className="text-[#d32f2f] font-normal text-xs w-[420px] mt-1">
                {errors.asset.message as string}
              </span>
            </div>
          )}
        </div>
        <div>
          <div className="flex items-center gap-5">
            <label className="w-[7rem]">Assigned Date</label>
            <LocalizationProvider dateAdapter={AdapterDayjs}>
              <Controller
                control={control}
                name="assignedDate"
                render={({ field, fieldState: { error } }) => (
                  <DatePicker
                    {...field}
                    format="DD/MM/YYYY"
                    disablePast
                    onChange={(date) => {
                      field.onChange(date);
                      if (!!getValues("assignedDate")) trigger("assignedDate");
                    }}
                    className="grow"
                    slotProps={{
                      textField: {
                        size: "small",
                        id: "assignmentAsignedDate",
                      },
                    }}
                  />
                )}
              />
            </LocalizationProvider>
          </div>
          {errors.installedDate && (
            <div className="flex items-end justify-end">
              <span className="text-[#d32f2f] font-normal text-xs w-[420px] mt-1">
                {errors.installedDate.message as string}
              </span>
            </div>
          )}
        </div>
        <div>
          <div className="flex items-center gap-5">
            <label className="w-[7rem]">Note</label>
            <Controller
              name="note"
              control={control}
              render={({ field }) => (
                <AppTextInput
                  {...field}
                  id="note"
                  control={control}
                  className="grow"
                  isApplyHelperText={false}
                />
              )}
            />
          </div>
          {errors.note && (
            <div className="flex items-end justify-end">
              <span className="text-[#d32f2f] font-normal text-xs w-[420px] mt-1">
                {errors.note.message as string}
              </span>
            </div>
          )}
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
}
