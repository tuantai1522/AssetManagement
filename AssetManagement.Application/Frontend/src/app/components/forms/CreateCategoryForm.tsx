import { yupResolver } from "@hookform/resolvers/yup";
import { useState } from "react";
import { Controller, useForm } from "react-hook-form";
import { createCategorySchema } from "../../schemas/createCategorySchema";
import AppTextInput from "../AppTextInput";
import { CategoryCreateForm } from "../../models/category/CategoryCreateForm";
import CheckIcon from "@mui/icons-material/Check";
import CloseIcon from "@mui/icons-material/Close";
import agent from "../../api/agent";
import { CreateCategoryRequest } from "../../models/category/CreateCategoryRequest";

interface Props {
  refetchCategories: () => void;
}

const CreateCategoryForm = ({ refetchCategories }: Props) => {
  const {
    handleSubmit,
    control,
    reset,
    formState: { errors },
    getValues,
  } = useForm({
    resolver: yupResolver<CategoryCreateForm>(createCategorySchema),
    defaultValues: {},
    mode: "all",
  });

  const [isFormVisible, setIsFormVisible] = useState(false);
  const [isSubmitting, setIsSubmitting] = useState(false);

  const onSubmit = async (formData: any) => {
    setIsSubmitting(true);
    const request: CreateCategoryRequest = {
      name: formData.categoryName,
      prefix: formData.categoryPrefix.toUpperCase(),
    };
    await agent.Category.create(request)
      .then(() => {
        reset();
        setIsFormVisible(false);
        refetchCategories();
      })
      .catch((error: any) => {
        console.log(error);
      })
      .finally(() => {
        setIsSubmitting(false);
      });
  };

  return (
    <>
      {!isFormVisible ? (
        <>
          <button
            type="button"
            id="openNewCategoryForm"
            className="mx-4 italic hover:underline"
            onClick={() => setIsFormVisible(true)}
          >
            Add new category
          </button>
        </>
      ) : (
        <>
          <form className="mx-4">
            <div className="flex flex-row gap-x-3">
              <Controller
                name="categoryName"
                control={control}
                render={({ field }) => (
                  <AppTextInput
                    {...field}
                    id="categoryName"
                    control={control}
                    className="grow italic"
                    isApplyHelperText={false}
                    placeholder="Name"
                    disabled={isSubmitting}
                    onKeyDown={(e: { stopPropagation: () => any }) => {
                      if (isFormVisible) {
                        console.log("hehe");
                        e.stopPropagation();
                      }
                    }}
                  />
                )}
              />
              <Controller
                name="categoryPrefix"
                control={control}
                render={({ field }) => (
                  <AppTextInput
                    {...field}
                    id="categoryPrefix"
                    control={control}
                    className="w-20 italic"
                    isApplyHelperText={false}
                    placeholder="Prefix"
                    disabled={isSubmitting}
                    value={getValues().categoryPrefix?.toUpperCase()}
                    onKeyDown={(e: { stopPropagation: () => any }) => {
                      if (isFormVisible) {
                        console.log("hehe");
                        e.stopPropagation();
                      }
                    }}
                  />
                )}
              />
              <button
                id="newCategorySubmit"
                type="button"
                onClick={handleSubmit(onSubmit)}
                className="text-primary"
                disabled={isSubmitting}
              >
                <CheckIcon />
              </button>
              <button
                id="newCategoryCancel"
                type="button"
                disabled={isSubmitting}
                onClick={() => {
                  reset();
                  setIsFormVisible(false);
                }}
              >
                <CloseIcon />
              </button>
            </div>
            <div>
              {errors.categoryName && (
                <div className="flex items-end justify-end">
                  <span className="text-[#d32f2f] font-normal text-xs w-full mt-1">
                    {errors.categoryName.message as string}
                  </span>
                </div>
              )}
              {errors.categoryPrefix && (
                <div className="flex items-end justify-end">
                  <span className="text-[#d32f2f] font-normal text-xs w-full mt-1">
                    {errors.categoryPrefix.message as string}
                  </span>
                </div>
              )}
            </div>
          </form>
        </>
      )}
    </>
  );
};

export default CreateCategoryForm;
