import AppSelectedInput from "../../../app/components/AppSelectedInput";

const items = [
  { id: "All", name: "All" },
  { id: "Admin", name: "Admin" },
  { id: "Staff", name: "Staff" },
];

export interface UserTypeOption {
    types?: string[],
    setTypes: (data?: any) => void,
    onSubmit: () => void
}

function UserType (props: UserTypeOption) {
  const onChangeSelectedBox = (checkedItems: string[]) => {
    props.setTypes(checkedItems);
  };

  return (
    <>
      <AppSelectedInput
        sx={{ marginLeft: 60 }}
        onSubmit={props.onSubmit}
        checked={props.types}
        name="Type"
        items={items}
        onChangeSelectedBox={onChangeSelectedBox}
      />
    </>
  );
};

export default UserType;