namespace SolveIt.Easy._2870.src;

public sealed class SumOfTwo
{
    public int[] TwoSum(int[] nums, int target)
    {
        var map = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++)
        {
            if (map.TryGetValue(target - nums[i], out var index))
            {
                return [index, i];
            }
            
            map[nums[i]] = i;
        }
        return [-1, -1];
    }
}