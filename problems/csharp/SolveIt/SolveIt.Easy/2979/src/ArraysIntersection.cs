namespace SolveIt.Easy._2979.src;

public sealed class ArraysIntersection
{
    public int[] Intersection(int[] nums1, int[] nums2) {
        var frequency = new Dictionary<int, int>();
        foreach (var num in nums1)
        {
            frequency.TryAdd(num, 1);
        }
        foreach (var num in nums2)
        {
            frequency.TryAdd(num, 2);
            frequency[num] |= 2;

        }
        return frequency.Keys.Where(x => frequency[x] == 3).ToArray();
    }
}