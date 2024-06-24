import { useNavigate } from "react-router-dom";
import agent from "../../app/api/agent";
import UserForm from "../../app/components/forms/userForm";
import { CreateUserRequest } from "../../app/models/login/CreateUserRequest";

const CreateUserPage = () => {
    const navigate = useNavigate();
    const onSubmit = async (formData: any) => {
        const createData: CreateUserRequest = {
            FirstName: formData.firstName,
            LastName: formData.lastName,
            DateOfBirth: formData.dateOfBirth,
            JoinedDate: formData.joinedDate,
            Gender: formData.gender,
            Type: formData.type,
        }
        await agent.Users.create(createData);
        navigate('/manage-user');
    }

    return <UserForm onSubmit={onSubmit} />;
}

export default CreateUserPage
