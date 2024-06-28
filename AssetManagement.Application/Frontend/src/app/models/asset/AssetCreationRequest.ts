import { FieldValues } from "react-hook-form";
import { AssetStateEnum } from "../../types/enum";

export interface AssetCreationRequest {
    name: string,
    categoryId: string,
    specification: string,
    installedDate: Date,
    state: AssetStateEnum
}

export interface AssetCreationForm extends AssetCreationRequest, FieldValues {}
