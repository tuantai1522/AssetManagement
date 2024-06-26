import { FieldValues } from "react-hook-form";

export interface AssetCreationRequest {
    name: string,
    categoryId: string,
    specification: string,
    installedDate: Date,
    state: string
}

export interface AssetCreationForm extends AssetCreationRequest, FieldValues {}