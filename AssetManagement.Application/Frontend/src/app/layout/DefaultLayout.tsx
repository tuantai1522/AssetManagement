import { Outlet } from "react-router-dom";
import Header from "./Header";
import Sidebar from "./Sidebar";

const DefaultLayout = () => {
    return(
        <div>
            <Header></Header>
            <div className="flex justify-center items-start">
                <div className="w-[95%] flex gap-40">
                    <Sidebar></Sidebar>
                    <div className="mt-20 flex-1 overflow-x-auto ">
                        <Outlet />
                    </div>
                </div>
            </div>
        </div>
    )
}
export default DefaultLayout;