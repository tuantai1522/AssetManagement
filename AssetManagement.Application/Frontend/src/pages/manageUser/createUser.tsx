import { useNavigate, useSearchParams } from "react-router-dom";
import agent from "../../app/api/agent";
import UserForm from "../../app/components/forms/userForm";
import { CreateUserRequest } from "../../app/models/login/CreateUserRequest";
import { UserInfoResponse } from "../../app/models/login/UserInfoResponse";
import { BaseResult } from "../../app/models/BaseResult";
import dayjs from "dayjs";

const CreateUserPage = () => {
    const navigate = useNavigate();
    const [searchParams] = useSearchParams();
    const callbackUrl = searchParams.get('callbackUrl') ?? undefined; // Retrieve the callback URL

    const onSubmit = async (formData: any) => {
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
        navigate(`/manage-user?passedOrderBy=${encodeURIComponent('lastUpdate')}&passedOrderBy=${encodeURIComponent('desc')}`);
    }

    return <UserForm
        onSubmit={onSubmit}
        callbackUrl={callbackUrl}
    />;
}

export default CreateUserPage
