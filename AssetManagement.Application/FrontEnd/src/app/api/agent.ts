import axios, { AxiosError, AxiosResponse } from "axios";
import { router } from "../routes/router";

axios.defaults.baseURL = "https://fakestoreapi.com/";
axios.defaults.headers.post["Content-Type"] = "application/json";
const responseBody = (response: AxiosResponse) => response.data;
axios.interceptors.request.use((config) => {
//   const userToken = store.getState().account.user?.token;
const userToken = "";
  if (userToken) config.headers.Authorization = `Bearer ${userToken}`;
  return config;
});

axios.interceptors.response.use(
  async (response) => {
    // const pagination = response.headers["x-pagination"];
    // if (pagination) {
    //   response.data = new PaginatedResponse(
    //     response.data,
    //     JSON.parse(pagination)
    //   );
    //   return response;
    // }
    return response;
  },
  (error: AxiosError) => {
    const { data, status } = error.response!;
    switch (status) {
      case 400:
        if ((data as any).errors) {
          const modalStateErrors: string[] = [];
          for (const key in (data as any).errors) {
            if ((data as any).errors[key]) {
              modalStateErrors.push((data as any).errors[key]);
            }
          }

          console.log(modalStateErrors.toString());
        }
        console.log((data as any).message);
        break;
      case 401:
        console.log((data as any).title);
        break;
      case 403:
        console.log((data as any).message);
        break;
      case 404:
        console.log((data as any).message);
        break;
      case 409:
        console.log((data as any).message);
        break;
      case 500:
        console.log("Catch 500");
        console.log((data as any).message);
        router.navigate("/server-error");
        break;
      default:
        break;
    }
    return Promise.reject(error.response);
  }
);

const requests = {
  get: (url: string, params?: URLSearchParams) =>
    axios.get(url, { params }).then(responseBody),
  post: (url: string, body: {}) => axios.post(url, body).then(responseBody),
  postFormData: (url: string, body: any) => {
    const headers = body instanceof FormData
      ? { 'Content-Type': 'multipart/form-data' }
      : {};
    return axios.post(url, body, { headers }).then(responseBody);
  },
  put: (url: string, body: {}) => axios.put(url, body).then(responseBody),
  patch: (url: string, body: {}) => axios.patch(url, body).then(responseBody),
  delete: (url: string) => axios.delete(url).then(responseBody),
};

const Product = {
  all: () => requests.get("products"),
  details: (id: string) => requests.get(`products/${id}`),
  create: (values: {}) => requests.postFormData("products", values),
  update: (id: string, values: {}) => requests.put(`products/${id}`, values),
  delete: (id: string) => requests.delete(`products/${id}`),
};


const agent = {
  Product,
};

export default agent;