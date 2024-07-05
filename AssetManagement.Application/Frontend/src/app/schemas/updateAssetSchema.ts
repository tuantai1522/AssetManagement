import yup from "../types/yupGlobal";

const today = new Date(new Date().setHours(0, 0, 0, 0));
const tomorrow = new Date(today);
tomorrow.setDate(today.getDate() + 1);

export const updateAssetSchema = yup.object().shape({
  assetId: yup.string().optional(),
  assetName: yup.string().required("Please enter asset's name"),
  specification: yup.string().required("Please enter asset's specification"),
  installedDate: yup
    .date()
    .typeError("Invalid Date Type")
    .required("Please enter the installed date")
    .max(tomorrow, "Can not select and input future date"),
  state: yup.string().required(),
});
