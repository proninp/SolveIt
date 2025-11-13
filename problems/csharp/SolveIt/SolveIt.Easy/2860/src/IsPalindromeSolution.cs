using System.Text;

namespace SolveIt.Easy._2860.src;

public class IsPalindromeSolution
{
    public bool IsPalindrome(string s)
    {
        var left = 0;
        var right = s.Length - 1;

        while (left < right)
        {
            while (left < right && !char.IsLetterOrDigit(s[left]))
                left++;
            while (left < right && !char.IsLetterOrDigit(s[right]))
                right--;
            if (char.ToLower(s[left]) != char.ToLower(s[right]))
                return false;
            left++;
            right--;
        }

        return true;
    }
}