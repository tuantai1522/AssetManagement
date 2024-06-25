import AssetList from "./assetList";
import { useState } from "react";
import { FilterAssetRequest, FilterAssetResponse } from "../../app/models/Asset";
import agent from "../../app/api/agent";
import { Order } from "../../app/components/table/sortTable";

type OrderByFieldName =
  | "assetCode"
  | "assetName"
  | "categoryName"
  | "state"
  | "lastUpdate";

export default function ManagementAssetPage() {

  const [order, setOrder] = useState<Order>("asc");
  const [orderBy, setOrderBy] = useState<OrderByFieldName>("assetName");

  const [query, setQuery] = useState<FilterAssetRequest>({
    sortAssetName: "asc",
    pageNumber: 1,
    pageSize: 5,
  });
  // const { data, isLoading, error, mutate } = agent.Assets.filter(query);

  //Fake data
  const data = {
    items: {
      result: [{
        id: "1",
        assetCode: "LA100001",
        assetName: "Laptop HP Probook 450 G1",
        categoryName: "Laptop",
        state: "Available",
      },
      {
        id: "2",
        assetCode: "LA100002",
        assetName: "Laptop HP Probook 450 G1",
        categoryName: "Laptop",
        state: "Available",
      },
      {
        id: "3",
        assetCode: "LA100003",
        assetName: "Laptop HP Probook 450 G1",
        categoryName: "Laptop",
        state: "Assigned",
      },
      {
        id: "4",
        assetCode: "LA100004",
        assetName: "Laptop HP Probook 450 G1",
        categoryName: "Laptop",
        state: "Not available",
      },
      {
        id: "5",
        assetCode: "MC100001",
        assetName: "Monitor Dell UltraSharp",
        categoryName: "Monitor",
        state: "Available",
      },
      {
        id: "6",
        assetCode: "PC100001",
        assetName: "Personal Computer",
        categoryName: "Personal Computer",
        state: "Available",
      },
      {
        id: "7",
        assetCode: "PC100002",
        assetName: "Personal Computer",
        categoryName: "Personal Computer",
        state: "Available",
      },
      {
        id: "7",
        assetCode: "PC100002",
        assetName: "Personal Computer",
        categoryName: "Personal Computer",
        state: "Available",
      },
      {
        id: "8",
        assetCode: "LA100005",
        assetName: "Laptop Dell XPS 13",
        categoryName: "Laptop",
        state: "Available",
      },
      {
        id: "9",
        assetCode: "LA100006",
        assetName: "Laptop Dell XPS 13",
        categoryName: "Laptop",
        state: "Assigned",
      },
      {
        id: "10",
        assetCode: "LA100007",
        assetName: "Laptop Dell XPS 13",
        categoryName: "Laptop",
        state: "Not available",
      },
      {
        id: "11",
        assetCode: "MC100002",
        assetName: "Monitor LG 27UK850-W",
        categoryName: "Monitor",
        state: "Available",
      },
      {
        id: "12",
        assetCode: "PC100003",
        assetName: "Personal Computer HP Elite",
        categoryName: "Personal Computer",
        state: "Available",
      },
      {
        id: "13",
        assetCode: "PC100004",
        assetName: "Personal Computer HP Elite",
        categoryName: "Personal Computer",
        state: "Assigned",
      },
      {
        id: "14",
        assetCode: "LA100008",
        assetName: "Laptop Lenovo ThinkPad X1 Carbon",
        categoryName: "Laptop",
        state: "Available",
      },
      {
        id: "15",
        assetCode: "LA100009",
        assetName: "Laptop Lenovo ThinkPad X1 Carbon",
        categoryName: "Laptop",
        state: "Available",
      },
      {
        id: "16",
        assetCode: "MC100003",
        assetName: "Monitor Samsung S27A650U",
        categoryName: "Monitor",
        state: "Available",
      },
      {
        id: "17",
        assetCode: "PC100005",
        assetName: "Personal Computer Dell Optiplex",
        categoryName: "Personal Computer",
        state: "Available",
      },
      {
        id: "18",
        assetCode: "PC100006",
        assetName: "Personal Computer Dell Optiplex",
        categoryName: "Personal Computer",
        state: "Assigned",
      },
      {
        id: "19",
        assetCode: "LA100010",
        assetName: "Laptop Acer Aspire 5",
        categoryName: "Laptop",
        state: "Not available",
      },
      {
        id: "20",
        assetCode: "MC100004",
        assetName: "Monitor ASUS ProArt PA278QV",
        categoryName: "Monitor",
        state: "Available",
      }
      ] as FilterAssetResponse[]
    }
  }

  const error = "";
  const isLoading: boolean = false;
  //Fake data

  return (
    <div className="flex justify-center h-full">
      <div className="container">
        <p className="text-primary text-xl font-bold justify-start items-start">
          Asset List
        </p>
        <div className="mt-3">
          <AssetList
            data={data?.items?.result}
            error={error}
            isLoading={isLoading}
            order={order}
            setOrder={setOrder}
            orderBy={orderBy}
            setOrderBy={setOrderBy}
            handleClick={(event, rowId) => { }}
          />
        </div>
      </div>
    </div>
  );
}
