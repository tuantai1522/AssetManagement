import logo from "../../app/assets/images/logo/logo.svg";
import agent from "../../app/api/agent";
import { Product } from "../../app/models/Product";
import DefaultLayout from "../../app/layout/DefaultLayout";
import ManagementUserPage from "../manageUser";
export default function HomePage() {

  return (
    <>
      <ManagementUserPage />
    </>
  );
}
