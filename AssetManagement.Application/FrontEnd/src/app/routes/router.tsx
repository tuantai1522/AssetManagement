import { Navigate, createBrowserRouter } from "react-router-dom";
import App from "../../App";
import DefaultLayout from "../layout/DefaultLayout";
import HomePage from "../../pages/home";
import NotFound from "../errors/NotFound";
import ServerErrors from "../errors/ServerErrors";
import UserManager from "../../pages/manageUser";

export const router = createBrowserRouter([
    {
        path: "/",
        element: <App/>,
        children: [
            {
                element: <DefaultLayout/>,
                children: [
                    { path: "", element: <HomePage/> },
                    { path: "user-manage", element: <UserManager/> },
                ]
            }
        ]
    },
    { path: "not-found", element: <NotFound /> },
    { path: "server-error", element: <ServerErrors /> },
    { path: "*", element: <Navigate replace to="/not-found" /> },
    { path: "userManager", element: <UserManager/>}

]);