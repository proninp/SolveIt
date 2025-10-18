namespace SolveIt.Easy._3009;

public sealed class RemovingAsterisksFromTheString
{
    public string RemoveStars(string s) {
        var stack = new Stack<char>();
        foreach (var ch in s)
        {
            if (ch == '*')
            {
                if (stack.Count > 0)
                {
                    stack.Pop();
                }
            }
            else
            {
                stack.Push(ch);
            }
        }
        return string.Concat(stack.Reverse());
    }
}