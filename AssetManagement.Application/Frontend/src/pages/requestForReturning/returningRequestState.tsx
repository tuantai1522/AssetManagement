import AppSelectedInput from "../../app/components/AppSelectedInput";
import { ReturningRequestStateEnum } from "../../app/types/enum";

const items = [
    { id: ReturningRequestStateEnum[ReturningRequestStateEnum.Completed], name: "Completed" },
    { id: ReturningRequestStateEnum[ReturningRequestStateEnum["Waiting for returning"]], name: "Waiting for returning" },
];

export interface Props {
    states?: string[],
    setStates: (data?: any) => void,
    onSubmit: () => void
}

const ReturningRequestState = (props: Props) => {
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

export default ReturningRequestState;