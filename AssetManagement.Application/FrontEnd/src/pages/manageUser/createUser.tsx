import yup from "./yupGlobal"

const schema = yup.object().shape({
    firstName: yup.string()
        .required("Please Type First Name")
        .firstName('First name must be a single word containing only alphabet letters'),
    lastName: yup.string()
        .required("Please Type Last Name")
        .lastName('Last name must contain only alphabet letters and spaces'),
    dateOfBirth: yup.date()
        .required("Please Select Date of Birth")
        .olderThan(18, 'User is under 18. Please select a\ndifferent date'),
    joinedDate: yup.date()
        .required("Please Select Joined Date")
        .afterDoB('dateOfBirth', 'User under the age of 18 may not join\ncompany. Please select a different date')
        .notWeekend('Joined date is Saturday or Sunday.\nPlease select a different date'),
});