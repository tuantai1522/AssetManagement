import { FieldValues } from "react-hook-form";

export interface UserCreateForm extends FieldValues {
    firstName: string,
    lastName: string,
    dateOfBirth: Date,
    joinedDate: Date,
    gender: string,
    type: string,
}

export interface UserEditForm extends UserCreateForm {}