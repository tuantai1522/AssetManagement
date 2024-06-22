import React from "react";
import AccountHeader from "./AccountHeader";
import { User } from "../models/User";

const Header = () => {
  const userJson = localStorage.getItem("user");

  const user: User | null = userJson ? (JSON.parse(userJson) as User) : null;

  return (
    <div className="bg-primary h-14 flex justify-center text-lg font-semibold">
      <div className="w-[90%] flex justify-between items-center">
        <p className="text-white">Home</p>
        <AccountHeader user={user} />
      </div>
    </div>
  );
};

export default Header;
