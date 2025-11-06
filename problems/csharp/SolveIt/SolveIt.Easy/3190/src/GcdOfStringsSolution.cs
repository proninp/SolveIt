namespace SolveIt.Easy._3190.src;

public sealed class GcdOfStringsSolution
{
    public string GcdOfStrings(string str1, string str2)
    {
        if (str1 + str2 != str2 + str1)
        {
            return string.Empty;
        }

        var a = Math.Max(str1.Length, str2.Length);
        var b = Math.Min(str1.Length, str2.Length);

        while (b != 0)
        {
            var tmp = a % b;
            a = b;
            b = tmp;
        }

        return str1.Substring(0, a);
    }
}