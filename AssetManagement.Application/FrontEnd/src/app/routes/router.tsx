import { Navigate, createBrowserRouter } from "react-router-dom";
import App from "../../App";
import DefaultLayout from "../layout/DefaultLayout";
import HomePage from "../../pages/home";
import NotFound from "../errors/NotFound";
import ServerErrors from "../errors/ServerErrors";
import ManagementUserPage from "../../pages/manageUser";
import CreateUserPage from "../../pages/manageUser/createUser";
import LoginPage from "../../pages/authentication/LoginPage";
import EditUserPage from "../../pages/manageUser/editUser";

export const router = createBrowserRouter([
    {
        path: "/",
        element: <App />,
        children: [
            {
                //Allow user logined
                // element: <RequireAuth/>,
                children: [
                    {
                        element: <DefaultLayout />,
                        children: [{ path: "", element: <HomePage /> }],
                    },
                ],
            },
            {
                //Allow only admin
                // element: <RequireAuth roles={["Admin"]} />,
                children: [
                    {
                        element: <DefaultLayout />,
                        children: [
                            { path: "manage-user", element: <ManagementUserPage /> },
                            { path: "create-user", element: <CreateUserPage />},
                            { path: "edit-user/:id", element: <EditUserPage />},
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
