import { useNavigate } from "react-router-dom";
import agent from "../../app/api/agent";
import { BaseResult } from "../../app/models/BaseResult";
import {
  AssetUpdationForm,
  AssetUpdationRequest,
} from "../../app/models/asset/UpdateAssetRequest";
import UpdateAssetForm from "../../app/components/forms/UpdateAssetForm";
import AssetDetailsResponse from "../../app/models/asset/AssetDetailsResponse";

const fakeData: AssetDetailsResponse = {
  assetId: "db2f356e-6a9c-4279-ab8d-fa8b22d77194",
  assetCode: "456",
  assetName: "Macbook Pro 2024",
  assignments: [],
  categoryName: "Personal computer",
  installedDate: new Date("2024-08-09"),
  location: "HCM",
  specification: "Macbook for adults",
  state: "Available",
};
const UpdateAssetPage = () => {
  const navigate = useNavigate();

  const handleSubmit = async (data: AssetUpdationForm) => {
    const dataRequest: AssetUpdationRequest = {
      assetId: data.assetId,
      assetName: data.assetName,
      installedDate: data.installedDate,
      specification: data.specification,
      state: data.state,
    };

    const response: BaseResult<null> = await agent.Asset.update(dataRequest);

    console.log(response);

    if (response.isSuccess) {
      navigate(
        `/manage-asset?passedOrderBy=${encodeURIComponent(
          "lastUpdate"
        )}&passedOrder=${encodeURIComponent("desc")}`
      );
    }
  };

  return (
    <div>
      <UpdateAssetForm
        assetToUpdate={fakeData}
        handleUpdateAsset={handleSubmit}
      />
    </div>
  );
};

export default UpdateAssetPage;
