import React from "react";
import AccountHeader from "./AccountHeader";
import { User } from "../models/User";
import { useLocation } from "react-router-dom";

const Header = () => {
  const userJson = localStorage.getItem("user");

  const user: User | null = userJson ? (JSON.parse(userJson) as User) : null;

  const location = useLocation();
  const pathName = location.pathname.split("/");
  let breadcrumb = "";
    let pageName = pathName[1];
    switch(pageName) {
      case "":
        breadcrumb = "Home";
        break;
      case "manage-user":
        breadcrumb = "Manage User";
        break;
      case "manage-asset":
        breadcrumb = "Manage Asset";
        break;
      case "manage-assignment":
        breadcrumb = "Manage Assignment";
        break;
      case "request-for-returning":
        breadcrumb = "Request for Returning";
        break;
      case "report":
        breadcrumb = "Report"
        break;
      default:
        breadcrumb = "";
    }

    if (pathName.length >= 3) {
      breadcrumb += " > ";
      let name  = pathName[2];
      switch (name) {
        case "create-user":
         breadcrumb += "Create New User"
         break;
        case "edit-user":
          breadcrumb += "Edit User"
          break;
        case "create-asset":
          breadcrumb += "Create New Asset"
          break;
        default:
          breadcrumb += "";
      }
    }


  return (
    <div className="bg-primary h-14 flex justify-center text-lg font-semibold">
      <div className="w-[90%] flex justify-between items-center">
        <p className="text-white">{breadcrumb}</p>
        <AccountHeader user={user} />
      </div>
    </div>
  );
};

export default Header;
