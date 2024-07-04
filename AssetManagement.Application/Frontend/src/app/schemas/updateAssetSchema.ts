import yup from "../types/yupGlobal";

export const updateAssetSchema = yup.object().shape({
  assetId: yup.string().optional(),
  assetName: yup.string().required("Please enter asset's name"),
  specification: yup.string().required("Please enter asset's specification"),
  installedDate: yup
    .date()
    .typeError("Invalid Date Type")
    .required("Please enter the installed date")
    .max(new Date(), "Can not select and input future date"),
  state: yup.string().required(),
});
