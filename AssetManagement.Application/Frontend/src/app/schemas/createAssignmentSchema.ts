import yup from "../types/yupGlobal";

export const createAssignmentSchema = yup.object().shape({
  userId: yup.string().required("Please select a user to assigned."),
  user: yup.object().required("Please select a user to assigned."),
  assetId: yup.string().required("Please select a asset to assigned."),
  asset: yup.object().required("Please select a asset to assigned."),
  assignedDate: yup.date().typeError("Invalid Date Type").min(new Date(new Date().setHours(0,0,0,0)), 'The date must not be in the past.').required("Please input the assigned date."),
  note: yup.string().required("Please write the note."),
});
