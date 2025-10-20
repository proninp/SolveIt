namespace SolveIt.Easy._3019.src;

public sealed class TransferZeros
{
    public static void MoveZeroes(int[] nums)
    {
        var insert = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                if (insert != i)
                {
                    nums[insert] = nums[i];
                    nums[i] = 0;
                }
                insert++;
            }
        }
    }
}