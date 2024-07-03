import React from "react";
import CreateAssignmentForm from "../../../app/components/forms/CreateAssignmentForm";
import { useNavigate } from "react-router-dom";
import agent from "../../../app/api/agent";
import { BaseResult } from "../../../app/models/BaseResult";
import {
  AssignmentCreationForm,
  AssignmentCreationRequest,
} from "../../../app/models/assignment/AssignmentCreationRequest";

const CreateAssignmentPage = () => {
  const navigate = useNavigate();

  const handleSubmit = async (data: AssignmentCreationForm) => {
    const dataRequest: AssignmentCreationRequest = {
      assetId: data.assetId,
      assignedDate: data.assignedDate,
      note: data.note,
      userId: data.userId,
    };
    const response: BaseResult<null> = await agent.Assignment.create(
      dataRequest
    );
    if (response.isSuccess) {
      navigate("/manage-assignment", {
        state: { passedOrder: "desc", passedOrderBy: "lastUpdate" },
      });
    }
  };
  return (
    <div className="h-screen">
      <CreateAssignmentForm handleCreateAssignment={handleSubmit} />
    </div>
  );
};

export default CreateAssignmentPage;
