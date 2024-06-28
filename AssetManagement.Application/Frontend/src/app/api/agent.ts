import axios, { AxiosError, AxiosResponse } from "axios";
import { router } from "../routes/router";
import useSWR from "swr";
import { PaginatedResponse } from "../models/Pagination";
import { BaseResult } from "../models/BaseResult";
import { User, UserQuery, getUserQueryString } from "../models/user/User";
import { AssetCreationRequest } from "../models/asset/AssetCreationRequest";
import { FilterAssetRequest, getAssetQueryString } from "../models/asset/Asset";
import { EditUserRequest } from "../models/user/EditUserRequest";
import { CreateUserRequest } from "../models/user/CreateUserRequest";
import { useNotification } from "../components/toast/NotifyContext";
import eventEmitter from "../hooks/EventMitter";

axios.defaults.baseURL = process.env.REACT_APP_API_URL;
axios.defaults.headers.post["Content-Type"] = "application/json";
const responseBody = (response: AxiosResponse) => response.data;
axios.interceptors.request.use((config) => {
  // Retrieve user data from localStorage
  const userJson = localStorage.getItem("user");

  // Check if userJson is null and parse it if not
  const user: User | null = userJson ? (JSON.parse(userJson) as User) : null;

  if (user) {
    const userToken = user.token;
    console.log(userToken);

    if (userToken) config.headers.Authorization = `Bearer ${userToken}`;
    return config;
  }

  return config;
});
axios.interceptors.response.use(
  async (response) => {
    // Get pagination response from header and data response from api
    const pagination = response.headers["x-pagination"];
    if (pagination) {
      response.data = new PaginatedResponse(
        response.data,
        JSON.parse(pagination)
      );
      return response;
    }
    return response;
  },
  (error: AxiosError) => {
    const result = error.response!.data as BaseResult<any>;
    const errorStatus = result.error ? result.error.status : result.status;
    switch (errorStatus){
      case 400:
        if (result?.errors) {
          const modalStateErrors: string[] = [];
          for (const key in result.errors) {
            if (result.errors[key]) {
              result.errors[key].forEach((errorMsg) => {
                modalStateErrors.push(`${key}: ${errorMsg}`);
              });
            }
          }

          eventEmitter.emit('notification', modalStateErrors.join(', '), 'error');
        } else if (result.error)
        {
          eventEmitter.emit('notification', result.error.message, 'error');
          }
        break;
      case 401:
        console.log(result.error.message);
        eventEmitter.emit('notification', result.error.message, 'error');
        break;
      case 403:
        console.log(result.error.message);
        eventEmitter.emit('notification', result.error.message, 'error');
        break;
      case 404:
        console.log(result.error.message);
        eventEmitter.emit('notification', result.error.message, 'error');
        break;
      case 409:
        console.log(result.error.message);
        eventEmitter.emit('notification', result.error.message, 'error');
        break;
      case 500:
        console.log("Catch 500");
        console.log(result.error.message);
        router.navigate("/server-error");
        break;
      default:
        break;
    }
    if (result.result) {
      return Promise.reject(result.result);
    }
    return Promise.reject(result);
  }
);

const FetchWithSWR = (url: string, params?: URLSearchParams) => {
  const fetcher = () => axios.get(url, { params }).then(responseBody);
  const { data, isLoading, error, mutate } = useSWR([url, params], fetcher, {
    revalidateOnFocus: false,
    revalidateOnReconnect: false,
    refreshWhenOffline: false,
    refreshWhenHidden: false,
    refreshInterval: 0,
  });
  return { data, isLoading, error, mutate };
};

export const requests = {
  get: (url: string, params?: URLSearchParams) => FetchWithSWR(url, params),
  post: (url: string, body: {}) => axios.post(url, body).then(responseBody),
  postFormData: (url: string, body: any) => {
    const headers =
      body instanceof FormData ? { "Content-Type": "multipart/form-data" } : {};
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

const Users = {
  filter: (query?: UserQuery) => {
    const queryString = getUserQueryString(query);
    return requests.get(`api/Users?${queryString}`);
  },
  details: (id: string) => requests.get(`/api/users/${id}`),
  disable: (id: string) => requests.put(`api/users/disable/${id}`, {}),
  update: (id: string, values: EditUserRequest) =>
    requests.put(`/api/users/${id}`, values),
  create: (values: CreateUserRequest) =>
    requests.post("api/users/create", values),
};

const Authentication = {
  login: (values: {}) => requests.post("api/auth/login", values),
  changePassword: (values: {}) =>
    requests.post("api/auth/changepassword", values),
};

const Category = {
  all: () => requests.get(`api/category`),
  create: (values: {}) => requests.post("api/category", values),
};

const Asset = {
  filter: (query?: FilterAssetRequest) => {
    const queryString = getAssetQueryString(query);
    return requests.get(`api/Asset?${queryString}`);
  },
  create: (values: AssetCreationRequest) =>
    requests.post("api/asset/create", values),
  details: (id: string) => requests.get(`/api/asset/getAssetById?Id=${id}`),
};

const agent = {
  Product,
  Authentication,
  Users,
  Category,
  Asset,
};

export default agent;
