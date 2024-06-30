import { useLocation, useNavigate } from "react-router-dom";
import agent from "../../app/api/agent";
import { BaseResult } from "../../app/models/BaseResult";
import {
  AssetUpdationForm,
  AssetUpdationRequest,
} from "../../app/models/asset/UpdateAssetRequest";
import EditAssetForm from "../../app/components/forms/EditAssetForm";
import { states } from "../../app/utils/helper";

const EditAssetPage = () => {
  const navigate = useNavigate();
  const location = useLocation();

  const { assetToUpdate: data } = location.state || {}; // Default to empty object if state is undefined

  const handleSubmit = async (data: AssetUpdationForm) => {
    const idxState =
      states.findIndex(
        (x) => x.label.toUpperCase() === data.state.toUpperCase()
      ) + 1;

    data.state = idxState.toString();

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
      <EditAssetForm assetToUpdate={data} handleUpdateAsset={handleSubmit} />
    </div>
  );
};

export default EditAssetPage;
