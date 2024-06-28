import { FieldValues } from "react-hook-form";

export interface CategoryCreateForm extends FieldValues {
    categoryName: string,
    categoryPrefix: string,
}