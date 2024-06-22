import React from "react";
import { NavLink } from "react-router-dom";

interface Props {
    url : string,
    name: string
}

const SidebarItem = (props: Props) => {
  return (
    <NavLink
      to={props.url}
      className={({ isActive }) =>
        isActive
          ? "bg-primary h-16 text-xl text-white font-bold pl-5 flex items-center transition-all duration-200"
          : "bg-grey h-16 text-xl font-bold pl-5 flex items-center hover:bg-red-200 hover:text-primary hover:scale-105 transition-all duration-200"
      }
    >
      <p>{props.name}</p>
    </NavLink>
  );
};

export default SidebarItem;
