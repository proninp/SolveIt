namespace SolveIt.Easy._2983.src;

public class TheLongestPalindromeSolution
{
    public int LongestPalindrome(string s)
    {
        Span<int> vocabularyFreq = stackalloc int[128];
        foreach (var ch in s)
        {
            vocabularyFreq[ch]++;
        }

        var pairs = 0;
        var hasOdd = false;
        foreach (var freq in vocabularyFreq)
        {
            pairs += freq / 2;
            if ((freq & 1) == 1)
            {
                hasOdd = true;
            }
        }

        return pairs * 2 + (hasOdd ? 1 : 0);
    }
}