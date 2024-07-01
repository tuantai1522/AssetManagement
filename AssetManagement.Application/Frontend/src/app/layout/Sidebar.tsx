import { User } from "../models/user/User";
import SidebarItem from "./SidebarItem";

const Sidebar = () => {
  const userJson = localStorage.getItem("user");

  const user: User | null = userJson ? (JSON.parse(userJson) as User) : null;

  return (
    <div className="min-w-max bg-white h-fit mt-10">
      <div className="logo">
        <div className="logo-image w-[6rem]">
          <img
            src="https://i0.wp.com/blog.nashtechglobal.com/wp-content/uploads/2023/04/nashTechLogo-red-.png?fit=320%2C320&ssl=1"
            alt="NashTech-logo"
            className="w-full h-full object-cover"
          ></img>
        </div>
        <p className="text-primary text-xl font-bold">
          Online Asset Management
        </p>
      </div>
      <div className="menu mt-8 flex flex-col gap-1">
        <SidebarItem url="/" name="Home" />
        {user?.role === "Admin" && (
          <>
            <SidebarItem url="/manage-user" name="Manage User" />
            <SidebarItem url="/manage-asset" name="Manage Asset" />
            <SidebarItem url="/manage-assignment" name="Manage Assignment" />
            <SidebarItem
              url="/request-for-returning"
              name="Request for Returning"
            />
            <SidebarItem url="/report" name="Report" />
          </>
        )}
      </div>
    </div>
  );
};

export default Sidebar;
