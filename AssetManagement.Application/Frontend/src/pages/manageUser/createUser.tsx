import UserForm from "../../app/components/forms/userForm";

const CreateUserPage = () => {
    const onSubmit = (data: any) => {
        console.log(data);
    }

    return <UserForm onSubmit={onSubmit} />;
}

export default CreateUserPage