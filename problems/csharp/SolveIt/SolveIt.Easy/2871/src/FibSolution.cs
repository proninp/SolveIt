namespace SolveIt.Easy._2871;

public class FibSolution
{
    public int Fib(int n) {
        if (n < 2)
            return n;
        var b = 0;
        var a = 1;
        for (var i = 2; i <= n; i++)
        {
            (b , a) = (a, a + b);
        }
        return a;
    }
}