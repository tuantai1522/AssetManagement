import yup from "../types/yupGlobal";

export const createAssetSchema = yup.object().shape({
  name: yup.string().required("Please enter asset's name"),
  categoryId: yup.string().required("Please select a category"),
  specification: yup.string().required("Please enter asset's specification"),
  installedDate: yup.date().typeError("Invalid Date Type").required("Please enter the installed date"),
  state: yup.number().required(),
});
