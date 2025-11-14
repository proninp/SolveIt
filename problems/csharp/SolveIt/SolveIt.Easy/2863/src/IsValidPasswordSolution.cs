namespace SolveIt.Easy._2863.src;

public class IsValidPasswordSolution
{
    public bool IsValidPassword(string password)
    {
        if (password.Length < 8)
            return false;
        var isDigitExists = false;
        var isUpperExists = false;
        var isNecessarySymbol = false;
        foreach (var c in password)
        {
            if (char.IsLetter(c))
            {
                if (!((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z')))
                    return false;
            }
            else if (char.IsDigit(c))
            {
                isDigitExists = true;
            }
            else if (c == '_' || c == '#' || c == '%')
            {
                isNecessarySymbol = true;
            }
            else
            {
                return false;
            }
            if (char.IsUpper(c))
                isUpperExists = true;
        }
        if  (!isDigitExists || !isUpperExists || !isNecessarySymbol)
            return false;
        if (IsPalindromeIgnoreCase(password))
        {
            return false;
        }
        return true;
    }

    static bool IsPalindromeIgnoreCase(string s)
    {
        for (var i = 0; i < s.Length / 2; i++)
        {
            if (char.ToLower(s[i]) != char.ToLower(s[s.Length - 1 - i]))
            {
                return false;
            }
        }
        return true;
    }
}