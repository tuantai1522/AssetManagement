import { useNavigate, useParams } from "react-router-dom";
import UserForm from "../../app/components/forms/UserForm";
import agent from "../../app/api/agent";
import { EditUserRequest } from "../../app/models/user/EditUserRequest";
import dayjs from "dayjs";
import { UserEditForm } from "../../app/models/user/UserCreateForm";
import AppLoader from "../../app/components/AppLoader";
import { UserInfoResponse } from "../../app/models/login/UserInfoResponse";


const EditUserPage = () => {
    const { id } = useParams();
    const navigate = useNavigate();
    
    if (!id) {
        navigate('/not-found');
        return null; 
    }

    const { data, isLoading } = agent.Users.details(id);
    const userData: UserInfoResponse = data?.result;
    
    const onSubmit = async (formData: UserEditForm) => {
        // Format the dates to 'YYYY-MM-DD'
        const formattedDateOfBirth = dayjs(formData.dateOfBirth).format('YYYY-MM-DD');
        const formattedJoinedDate = dayjs(formData.joinedDate).format('YYYY-MM-DD');

        const updateData: EditUserRequest = {
            DateOfBirth: formattedDateOfBirth,
            JoinedDate: formattedJoinedDate,
            Gender: formData.gender,
            Type: formData.type,
        }
        await agent.Users.update(id, updateData);
        navigate('/manage-user', {state: {passedOrder: "desc", passedOrderBy: "lastUpdate"}});
    }

    if (isLoading) {
        return (
            <div className="flex items-center justify-center">
                <AppLoader />
            </div>
        )
    }

    return (
        <UserForm 
            onSubmit={onSubmit} 
            isEditing={true} 
            data={userData} 
            />
    );
}

export default EditUserPage;
