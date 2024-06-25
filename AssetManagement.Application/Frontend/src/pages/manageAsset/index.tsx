import AssetList from "./assetList";
import { useState } from "react";
import { FilterAssetRequest } from "../../app/models/Asset";
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
      result: []
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
