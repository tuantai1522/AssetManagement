import CreateAssignmentForm from "../../app/components/forms/CreateAssignmentForm";
import {
  AssignmentCreationForm,
  AssignmentCreationRequest,
} from "../../app/models/assignment/AssignmentCreationRequest";

export default function CreateAssignment() {
  const handleSubmit = async (data: AssignmentCreationForm) => {
    const dataRequest: AssignmentCreationRequest = {
      assetId: data.assetId,
      assignedDate: data.assignedDate,
      note: data.note,
      userId: data.userId,
    };
    console.log("Data request for create assignment: ", dataRequest);
  };

  return <CreateAssignmentForm handleCreateAssignment={handleSubmit} />;
}
