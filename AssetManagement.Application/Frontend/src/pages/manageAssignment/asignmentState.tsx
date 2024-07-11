import AppSelectedInput from "../../app/components/AppSelectedInput";
import { AssignmentStateEnum } from "../../app/types/enum";

const items = [
    { id: AssignmentStateEnum[AssignmentStateEnum.Accepted], name: "Accepted" },
    { id: AssignmentStateEnum[AssignmentStateEnum["Waiting for acceptance"]], name: "Waiting for acceptance" },
    { id: AssignmentStateEnum[AssignmentStateEnum.Declined], name: "Declined" },
    { id: AssignmentStateEnum[AssignmentStateEnum["Waiting for returning"]], name: "Waiting for returning" },
];

export interface AssignmentStateFilterProp {
    states?: string[],
    setStates: (data?: any) => void,
    onSubmit: () => void
}

function AssignmentStateFilter(props: AssignmentStateFilterProp) {
    const onChangeSelectedBox = (checkedItems: string[]) => {
        props.setStates(checkedItems);
    };

    return (
        <AppSelectedInput
            sx={{ marginLeft: 60 }}
            onSubmit={props.onSubmit}
            checked={props.states}
            name="State"
            items={items}
            onChangeSelectedBox={onChangeSelectedBox}
        />
    );
};

export default AssignmentStateFilter;