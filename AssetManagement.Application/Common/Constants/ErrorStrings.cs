namespace AssetManagement.Application.Common.Constants
{
    public static class ErrorStrings
    {
        public const string USER_NOT_FOUND = "User not found";
        public const string UNAUTHORIZED_USER = "Unauthorized user";
        public const string INVALID_FIRSTNAME_CHARACTERS = "First name can only contain alphabet characters";
        public const string INVALID_LASTNAME_CHARACTERS = "last name can only contain alphabet characters and white spaces";
        public const string INVALID_FIRSTNAME_NUMBER_OF_WORDS = "First name cannot be more than one word";
        public const string INVALID_ROLE = "Type of user is invalid";
        public const string INVALID_DATE_OF_BIRTH = "User is under 18. Please select a different date";
        public const string INVALID_DATE_OF_BIRTH_IN_FUTURE = "Date of birth is in future. Please select a different date";
        public const string INVALID_JOINED_DATE_RELATE_TO_DOB = "User under the age of 18 may not join company. Please select a different date";
        public const string INVALID_JOINED_DATE_RELATE_TO_WEEKDAY = "Joined date is Saturday or Sunday. Please select a different date";
        public const string INVALID_GENDER = "Invalid gender";
        public const string INVALID_LOCATION = "Invalid location";

        public const string CANNOT_REMOVE_CURRENT_ROLE = "User's Role cannot be deleted";
        public const string ROLE_NOT_FOUND = "Role does not exist";
        public const string CANNOT_ADD_ROLE_TO_USER = "Cannot Add Role to User";
        public const string CANNOT_UPDATE_USER = "Cannot Update User";
    }
}
