import { Outlet } from "react-router-dom";
import Header from "./Header";
import Sidebar from "./Sidebar";
import Header2 from "./Header2";

const DefaultLayout = () => {
    return(
        <div>
            <Header></Header>
            <div className="flex justify-center">
                <div className="w-[90%] flex gap-40">
                    <Sidebar></Sidebar>
                    <div className="mt-20">
                        <Outlet />
                    </div>
                </div>
            </div>
        </div>
    )
}
export default DefaultLayout;