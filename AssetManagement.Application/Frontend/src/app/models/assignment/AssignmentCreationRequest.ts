import { FieldValues } from "react-hook-form";

export interface AssignmentCreationRequest{
    userId: string,
    assetId: string,
    assignedDate: Date,
    note: string
}

export interface AssignmentCreationForm extends AssignmentCreationRequest, FieldValues {}
