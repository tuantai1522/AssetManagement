﻿namespace AssetManagement.Application.Common.Constants
{
    public static class ErrorStrings
    {
        public const string USER_NOT_FOUND = "User not found";
        public const string UNAUTHORIZED_USER = "Unauthorized user";
        public const string INVALID_FIRSTNAME = "First name cannot be more than one word";
        public const string INVALID_ROLE = "Type of user is invalid";
        public const string INVALID_DATE_OF_BIRTH = "User is under 18. Please select a different date";
        public const string INVALID_DATE_OF_BIRTH_IN_FUTURE = "Date of birth is in future. Please select a different date";
        public const string INVALID_JOINED_DATE_RELATE_TO_DOB = "User under the age of 18 may not join company. Please select a different date";
        public const string INVALID_JOINED_DATE_RELATE_TO_WEEKDAY = "Joined date is Saturday or Sunday. Please select a different date";
        public const string INVALID_GENDER = "Invalid gender";
        public const string INVALID_LOCATION = "Invalid location";
    }
        public const string ROLE_NOT_DELETED = "User's Role cannot be deleted";
        public const string ROLE_NOT_EXIST = "Role does not exist";
        public const string USER_ROLE_ADD = "Cannot Add Role to User";
		public const string USER_UPDATE = "Cannot Update User";
	}
}
