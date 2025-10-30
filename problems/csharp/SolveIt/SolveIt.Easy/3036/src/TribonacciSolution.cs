namespace SolveIt.Easy._3036.src;

public class TribonacciSolution
{
    public int Tribonacci(int n)
    {
        int[] current = [0, 1, 1];
        for (var i = 3; i <= n; i++)
        {
            var next = current.Sum();
            current[0] = current[1];
            current[1] = current[2];
            current[2] = next;
        }
        return n < 3 ? current[n] : current[^1];
    }
}