namespace AssetManagement.Application.Common.Validations;

public static class RegexPatterns
{
    public const string Alphabet = @"^[a-zA-Z]+$";
    public const string AlphabetAndWhiteSpace = @"^[a-zA-Z\s]+$";
    public const string AlphabetAndNumber = @"^[a-zA-Z0-9]+$";
    public const string AlphabetWhiteSpaceAndNumber = @"^[a-zA-Z0-9\s]+$";
}

