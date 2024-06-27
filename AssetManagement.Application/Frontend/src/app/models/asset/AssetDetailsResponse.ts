interface AssignmentResponse {
  date: Date;
  assignedTo: string;
  assignedBy: string;
  returnedDate: Date;
}
interface AssetDetailsResponse {
  assetId: string;
  assetCode: string;
  assetName: string;
  categoryName: string;
  installedDate: Date;
  state: string;
  location: string;
  specification: string;
  assignments: Array<AssignmentResponse>;
}

export default AssetDetailsResponse;
