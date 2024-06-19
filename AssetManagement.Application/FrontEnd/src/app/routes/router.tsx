import { Navigate, createBrowserRouter } from "react-router-dom";
import App from "../../App";
import DefaultLayout from "../layout/DefaultLayout";
import HomePage from "../../pages/home";
import NotFound from "../errors/NotFound";
import ServerErrors from "../errors/ServerErrors";
import LoginPage from "../../pages/authentication/LoginPage";

export const router = createBrowserRouter([
  {
    path: "/",
    element: <App />,
    children: [
      {
        element: <DefaultLayout />,
        children: [{ path: "", element: <HomePage /> }],
      },
    ],
  },
  { path: "login", element: <LoginPage /> },

  { path: "not-found", element: <NotFound /> },
  { path: "server-error", element: <ServerErrors /> },
  { path: "*", element: <Navigate replace to="/not-found" /> },
]);
