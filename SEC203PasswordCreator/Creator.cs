using System;

public class Program
{
    public static void Main()
    {
        //Test password parameters
        bool includeLowercase = true;
        bool includeUppercase = true;
        bool includeNumber = true;
        bool includePunctuation = false;
        int passwordLength= 16;

        //Creates a randomly generated password
        string password = Creator.CreatePassword(includeLowercase, includeUppercase, includeNumber, 
            includePunctuation, passwordLength);

        //Checks to see if the passsword is valid and fits the criteria set 
        while (!Creator.passwordIsValid(includeLowercase, includeUppercase, includeNumber, 
            includePunctuation, password))
        {
            password = Creator.CreatePassword(includeLowercase, includeUppercase, includeNumber, 
                includePunctuation, passwordLength);
        }

        //Prints password
        Console.WriteLine(password);
    }
}

public static class Creator
{
    //Password creator
    public static string CreatePassword(bool includeLowercase,
        bool includeUppercase, bool includeNumber, bool includePunctuation,
        int passwordLength)
    {
        //Includes lowercase, uppercase, numbers and punctuation as options to include in the password
        const string lowercase = "abcdefghijklmnopqrstuvwxyz";
        const string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string numbers = "1234567890";
        const string punctuation = "!£$%^&*()?@<>,./#";
        //Sets a minimum and maximum length so it isn't to short to be vulnerable yet to large to remember or be too large to be suitable
        const int passwordMinimumLength = 8;
        const int passwordMaximumLength = 20;
        //prevents characters from repeating eachother more than twice 
        const int passwordMaxRepeatingCharacter = 2;
        //Sets the initial character set to be empty
        string characterSet = "";

        //Checks to see if the password is between the parameters set
        if (passwordLength < passwordMinimumLength || passwordLength > passwordMaximumLength)
        {
            return "Password length must be between 8 and 50.";
        }

        //Characters and symbols are entered to the character set as the user desires. These will be the characters that the password will be made up of 
        if (includeLowercase)
        {
            characterSet += lowercase;
        }
        if (includeUppercase)
        {
            characterSet += lowercase;
        }
        if (includeNumber)
        {
            characterSet += lowercase;
        }
        if (includePunctuation)
        {
            characterSet += lowercase;
        }

        //Sets the length of the password equal to the specified length
        char[] password = new char[passwordLength];
        //Gets the length of the character set
        int characterSetLength = characterSet.Length;

        System.Random random = new System.Random();
        //Creates the random, secure password one character at a time
        for (int characterPosition = 0; characterPosition < passwordLength; characterPosition++)
        {
            password[characterPosition] = characterSet[random.Next(characterSetLength - 1)];
        
            //Checks that there are no characters repeating more than twice. If so, then they are re-randomized to a different character
            bool maxIdenticalCharactersExeeded = characterPosition > passwordMaxRepeatingCharacter
                && password[characterPosition] == password[characterPosition - 1]
                && password[characterPosition - 1] == password[characterPosition - 2];

            if(maxIdenticalCharactersExeeded)
            {
                characterPosition--;
            }
        }
        return string.Join(null, password);
    }

    //Function to check that the password is valid and fits within the set rules
    public static bool passwordIsValid(bool includeLowercase, bool includeUppercase, bool includeNumber, 
        bool includePunctuation, string password)
    {
        const string regexLowercase = "abcdefghijklmnopqrstuvwxyz";
        const string regexUppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string regexNumber = "1234567890";
        const string regexPunctuation = "!£$%^&*()?@<>,./#";

        //Regex - regular expression
        //Checks if character individually
        bool lowercaseIsValid = !includeLowercase || (includeLowercase && Regex.IsMatch(password, regexLowercase));
        bool uppercaseIsValid = !includeUppercase || (includeUppercase && Regex.IsMatch(password, regexUppercase));
        bool numberIsValid = !includeNumber || (includeNumber && Regex.IsMatch(password, regexNumber));
        bool punctuatuationIsValid = !includePunctuation || (includpunctuation && Regex.IsMatch(password, regexPunctuation));

        //Returns once all is valid
        return lowerCaseIsValid && upperCaseIsValid && numberIsValid && punctuationIsValid;
    } 
}
