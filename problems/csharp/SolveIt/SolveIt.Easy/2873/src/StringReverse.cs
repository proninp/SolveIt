namespace SolveIt.Easy._2873.src;

public class StringReverse
{
    public void ReverseString(string[] s) {
        for (var i = 0; i < s.Length / 2; i++)
        {
            (s[i], s[s.Length - 1 - i]) = (s[s.Length - 1 - i], s[i]);
        }
    }
}