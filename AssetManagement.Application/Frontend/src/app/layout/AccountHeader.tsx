import React, { useEffect, useState } from "react";
import ArrowDropDownIcon from "@mui/icons-material/ArrowDropDown";
import { IconButton, Menu, MenuItem } from "@mui/material";
import ChangePasswordModal from "../components/changePassword/ChangePasswordModal";
import { useNavigate } from "react-router-dom";
import { User } from "../models/user/User";

interface Props {
  user: User | null;
}

const AccountHeader = (props: Props) => {
  const [anchorEl, setAnchorEl] = React.useState<null | HTMLElement>(null);
  const [isOpenChangePasswordModal, setIsOpenChangePasswordModal] =
    useState<boolean>(false);

  const navigate = useNavigate();

  const open = Boolean(anchorEl);
  const handleClick = (event: React.MouseEvent<HTMLButtonElement>) => {
    setAnchorEl(event.currentTarget);
  };
  const handleClose = () => {
    setAnchorEl(null);
  };

  //Handle change password modal
  useEffect(() => {
    if (props.user && !props.user.isPasswordChanged) {
      setIsOpenChangePasswordModal(true);
    }
  }, []);

  const handleClickChangePassword = () => {
    setIsOpenChangePasswordModal(true);
  };

  const onCloseChangePasswordModal = () => {
    setIsOpenChangePasswordModal(false);
  };
  //End of handle change password modal

  const handleClickLogout = () => {
    localStorage.removeItem("user");
    navigate("/");
  };

  return (
    <>
      <div className="text-white flex items-center">
        <p className="text-white">
          {props.user?.userName ? props.user?.userName : ""}
        </p>
        <IconButton
          aria-controls={open ? "basic-menu" : undefined}
          aria-haspopup="true"
          aria-expanded={open ? "true" : undefined}
          onClick={handleClick}
        >
          <ArrowDropDownIcon className="hover:cursor-pointer text-white" />
        </IconButton>
        <Menu
          id="basic-menu"
          anchorEl={anchorEl}
          open={open}
          onClose={handleClose}
          MenuListProps={{
            "aria-labelledby": "basic-button",
          }}
          anchorOrigin={{
            vertical: "bottom",
            horizontal: "right",
          }}
          transformOrigin={{
            vertical: "top",
            horizontal: "right",
          }}
        >
          <MenuItem onClick={handleClickChangePassword}>
            Change Password
          </MenuItem>
          <MenuItem onClick={handleClickLogout}>Logout</MenuItem>
        </Menu>
      </div>

      <ChangePasswordModal
        user={props.user}
        isOpen={isOpenChangePasswordModal}
        onClose={onCloseChangePasswordModal}
      />
    </>
  );
};

export default AccountHeader;
