namespace SolveIt.Easy._3212;

public class BinarySearchSolution
{
    public int Search(int[] nums, int target)
    {
        int left = 0, right = nums.Length - 1;
        while (left <= right)
        {
            var mid = (left + right) / 2;
            if (nums[mid] == target)
                return mid;
            if (nums[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return -1;
    }
}