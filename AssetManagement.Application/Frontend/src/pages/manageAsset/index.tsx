import { useState } from "react";
import AssetInfo from "../../app/components/assetInfo/assetInfo";
import AssetDetailsResponse from "../../app/models/asset/AssetDetailsResponse";
import { Button } from "@mui/material";

const assetDetails: AssetDetailsResponse = {
  assetCode: "A12345",
  assetName: "Dell XPS 15",
  categoryName: "Laptop",
  installedDate: new Date("2022-01-15"),
  state: "In Use",
  location: "New York Office",
  specification: "16GB RAM, 512GB SSD, Intel i7",
  assignments: [
    {
      date: new Date("2022-01-16"),
      assignedTo: "John Doe",
      assignedBy: "Jane Smith",
      returnedDate: new Date("2023-01-15"),
    },
    {
      date: new Date("2023-01-20"),
      assignedTo: "Emily Johnson",
      assignedBy: "Jane Smith",
      returnedDate: new Date("2023-01-16"),
    },
  ],
};
export default function ManagementAssetPage() {
  const [open, setOpen] = useState(false);

  const handleOpen = () => {
    setOpen(!open);
  };
  return (
    <>
      <div className="flex justify-center h-full">
        <h1>Asset list</h1>
        <Button onClick={handleOpen}>Open</Button>
        {open && (
          <AssetInfo
            isOpen={true}
            isLoading={false}
            assetData={assetDetails}
            onClose={() => {
              setOpen(false);
            }}
          />
        )}
      </div>
    </>
  );
}
