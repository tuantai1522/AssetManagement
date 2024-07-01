import { useLocation, useNavigate } from "react-router-dom";
import agent from "../../app/api/agent";
import UserForm from "../../app/components/forms/UserForm";
import { CreateUserRequest } from "../../app/models/user/CreateUserRequest";
import { UserInfoResponse } from "../../app/models/login/UserInfoResponse";
import { BaseResult } from "../../app/models/BaseResult";
import dayjs from "dayjs";
import { UserCreateForm } from "../../app/models/user/UserCreateForm";

const CreateUserPage = () => {
    const navigate = useNavigate();
    const location = useLocation();

    const onSubmit = async (formData: UserCreateForm) => {
        // Format the dates to 'YYYY-MM-DD'
        const formattedDateOfBirth = dayjs(formData.dateOfBirth).format('YYYY-MM-DD');
        const formattedJoinedDate = dayjs(formData.joinedDate).format('YYYY-MM-DD');
        
        const createData: CreateUserRequest = {
            FirstName: formData.firstName,
            LastName: formData.lastName,
            DateOfBirth: formattedDateOfBirth,
            JoinedDate: formattedJoinedDate,
            Gender: formData.gender,
            Type: formData.type,
        }
        const response: BaseResult<UserInfoResponse> = await agent.Users.create(createData);
        navigate('/manage-user', {state: {passedOrder: "desc", passedOrderBy: "lastUpdate"}});
    }

    return <UserForm
        onSubmit={onSubmit}
    />;
}

export default CreateUserPage
