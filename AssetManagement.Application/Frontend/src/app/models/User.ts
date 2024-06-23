export interface User {
  id: string;
  userName: string;
  role: string;
  token?: string;
  isPasswordChanged: boolean;
}

export interface FilterUser {
  id: string;
  staffCode: string;
  fullName?: string;
  username?: string;
  joinedDate?: Date;
  types: string[];
}
