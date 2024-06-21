import { useNavigate, useParams } from "react-router-dom";
import UserForm from "../../app/components/forms/userForm";
import agent from "../../app/api/agent";
import { EditUserRequest } from "../../app/models/request/EditUserRequest";

const EditUserPage = () => {
    const { id } = useParams();
    const navigate = useNavigate();
    if (!id) {
        navigate('/not-found');
        return null; 
    }

    const { data,  error, isLoading } = agent.Users.details(id);
    
    const onSubmit = (formData: any) => {
        const updateData: EditUserRequest = {
            dateOfBirth: formData.dateOfBirth,
            joinedDate: formData.joinedDate,
            gender: formData.type,
            type: formData.gender,
        }
        agent.Users.update(id, formData);
    }

    if (isLoading) {
        return <div>Loading...</div>; // Display a loading state
    }

    if (error) {
        console.error(error);
        return <div>Error loading user data</div>; // Display an error state
    }

    if (!data || !data.result) {
        console.error('Unexpected data format:', data);
        return <div>Error: Unexpected data format</div>;
    }

    return (
        <UserForm 
            onSubmit={onSubmit} 
            isEditing={true} 
            data={data.result} 
        />
    );
}

export default EditUserPage;
