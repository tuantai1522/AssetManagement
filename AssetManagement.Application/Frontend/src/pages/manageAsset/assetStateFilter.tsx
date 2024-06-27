import AppSelectedInput from "../../app/components/AppSelectedInput";

const items = [
  { id: "Assigned", name: "Assigned" },
  { id: "Available", name: "Available" },
  { id: "NotAvailable", name: "Not available" },
  { id: "WaitingForRecycling", name: "Wating for recycling" },
  { id: "Recycled", name: "Recycled" },
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