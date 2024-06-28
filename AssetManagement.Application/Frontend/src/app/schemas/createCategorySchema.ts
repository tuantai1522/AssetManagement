import yup from "../types/yupGlobal"

export const createCategorySchema = yup.object().shape({
    categoryName: yup.string()
        .max(100, 'Category name must not exceed 100 characters long')
        .required("Please enter category name")
        .categoryName('Name must contain only alphabet letters, numbers and white spaces'),
    categoryPrefix: yup.string()
        .max(10, 'Category prefix must not exceed 10 characters long')
        .required("Please enter category prefix")
        .categoryPrefix('Prefix must contain only alphabet letters and numbers'),
});