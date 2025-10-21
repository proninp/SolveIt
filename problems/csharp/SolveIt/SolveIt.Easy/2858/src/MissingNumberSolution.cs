namespace SolveIt.Easy._2858.src;

public sealed class MissingNumberSolution
{
    public int MissingNumber(int[] nums) {
        return nums.Length * (nums.Length + 1) / 2 - nums.Sum();
    }
}