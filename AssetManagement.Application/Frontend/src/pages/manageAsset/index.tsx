import AssetList, { AssetRowData } from "./assetList";
import { useEffect, useState } from "react";
import { FilterAssetRequest, FilterAssetResponse, getAssetQueryString } from "../../app/models/Asset";
import agent from "../../app/api/agent";
import { Order } from "../../app/components/table/sortTable";
import { Stack } from "@mui/material";
import { Search } from "@mui/icons-material";
import AppButton from "../../app/components/buttons/Button";
import AppSearchInput from "../../app/components/AppSearchInput";
import AppPagination from "../../app/components/paginationButtons/paginationButtons";

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

  const [searchInput, setSearchInput] = useState<string>("");

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
        action: {
          id: "1",
          state: "Available",
        }
      },
      {
        id: "2",
        assetCode: "LA100002",
        assetName: "Laptop HP Probook 450 G1",
        categoryName: "Laptop",
        state: "Available",
        action: {
          id: "2",
          state: "Available",
        }
      },
      {
        id: "3",
        assetCode: "LA100003",
        assetName: "Laptop HP Probook 450 G1",
        categoryName: "Laptop",
        state: "Assigned",
        action: {
          id: "3",
          state: "Assigned",
        }
      },
      {
        id: "4",
        assetCode: "LA100004",
        assetName: "Laptop HP Probook 450 G1",
        categoryName: "Laptop",
        state: "Not available",
        action: {
          id: "4",
          state: "Not available",
        }
      },
      {
        id: "5",
        assetCode: "MC100001",
        assetName: "Monitor Dell UltraSharp",
        categoryName: "Monitor",
        state: "Available",
        action: {
          id: "5",
          state: "Available",
        }
      },
      {
        id: "6",
        assetCode: "PC100001",
        assetName: "Personal Computer",
        categoryName: "Personal Computer",
        state: "Available",
        action: {
          id: "6",
          state: "Available",
        }
      },
      {
        id: "7",
        assetCode: "PC100002",
        assetName: "Personal Computer",
        categoryName: "Personal Computer",
        state: "Available",
        action: {
          id: "7",
          state: "Available",
        }
      },
      {
        id: "8",
        assetCode: "LA100005",
        assetName: "Laptop Dell XPS 13",
        categoryName: "Laptop",
        state: "Assigned",
        action: {
          id: "8",
          state: "Assigned",
        }
      },
      {
        id: "9",
        assetCode: "LA100006",
        assetName: "Laptop Dell XPS 13",
        categoryName: "Laptop",
        state: "Assigned",
        action: {
          id: "9",
          state: "Assigned",
        }
      },
      {
        id: "10",
        assetCode: "LA100007",
        assetName: "Laptop Dell XPS 13",
        categoryName: "Laptop",
        state: "Assigned",
        action: {
          id: "10",
          state: "Assigned",
        }
      },
      {
        id: "11",
        assetCode: "MC100002",
        assetName: "Monitor LG 27UK850-W",
        categoryName: "Monitor",
        state: "Available",
        action: {
          id: "11",
          state: "Available",
        }
      },
      {
        id: "12",
        assetCode: "PC100003",
        assetName: "Personal Computer HP Elite",
        categoryName: "Personal Computer",
        state: "Available",
        action: {
          id: "12",
          state: "Available",
        }
      },
      {
        id: "13",
        assetCode: "PC100004",
        assetName: "Personal Computer HP Elite",
        categoryName: "Personal Computer",
        state: "Assigned",
        action: {
          id: "13",
          state: "Assigned",
        }
      },
      {
        id: "14",
        assetCode: "LA100008",
        assetName: "Laptop Lenovo ThinkPad X1 Carbon",
        categoryName: "Laptop",
        state: "Available",
        action: {
          id: "14",
          state: "Available",
        }
      },
      {
        id: "15",
        assetCode: "LA100009",
        assetName: "Laptop Lenovo ThinkPad X1 Carbon",
        categoryName: "Laptop",
        state: "Available",
        action: {
          id: "15",
          state: "Available",
        }
      },
      {
        id: "16",
        assetCode: "MC100003",
        assetName: "Monitor Samsung S27A650U",
        categoryName: "Monitor",
        state: "Available",
        action: {
          id: "16",
          state: "Available",
        }
      },
      {
        id: "17",
        assetCode: "PC100005",
        assetName: "Personal Computer Dell Optiplex",
        categoryName: "Personal Computer",
        state: "Assigned",
        action: {
          id: "17",
          state: "Assigned",
        }
      },
      {
        id: "18",
        assetCode: "PC100006",
        assetName: "Personal Computer Dell Optiplex",
        categoryName: "Personal Computer",
        state: "Assigned",
        action: {
          id: "18",
          state: "Assigned",
        }

      },
      {
        id: "19",
        assetCode: "LA100010",
        assetName: "Laptop Acer Aspire 5",
        categoryName: "Laptop",
        state: "Not available",
        action: {
          id: "19",
          state: "Not available",
        }
      },
      {
        id: "20",
        assetCode: "MC100004",
        assetName: "Monitor ASUS ProArt PA278QV",
        categoryName: "Monitor",
        state: "Available",
        action: {
          id: "20",
          state: "Available",
        }
      }
      ] as AssetRowData[]
    },
    metaData: {
      totalPageCount: 10 as number,
      currentPage: 1 as number
    }
  }

  const error = "";
  const isLoading: boolean = false;
  //Fake data

  useEffect(() => {
    switch (orderBy) {
      case "assetCode": {
        setQuery((query) => ({
          ...query,
          sortAssetCode: order,
          sortAssetName: undefined,
          sortCategoryName: undefined,
          sortState: undefined,
          sortLastUpdate: undefined,
        }));
        //refresh
        const queryString = getAssetQueryString({
          ...query,
          sortAssetCode: order,
          sortAssetName: undefined,
          sortCategoryName: undefined,
          sortState: undefined,
          sortLastUpdate: undefined,
        });
        // mutate(query);
        break;
      }
      case "assetName": {
        setQuery((query) => ({
          ...query,
          sortAssetCode: undefined,
          sortAssetName: order,
          sortCategoryName: undefined,
          sortState: undefined,
          sortLastUpdate: undefined,
        }));
        //refresh
        const queryString = getAssetQueryString({
          ...query,
          sortAssetCode: undefined,
          sortAssetName: order,
          sortCategoryName: undefined,
          sortState: undefined,
          sortLastUpdate: undefined,
        });
        // mutate(query);
        break;
      }
      case "categoryName": {
        setQuery((query) => ({
          ...query,
          sortAssetCode: undefined,
          sortAssetName: undefined,
          sortCategoryName: order,
          sortState: undefined,
          sortLastUpdate: undefined,
        }));
        //refresh
        const queryString = getAssetQueryString({
          ...query,
          sortAssetCode: undefined,
          sortAssetName: undefined,
          sortCategoryName: order,
          sortState: undefined,
          sortLastUpdate: undefined,
        });
        // mutate(query);
        break;
      }
      case "state": {
        setQuery((query) => ({
          ...query,
          sortAssetCode: undefined,
          sortAssetName: undefined,
          sortCategoryName: undefined,
          sortState: order,
          sortLastUpdate: undefined,
        }));
        //refresh
        const queryString = getAssetQueryString({
          ...query,
          sortAssetCode: undefined,
          sortAssetName: undefined,
          sortCategoryName: undefined,
          sortState: order,
          sortLastUpdate: undefined,
        });
        // mutate(query);
        break;
      }
      case "lastUpdate": {
        setQuery((query) => ({
          ...query,
          sortAssetCode: undefined,
          sortAssetName: undefined,
          sortCategoryName: undefined,
          sortState: undefined,
          sortLastUpdate: order,
        }));
        //refresh
        const queryString = getAssetQueryString({
          ...query,
          sortAssetCode: undefined,
          sortAssetName: undefined,
          sortCategoryName: undefined,
          sortState: undefined,
          sortLastUpdate: order,
        });
        // mutate(query);
        break;
      }
      default:
        break;
    }
  }, [orderBy, order]);

  const handlePageNumberChange = (value: any) => {
    const pageNumber = Number(value);
    setQuery((prevQuery) => ({ ...prevQuery, pageNumber }));
    // mutate(query);
    //fake api 
    getAssetQueryString({ ...query, pageNumber });
  };

  const handleSearchInputChange = (
    event: React.ChangeEvent<HTMLInputElement>
  ) => {
    const { name, value } = event.target;
    setSearchInput(value);
  };

  const handleSearchSubmit = () => {
    setQuery((prevQuery) => ({
      ...prevQuery,
      pageNumber: 1,
      name: searchInput?.trim(),
    }));
    // mutate();
    //fake api 
    getAssetQueryString({
      ...query,
      pageNumber: 1,
      name: searchInput?.trim(),
    });
  }

  return (
    <div className="flex justify-center h-full">
      <div className="container mb-12">
        <p className="text-primary text-xl font-bold justify-start items-start">
          Asset List
        </p>
        <Stack
          direction="row"
          justifyContent="space-between"
          alignItems="center"
          spacing={2}
          className="mt-3"
        >
          <div></div>
          <Stack
            direction="row"
            justifyContent="flex-end"
            alignItems="center"
            spacing={8}>
            <Stack
              direction="row"
              justifyContent="flex-start"
              alignItems="center"
              spacing={2}>
              <AppSearchInput type="text" placeholder="Search" name="name" value={searchInput} onChange={handleSearchInputChange}
                className="!rounded-l-md !border !border-gray-400 !border-r-0"
              />

              <div onClick={handleSearchSubmit} className="border border-gray-500 border-l-0 rounded-r-md mx-0 hover:cursor-pointer" style={{ margin: 0, padding: "6px" }}>
                <Search className="mx-0" />
              </div>
            </Stack>
            <AppButton
              content="Create new user"
              className="py-[6px]"
            />
          </Stack>
        </Stack>
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

          <Stack
            direction="row"
            justifyContent="flex-end"
            alignItems="baseline"
          >
            <AppPagination
              totalPage={data?.metaData?.totalPageCount ?? 1}
              onChange={handlePageNumberChange}
              currentPage={data?.metaData?.currentPage ?? 1}
            />
          </Stack>
        </div>
      </div>
    </div>
  );
}
