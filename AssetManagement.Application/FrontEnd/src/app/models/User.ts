export interface User {
  id: string;
  userName: string;
  role: string;
  token?: string;
  isPasswordChanged: boolean;
}
