import { Box, Container, Grid, Typography } from "@mui/material";
import { Controller, FieldValues, useForm } from "react-hook-form";

import { jwtDecode } from "jwt-decode";

import AppTextInput from "../../app/components/AppTextInput";
import AppPasswordInput from "../../app/components/AppPasswordInput";

import LoginHeader from "../../app/layout/LoginHeader";

import * as yup from "yup";
import { yupResolver } from "@hookform/resolvers/yup";
import LoginRequest from "../../app/models/login/LoginRequest";
import agent from "../../app/api/agent";
import { BaseResult } from "../../app/models/BaseResult";
import { useState } from "react";
import { User } from "../../app/models/user/User";
import { Token } from "../../app/models/Token";
import { useNavigate } from "react-router-dom";
import { LoginResponse } from "../../app/models/login/LoginReponse";
import AppButton from "../../app/components/buttons/Button";

interface FormValues extends FieldValues {
  Username: string;
  Password: string;
}

const schema = yup.object().shape({
  Username: yup.string().required("User name is required"),
  Password: yup.string().required("Password is required"),
});

const LoginPage = () => {
  const [errorMessage, setErrorMessage] = useState("");
  const navigate = useNavigate();

  const {
    control,
    handleSubmit,
    setError,
    formState: { errors, isSubmitting, isValid },
  } = useForm({
    resolver: yupResolver<FormValues>(schema),
    mode: "onChange", // This ensures the form is validated on change
  });

  const submitForm = async (data: FieldValues) => {
    try {
      const Username = data.Username;
      const Password = data.Password;

      const requestData: LoginRequest = {
        Username: Username,
        Password: Password,
      };

      //send to server
      const response: BaseResult<LoginResponse> =
        await agent.Authentication.login(requestData);

      if (response.isSuccess) {
        const token = response.result.token;

        const decoded: Token = jwtDecode(token);

        const user: User = {
          id: decoded.sub,
          userName: decoded.unique_name,
          role: decoded.role,
          token: token,
          isPasswordChanged: response.result.isPasswordChanged,
        };
        localStorage.setItem("user", JSON.stringify(user));
        navigate("/");
      }
    } catch (error: any) {
      setErrorMessage(error.message);
    }
  };

  return (
    <>
      <LoginHeader />
      <Container sx={{ width: 500 }} component="main">
        <Box
          sx={{
            marginTop: 20,
            display: "flex",
            flexDirection: "column",
            alignItems: "center",
            border: "2px solid #737679",
            borderBottom: "none",
            borderTopLeftRadius: 7,
            borderTopRightRadius: 7,
            padding: 2,
            backgroundColor: "#EFF1F5",
          }}
        >
          <Typography className="text-primary" fontWeight="bold" variant="h6">
            Welcome to Online Asset Management
          </Typography>
        </Box>
        <Box
          component="form"
          onSubmit={handleSubmit(submitForm)}
          sx={{
            display: "flex",
            flexDirection: "column",
            alignItems: "center",
            border: "2px solid #737679",
            padding: 4,
            borderBottomLeftRadius: 7,
            borderBottomRightRadius: 7,
            gap: 2,
            backgroundColor: "#FAFCFC",
          }}
        >
          <Grid container>
            <Grid container alignItems="center">
              <Grid item xs={5}>
                <Typography variant="subtitle1">
                  Username <span style={{ color: "red" }}>*</span>
                </Typography>
              </Grid>
              <Grid item xs={7}>
                <Controller
                  name="Username"
                  control={control}
                  render={({ field }) => (
                    <AppTextInput
                      {...field}
                      id="Username"
                      control={control}
                      isApplyHelperText={false}
                    />
                  )}
                />
              </Grid>
            </Grid>
          </Grid>

          <Grid container>
            <Grid container alignItems="center">
              <Grid item xs={5}>
                <Typography variant="subtitle1">
                  Password <span style={{ color: "red" }}>*</span>
                </Typography>
              </Grid>
              <Grid item xs={7}>
                <Controller
                  name="Password"
                  control={control}
                  render={({ field }) => (
                    <AppPasswordInput
                      {...field}
                      id="Password"
                      control={control}
                      isApplyHelperText={false}
                    />
                  )}
                />
              </Grid>
            </Grid>
          </Grid>

          {errorMessage && (
            <Grid container alignItems="center" justifyContent="center">
              <Typography color="red" component="p">
                {errorMessage}
              </Typography>
            </Grid>
          )}

          <Grid container alignItems="center" justifyContent="flex-end">
            <AppButton
              content="Log in"
              isDisabled={!isValid}
              isFormSubmit={!isValid || isSubmitting ? false : true}
            ></AppButton>
          </Grid>
        </Box>
      </Container>
    </>
  );
};

export default LoginPage;
