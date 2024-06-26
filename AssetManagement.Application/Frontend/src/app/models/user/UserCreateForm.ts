import { FieldValues } from "react-hook-form";

export interface UserCreateRequest {
    firstName: string,
    lastName: string,
    dateOfBirth: Date,
    joinedDate: Date,
    gender: string,
    type: string,
}

export interface UserCreateForm extends UserCreateRequest, FieldValues { }
export interface UserEditForm extends UserCreateRequest, FieldValues {}