import { requests } from "./agent";

export const UserApi = {
  filter: () => requests.get("api/Users"),
};
