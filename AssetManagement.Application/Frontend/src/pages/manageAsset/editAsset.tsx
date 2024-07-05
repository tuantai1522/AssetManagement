import { useLocation, useNavigate } from "react-router-dom";
import agent from "../../app/api/agent";
import { BaseResult } from "../../app/models/BaseResult";
import {
  AssetUpdationForm,
  AssetUpdationRequest,
} from "../../app/models/asset/UpdateAssetRequest";
import EditAssetForm from "../../app/components/forms/EditAssetForm";
import { states } from "../../app/utils/helper";
import { AssetState, FilterAssetRequest } from "../../app/models/asset/Asset";
import { off } from "process";

const EditAssetPage = () => {
  const navigate = useNavigate();
  const location = useLocation();

  const { assetToUpdate: data, currentStates } = location.state || {}; // Default to empty object if state is undefined
  const handleSubmit = async (data: AssetUpdationForm) => {
    const idxState =
      states.findIndex(
        (x) => x.label.toUpperCase() === data.state.toUpperCase()
      ) + 1;

    const valueToOrder = states.find(
      (x) => x.label.toUpperCase() === data.state.toUpperCase()
    );

    data.state = idxState.toString();

    const dataRequest: AssetUpdationRequest = {
      assetId: data.assetId,
      assetName: data.assetName,
      installedDate: data.installedDate,
      specification: data.specification,
      state: data.state,
    };

    const response: BaseResult<null> = await agent.Asset.update(dataRequest);

    const orderValue = valueToOrder?.label;
    const stateEnum = AssetState[orderValue as keyof typeof AssetState];
    //Update states
    if (currentStates.states && currentStates.states.length > 0)
      (currentStates as FilterAssetRequest).states!.push(stateEnum);

    if (response.isSuccess) {
      (currentStates as FilterAssetRequest).order = "desc";
      (currentStates as FilterAssetRequest).orderBy = "lastUpdate";
      (currentStates as FilterAssetRequest).pageNumber = 1;
      navigate("/manage-asset", {
        state: {
          currentStates: currentStates,
        },
      });
    }
  };

  return (
    <div>
      <EditAssetForm assetToUpdate={data} handleUpdateAsset={handleSubmit} />
    </div>
  );
};

export default EditAssetPage;
