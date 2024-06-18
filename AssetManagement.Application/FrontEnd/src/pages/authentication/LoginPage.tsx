import { Box, Container, Grid, Typography } from "@mui/material";
import { FieldValues, useForm } from "react-hook-form";

import AppTextInput from "../../app/components/AppTextInput";
import AppPasswordInput from "../../app/components/AppPasswordInput";

import LoginHeader from "../../app/layout/LoginHeader";

const LoginPage = () => {
  const { control, handleSubmit } = useForm();

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
          <Grid container alignItems="center" justifyContent="space-between">
            <Grid item xs={5}>
              <Typography variant="subtitle1">Username</Typography>
            </Grid>
            <Grid item xs={7}>
              <AppTextInput name="Username" control={control} />
            </Grid>
          </Grid>
          <Grid container alignItems="center" justifyContent="space-between">
            <Grid item xs={5}>
              <Typography variant="subtitle1">Password</Typography>
            </Grid>
            <Grid item xs={7}>
              <AppPasswordInput name="Password" control={control} />
            </Grid>
          </Grid>
          <Grid container alignItems="center" justifyContent="flex-end">
            <button className="bg-primary text-white px-2 py-1 rounded hover:bg-red-600">
              Log in
            </button>
          </Grid>
        </Box>
      </Container>
    </>
  );
};

export default LoginPage;
