import { Navigate, createBrowserRouter } from "react-router-dom";
import App from "../../App";
import DefaultLayout from "../layout/DefaultLayout";
import HomePage from "../../pages/home";
import NotFound from "../errors/NotFound";
import ServerErrors from "../errors/ServerErrors";
import ManagementUserPage from "../../pages/manageUser";
import LoginPage from "../../pages/authentication";
import RequireAuth from "./RequireAuth";
import ManagementAssetPage from "../../pages/manageAsset";
import ManagementAssignmentPage from "../../pages/manageAssignment";
import ManagementRequestForReturningPage from "../../pages/requestForReturning";
import ManagementReportPage from "../../pages/report";

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
              { path: "user-manage", element: <ManagementUserPage /> },
              { path: "asset-manage", element: <ManagementAssetPage /> },
              {
                path: "assignment-manage",
                element: <ManagementAssignmentPage />,
              },
              {
                path: "request-for-returning-manage",
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
