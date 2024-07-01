import AppSelectedInput from "../../app/components/AppSelectedInput";
import { AssetState } from "../../app/models/asset/Asset";

const items = [
  { id: AssetState[AssetState.Assigned], name: "Assigned" },
  { id: AssetState[AssetState.Available], name: "Available" },
  { id: AssetState[AssetState["Not available"]], name: "Not available" },
  { id: AssetState[AssetState["Waiting for recycling"]], name: "Wating for recycling" },
  { id: AssetState[AssetState.Recycled], name: "Recycled" },
];

export interface AssetStateFilterProp {
  states?: string[],
  setStates: (data?: any) => void,
  onSubmit: () => void
}

function AssetStateFilter(props: AssetStateFilterProp) {
  const onChangeSelectedBox = (checkedItems: string[]) => {
    props.setStates(checkedItems);
  };

  return (
    <>
      <AppSelectedInput
        sx={{ marginLeft: 60 }}
        onSubmit={props.onSubmit}
        checked={props.states}
        name="State"
        items={items}
        onChangeSelectedBox={onChangeSelectedBox}
      />
    </>
  );
};

export default AssetStateFilter;