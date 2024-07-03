import React from 'react';
import CreateAssignmentForm from '../../../app/components/forms/CreateAssignmentForm';

const CreateAssignmentPage = () => {
    const handleCreateAssignment = () => {
        console.log(1);
    }
    return (
        <div className="h-screen">
            <CreateAssignmentForm handleCreateAssignment={handleCreateAssignment}  />
        </div>
    );
};

export default CreateAssignmentPage;