namespace SolveIt.Easy._3208;

public class ClimbStairsSolution
{
    public int ClimbStairs(int n)
    {
        var a = 1;
        var b = 1;
        for (var i = 2; i <= n; i++)
        {
            (a, b) = (a + b, a);
        }
        return a;
    }
}