import React, { useState } from "react";
import ArrowDropDownIcon from "@mui/icons-material/ArrowDropDown";
import { Button, IconButton, Menu, MenuItem } from "@mui/material";
import ChangePasswordModal from "../components/changePassword/ChangePasswordModal";

interface Props {
  userName: string;
}

const AccountHeader = (props: Props) => {
  const [anchorEl, setAnchorEl] = React.useState<null | HTMLElement>(null);
  const [isOpenChangePasswordModal, setIsOpenChangePasswordModal] =
    useState<boolean>(false);

  const open = Boolean(anchorEl);
  const handleClick = (event: React.MouseEvent<HTMLButtonElement>) => {
    setAnchorEl(event.currentTarget);
  };
  const handleClose = () => {
    setAnchorEl(null);
  };
  const handleClickChangePassword = () => {
    setIsOpenChangePasswordModal(true);
  };

  const onCloseChangePasswordModal = () => {
    setIsOpenChangePasswordModal(false);
  };

  return (
    <>
      <div className="text-white flex items-center">
        <p className="text-white">{props.userName ? props.userName : ""}</p>
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
          <MenuItem onClick={handleClose}>Logout</MenuItem>
        </Menu>
      </div>

      <ChangePasswordModal
        isOpen={isOpenChangePasswordModal}
        onClose={onCloseChangePasswordModal}
      />
    </>
  );
};

export default AccountHeader;
