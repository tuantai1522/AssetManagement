import { useState } from "react";
import AssetInfo from "../../app/components/assetInfo/assetInfo";
import { Button } from "@mui/material";
import agent from "../../app/api/agent";

export default function ManagementAssetPage() {
  const [open, setOpen] = useState(false);

  const [id, setId] = useState("");

  const {
    data: assetData,
    isLoading: assetLoading,
    error: assetError,
  } = agent.Asset.details(id);

  const handleOpen1 = () => {
    setOpen(!open);
    setId("173279D4-8458-461F-B3B0-170A3122A82A");
  };

  return (
    <>
      <div className="h-full">
        <h1>Asset list</h1>
        <Button onClick={handleOpen1}>
          Open with id: 173279D4-8458-461F-B3B0-170A3122A82A
        </Button>

        {open && (
          <AssetInfo
            isOpen={true}
            isLoading={assetLoading}
            assetData={assetData?.result}
            onClose={() => {
              setOpen(false);
            }}
          />
        )}
      </div>
    </>
  );
}
