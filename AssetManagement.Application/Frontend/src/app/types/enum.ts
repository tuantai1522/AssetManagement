export enum Gender {
  Male = "Male",
  Female = "Female",
}

export enum Type {
  Staff = "Staff",
  Admin = "Admin",
}

export enum AssetStateEnum {
  Available = 1,
  NotAvailable = 2,
  WaitingForRecycling = 3,
  Recycled = 4,
  Assigned = 5,
}

export enum AssignmentStateEnum {
    "Waiting for acceptance" = 1,
    "Accepted" = 2,
    "Declined" = 3,
    "Waiting for returning" = 4,
    "Returned" = 5
}

export enum ReturningRequestStateEnum {
  "Completed" = 1,
  "Waiting for returning" = 2,
}
