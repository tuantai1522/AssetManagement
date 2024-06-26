import React from 'react';
import { useNavigate } from 'react-router-dom';
import CreateAssetForm from '../../app/components/forms/CreateAssetForm';

const CreateAssetPage = () => {
    const navigate = useNavigate();

    const handleSubmit = (values: any) => {
        console.log("values", values);
    }


    return (
        <div>
            <CreateAssetForm handleCreateAsset={handleSubmit}></CreateAssetForm>
        </div>
    );
};

export default CreateAssetPage;