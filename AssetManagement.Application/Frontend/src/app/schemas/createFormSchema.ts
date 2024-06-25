import yup from "../types/yupGlobal"


export const createFormSchema = yup.object().shape({
    firstName: yup.string()
        .max(50, 'Must not exceed 50 characters long')
        .required("Please Type First Name")
        .firstName('First name must be a single word containing only alphabet letters'),
    lastName: yup.string()
        .max(100, 'Must not exceed 100 characters long')
        .required("Please Type Last Name")
        .lastName('Last name must contain only alphabet letters and spaces'),
    dateOfBirth: yup.date()
        .typeError("Invalid Date Type")
        .required("Please Select Date of Birth")
        .olderThan18('User is under 18. Please select a\ndifferent date'),
    joinedDate: yup.date()
        .required("Please Select Joined Date")
        .typeError("Invalid Date Type")
        .requireDoB('dateOfBirth', "Please Select Date of Birth First")
        .afterDoB('dateOfBirth', 'User under the age of 18 may not join\ncompany. Please select a different date')
        .notWeekend('Joined date is Saturday or Sunday.\nPlease select a different date'),
    gender: yup
        .string()
        .defined(),
    type: yup
        .string()
        .required('Please Select Type')
});