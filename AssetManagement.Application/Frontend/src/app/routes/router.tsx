import { Navigate, createBrowserRouter } from "react-router-dom";
import App from "../../App";
import DefaultLayout from "../layout/DefaultLayout";
import HomePage from "../../pages/home";
import NotFound from "../errors/NotFound";
import ServerErrors from "../errors/ServerErrors";
import ManagementUserPage from "../../pages/manageUser";
import CreateUserPage from "../../pages/manageUser/createUser";
import EditUserPage from "../../pages/manageUser/editUser";
import LoginPage from "../../pages/authentication";
import RequireAuth from "./RequireAuth";
import ManagementAssetPage from "../../pages/manageAsset";
import ManagementAssignmentPage from "../../pages/manageAssignment";
import ManagementRequestForReturningPage from "../../pages/requestForReturning";
import ManagementReportPage from "../../pages/report";
import CreateAssetPage from "../../pages/manageAsset/createAsset";
import EditAssetPage from "../../pages/manageAsset/editAsset";

export const router = createBrowserRouter([
  {
    path: "/",
    element: <App />,
    children: [
      {
        //Allow user logined
        element: <RequireAuth />,
        children: [
          {
            element: <DefaultLayout />,
            children: [{ path: "", element: <HomePage /> }],
          },
        ],
      },
      {
        //Allow only admin
        element: <RequireAuth roles={["Admin"]} />,
        children: [
          {
            element: <DefaultLayout />,
            children: [
              {
                path: "manage-user",
                children: [
                  { path: "", element: <ManagementUserPage /> },
                  { path: "create-user", element: <CreateUserPage /> },
                  { path: "edit-user/:id", element: <EditUserPage /> },
                ],
              },
              {
                path: "manage-asset",
                children: [
                  { path: "", element: <ManagementAssetPage /> },
                  { path: "create-asset", element: <CreateAssetPage /> },
                  { path: "edit-asset", element: <EditAssetPage /> },
                ],
              },
              {
                path: "manage-assignment",
                element: <ManagementAssignmentPage />,
              },
              {
                path: "request-for-returning",
                element: <ManagementRequestForReturningPage />,
              },
              { path: "report", element: <ManagementReportPage /> },
            ],
          },
        ],
      },
    ],
  },
  //Allow anonymous
  { path: "login", element: <LoginPage /> },
  { path: "not-found", element: <NotFound /> },
  { path: "server-error", element: <ServerErrors /> },
  { path: "*", element: <Navigate replace to="/not-found" /> },
]);
