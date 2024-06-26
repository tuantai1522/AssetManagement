import React from "react";
import { useNavigate } from "react-router-dom";
import CreateAssetForm from "../../app/components/forms/CreateAssetForm";
import { Category } from "../../app/models/category/Category";

const CreateAssetPage = () => {
  const handleSubmit = (values: any) => {
    console.log("values", values);
  };

  const categoryData: Category[] = [
    {
      id: "1",
      name: "Laptop",
      prefix: "LA",
    },
    {
      id: "2",
      name: "Computer",
      prefix: "C",
    },
    {
      id: "3",
      name: "Phone",
      prefix: "P",
    },
  ];
  return (
    <div>
      <CreateAssetForm
        handleCreateAsset={handleSubmit}
        categories={categoryData}
      />
    </div>
  );
};

export default CreateAssetPage;
