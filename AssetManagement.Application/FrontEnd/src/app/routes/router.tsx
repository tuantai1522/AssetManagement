import { Navigate, createBrowserRouter } from "react-router-dom";
import App from "../../App";
import DefaultLayout from "../layout/DefaultLayout";
import HomePage from "../../pages/home";
import NotFound from "../errors/NotFound";
import ServerErrors from "../errors/ServerErrors";
import ManagementUserPage from "../../pages/manageUser";
import TestSortComponent from "../components/table/test";
import LoginPage from "../../pages/authentication/LoginPage";
import RequireAuth from "./RequireAuth";

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
  {
    path: "test", element: (
      <div className="w-100" >
        <div className="mt-5 mx-10">
          <TestSortComponent />
        </div>
      </div>
    )
  }
]);
