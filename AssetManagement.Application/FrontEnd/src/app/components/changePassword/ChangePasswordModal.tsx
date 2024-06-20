import { Controller, FieldValues, useForm } from "react-hook-form";
import AppPasswordInput from "../AppPasswordInput";
import Button from "../buttons/Button";
import * as yup from "yup";
import { yupResolver } from "@hookform/resolvers/yup";
import { useState } from "react";
import { ChangePasswordRequest } from "../../models/changePassword/ChangePasswordRequest";
import agent from "../../api/agent";
import { BaseResult } from "../../models/BaseResult";
import { User } from "../../models/User";

interface Props {
  user: User | null;
  isOpen: boolean;
  onClose: () => void;
}

interface FormValues extends FieldValues {
  oldPassword?: string;
  newPassword: string;
}

export default function ChangePasswordModal({ user, isOpen, onClose }: Props) {
  const [isSuccessed, setIsSuccessed] = useState<boolean | undefined>(
    undefined
  );

  //Validation
  const schema = yup.object().shape({
    oldPassword: !user?.isPasswordChanged
      ? yup.string().optional()
      : yup.string().required("Old password is required"),
    newPassword: yup.string().required("New password is required"),
  });

  const {
    control,
    handleSubmit,
    setError,
    formState: { isSubmitting, errors },
  } = useForm({
    resolver: yupResolver<FormValues>(schema),
    mode: "onSubmit",
  });

  async function onSubmit(data: FormValues) {
    try {
      debugger;
      if (!user) return;
      const requestData: ChangePasswordRequest = {
        NewPassword: data.newPassword,
        OldPassword: data.oldPassword || "",
        UserId: user.id,
      };
      const result: BaseResult<any> = await agent.Authentication.changePassword(
        requestData
      );
      if (result.isSuccess) {
        setIsSuccessed(true);
        if (!user.isPasswordChanged) {
          user.isPasswordChanged = true;
          localStorage.setItem("user", JSON.stringify(user));
        }
      }
    } catch (error: any) {
      console.log(error);
      if (!error.isSuccess) {
        setIsSuccessed(false);
        setError("oldPassword", {
          type: "validate",
          message: "Password is incorrect",
        });
      }
    }
  }

  const handleOnClose = () => {
    onClose();
    setIsSuccessed(undefined);
  };

  if (!isOpen) return null;

  return (
    <>
      <div className="fixed inset-0 flex items-center justify-center">
        <div className="absolute inset-0"></div>
        <div className="z-10 bg-white rounded-lg border border-black w-[32rem]">
          <div className="bg-slate-100 rounded-t-lg border-b border-black px-12 py-5">
            <h2 className="text-2xl font-bold text-primary">Change password</h2>
          </div>
          <form
            className="w-full h-full px-12 py-5"
            onSubmit={handleSubmit(onSubmit as any)}
          >
            {isSuccessed ? (
              <div className="flex items-center h-14 mb-6">
                <p className="font-normal">
                  Your password has been changed successfully!
                </p>
              </div>
            ) : (
              <div className="flex flex-col gap-2 mb-4">
                {!user?.isPasswordChanged ? (
                  <div className="font-normal">
                    <p>This is the first time you logged in.</p>
                    <p>You have to change your password to continue.</p>
                  </div>
                ) : (
                  <div className="flex justify-between items-center">
                    <label className="w-32 font-normal">Old password</label>
                    <Controller
                      name="oldPassword"
                      control={control}
                      render={({ field }) => (
                        <AppPasswordInput
                          {...field}
                          id="oldPassword"
                          control={control}
                          error={!!errors.oldPassword}
                          helperText={errors?.oldPassword?.message as string}
                        />
                      )}
                    />
                  </div>
                )}

                <div className="flex justify-between items-center">
                  <label className="w-32 font-normal">New password</label>
                  <Controller
                    name="newPassword"
                    control={control}
                    render={({ field }) => (
                      <AppPasswordInput
                        {...field}
                        id="newPassword"
                        control={control}
                        error={!!errors.newPassword}
                        helperText={errors?.newPassword?.message as string}
                      />
                    )}
                  />
                </div>
              </div>
            )}
            <div className="flex justify-end gap-6">
              {isSuccessed ? (
                <Button
                  styleType="secondary"
                  content="Close"
                  onClickOn={handleOnClose}
                />
              ) : (
                <>
                  {user?.isPasswordChanged && (
                    <>
                      <Button
                        styleType="secondary"
                        content="Cancel"
                        onClickOn={handleOnClose}
                      />
                    </>
                  )}
                  <Button
                    isLoading={isSubmitting}
                    content="Save"
                    isFormSubmit={true}
                  />
                </>
              )}
            </div>
          </form>
        </div>
      </div>
    </>
  );
}
