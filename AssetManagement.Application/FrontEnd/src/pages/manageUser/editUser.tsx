import { useParams } from "react-router-dom";
import UserForm from "../../app/components/forms/userForm";

const EditUserPage = () => {
    const { id } = useParams();
    const onSubmit = (data: any) => {
        console.log(data);
    }

    return <UserForm onSubmit={onSubmit} isEditing={true} isFirstNameDisabled={true} isLastNameDisabled={true} />;
}

export default EditUserPage