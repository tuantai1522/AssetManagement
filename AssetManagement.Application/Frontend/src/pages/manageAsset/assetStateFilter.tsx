import AppSelectedInput from "../../app/components/AppSelectedInput";

const items = [
  { id: "All", name: "All" },
  { id: "assigned", name: "Assigned" },
  { id: "available", name: "Available" },
  { id: "notAvailable", name: "Not available" },
  { id: "watingForRecycling", name: "Wating for recycling" },
  { id: "recycled", name: "Recycled" },
];

export interface AssetStateFilterProp {
    states?: string[],
    setStates: (data?: any) => void,
    onSubmit: () => void
}

function AssetStateFilter (props: AssetStateFilterProp) {
  const onChangeSelectedBox = (checkedItems: string[]) => {
    props.setStates(checkedItems);
  };

  return (
    <>
      <AppSelectedInput
        sx={{ marginLeft: 60 }}
        onSubmit={props.onSubmit}
        checked={props.states}
        name="states"
        items={items}
        onChangeSelectedBox={onChangeSelectedBox}
      />
    </>
  );
};

export default AssetStateFilter;