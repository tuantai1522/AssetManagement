import { Box, Container, Grid, Typography } from "@mui/material";
import { Controller, Field, FieldValues, useForm } from "react-hook-form";

import AppTextInput from "../../app/components/AppTextInput";
import AppPasswordInput from "../../app/components/AppPasswordInput";

import LoginHeader from "../../app/layout/LoginHeader";

import * as yup from "yup";
import { yupResolver } from "@hookform/resolvers/yup";

interface FormValues extends FieldValues {
  Username: string;
  Password: string;
}

const schema = yup.object().shape({
  Username: yup.string().required("User name is required"),
  Password: yup.string().required("Password is required"),
});

const LoginPage = () => {
  const {
    control,
    handleSubmit,
    formState: { errors, isSubmitting, isValid },
  } = useForm({
    resolver: yupResolver<FormValues>(schema),
    mode: "onChange", // This ensures the form is validated on change
  });

  const submitForm = async (data: FieldValues) => {
    const Username = data.Username;
    const Password = data.Password;
    console.log(Username, Password);

    //send to server
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
            border: "1px solid #ccc",
            borderRadius: 2,
            padding: 2,
            backgroundColor: "#EFF1F5",
          }}
        >
          <Typography
            className="text-primary"
            fontWeight="bold"
            variant="subtitle1"
          >
            Welcome to Online Asset Management
          </Typography>
        </Box>
      </Container>
      <Container sx={{ width: 500 }} component="main">
        <Box
          component="form"
          onSubmit={handleSubmit(submitForm)}
          sx={{
            display: "flex",
            flexDirection: "column",
            alignItems: "center",
            border: "1px solid #ccc",
            padding: 4,
            borderRadius: 2,
            gap: 2,
            backgroundColor: "#FAFCFC",
          }}
        >
          <Grid container justifyContent="space-between">
            <Grid item xs={5}>
              <Typography variant="subtitle1">Username</Typography>
            </Grid>
            <Grid item xs={7}>
              <Controller
                name="Username"
                control={control}
                render={({ field, fieldState }) => (
                  <AppTextInput
                    {...field}
                    label="Username"
                    control={control}
                    placeholder="Enter your username"
                    error={!!fieldState.error}
                    helperText={fieldState.error?.message}
                  />
                )}
              />
            </Grid>
          </Grid>
          <Grid container justifyContent="space-between">
            <Grid item xs={5}>
              <Typography variant="subtitle1">Password</Typography>
            </Grid>
            <Grid item xs={7}>
              <Controller
                name="Password"
                control={control}
                render={({ field, fieldState }) => (
                  <AppPasswordInput
                    {...field}
                    label="Password"
                    control={control}
                    placeholder="Enter your password"
                    error={!!fieldState.error}
                    helperText={fieldState.error?.message}
                  />
                )}
              />
            </Grid>
          </Grid>
          <Grid container alignItems="center" justifyContent="flex-end">
            <button
              className={`bg-primary text-white px-2 py-1 rounded hover:bg-red-600 ${
                !isValid || isSubmitting ? "opacity-50 cursor-not-allowed" : ""
              }`}
            >
              Log in
            </button>
          </Grid>
        </Box>
      </Container>
    </>
  );
};

export default LoginPage;
