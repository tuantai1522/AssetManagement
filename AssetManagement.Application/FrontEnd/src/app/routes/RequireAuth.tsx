import { Outlet, useLocation, useNavigate } from "react-router-dom";
import { useEffect } from "react";

interface Props {
  roles?: string[];
}
export default function RequireAuth({ roles }: Props) {
  const user = "";
  const location = useLocation();
  const navigate = useNavigate();
  useEffect(() => {
    if (!user) {
      console.log("You need to login to access this page");
      navigate("/login");
    }
    // else if (roles && !roles.some((r) => user.role?.includes(r))) {
    //   console.log("You don't have permission to access this page");
    //   signOut()
    //   navigate("/login");
    // }
  }, [user, navigate, location, roles]);

  if (!user) {
    return null;
  }

  return <Outlet />;
}
