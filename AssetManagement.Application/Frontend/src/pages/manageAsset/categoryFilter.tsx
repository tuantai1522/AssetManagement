import AppSelectedInput from "../../app/components/AppSelectedInput";
import SelectedItem from "../../app/models/SelectedItem";
import { AssetState } from "../../app/models/asset/Asset";

// const items = [
//   { id: AssetState[AssetState.Assigned], name: "Assigned" },
//   { id: AssetState[AssetState.Available], name: "Available" },
//   { id: AssetState[AssetState["Not Available"]], name: "Not available" },
//   { id: AssetState[AssetState["Waiting For Recycling"]], name: "Wating for recycling" },
//   { id: AssetState[AssetState.Recycled], name: "Recycled" },
// ];

export interface CategoryFilterProp {
    items: SelectedItem[],
    categories?: string[],
    setcategories: (data?: any) => void,
    onSubmit: () => void
}

function CategoryFilter(props: CategoryFilterProp) {
    const onChangeSelectedBox = (checkedItems: string[]) => {
        props.setcategories(checkedItems);
    };

    return (
        <>
            <AppSelectedInput
                sx={{ marginLeft: 60 }}
                onSubmit={props.onSubmit}
                checked={props.categories}
                name="Category"
                items={props.items}
                onChangeSelectedBox={onChangeSelectedBox}
            />
        </>
    );
};

export default CategoryFilter;