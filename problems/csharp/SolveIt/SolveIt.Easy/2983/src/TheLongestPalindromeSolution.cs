namespace SolveIt.Easy._2983.src;

public class TheLongestPalindromeSolution
{
    public int LongestPalindrome(string s)
    {
        var vocabulary = new Dictionary<char, int>();
        foreach (var c in s)
        {
            vocabulary.TryAdd(c, 0);
            vocabulary[c]++;
        }

        var pairs = 0;
        var isSingleExists = false;
        foreach (var kvp in vocabulary)
        {
            pairs += kvp.Value > 1 ? kvp.Value / 2 : 0;
            ;
            if (kvp.Value % 2 != 0)
            {
                isSingleExists = true;
            }
        }

        return pairs * 2 + (isSingleExists ? 1 : 0);
    }
}