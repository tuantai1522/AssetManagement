import { requests } from "./agent";

export const User = {
  filter: () => requests.get("users"),
};
