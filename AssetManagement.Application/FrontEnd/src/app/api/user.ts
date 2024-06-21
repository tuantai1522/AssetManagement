import { requests } from "./agent";

export const Users = {
  filter: () => requests.get("api/Users"),
};
