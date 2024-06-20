import { Outlet, useLocation, useNavigate } from "react-router-dom";
import { useEffect } from "react";
import { User } from "../models/User";

interface Props {
  roles?: string[];
}
export default function RequireAuth({ roles }: Props) {
  const userJson = localStorage.getItem("user");

  // Check if userJson is null and parse it if not
  const user: User | null = userJson ? (JSON.parse(userJson) as User) : null;

  const location = useLocation();
  const navigate = useNavigate();
  useEffect(() => {
    debugger;
    if (!user) {
      console.log("You need to login to access this page");
      navigate("/login");
    } else if (roles && !roles.some((r) => user.role === r)) {
      //   console.log("You don't have permission to access this page");
      //   // signOut();
      navigate("/login");
    }
  }, [user, navigate, location, roles]);

  if (!user) {
    return null;
  }

  return <Outlet />;
}
