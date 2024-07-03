import { FieldValues } from "react-hook-form";

export interface AssetUpdationRequest {
  assetId?: string;
  assetName: string;
  specification: string;
  installedDate: Date;
  state: string;
}

export interface AssetUpdationForm extends AssetUpdationRequest, FieldValues {}
