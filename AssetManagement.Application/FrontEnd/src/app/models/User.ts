export interface User {
  id: string;
  name: string;
}

export interface FilterUser {
  id: string;
  staffCode: string;
  fullName?: string;
  username?: string;
  joinedDate?: Date;
  types: Array<string>[];
}
