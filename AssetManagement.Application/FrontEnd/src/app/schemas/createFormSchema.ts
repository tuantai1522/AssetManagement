import { Gender, Type } from "../types/enum";
import yup from "../types/yupGlobal"


export const createFormSchema = yup.object().shape({
    firstName: yup.string()
        .max(10, 'Must not exceed 10 characters long')
        .required("Please Type First Name")
        .firstName('First name must be a single word containing only alphabet letters'),
    lastName: yup.string()
        .max(30, 'Must not exceed 30 characters long')
        .required("Please Type Last Name")
        .lastName('Last name must contain only alphabet letters and spaces'),
    dateOfBirth: yup.date()
        .typeError("Invalid Date Type")
        .required("Please Select Date of Birth")
        .olderThan18('User is under 18. Please select a\ndifferent date'),
    joinedDate: yup.date()
        .required("Please Select Joined Date")
        .typeError("Invalid Date Type")
        .afterDoB('dateOfBirth', 'User under the age of 18 may not join\ncompany. Please select a different date')
        .notWeekend('Joined date is Saturday or Sunday.\nPlease select a different date'),
    gender: yup
        .mixed<Gender>()
        .defined(),
    type: yup
        .mixed<Type>()
        .required('Please Select Type')
});