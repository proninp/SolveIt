namespace SolveIt.Middle._2935.src;

public sealed class ArraysIntersectionTwo
{
    public int[] Intersect(int[] nums1, int[] nums2) {
        var frequencies = new Dictionary<int, int>();
        foreach (var num in nums1)
        {
            frequencies[num] = frequencies.TryGetValue(num, out var frequency) ? frequency + 1 : 1;
        }

        var output = new List<int>();
        foreach (var num in nums2)
        {
            if (frequencies.TryGetValue(num, out var frequency) && frequency > 0)
            {
                output.Add(num);
                frequencies[num] = frequency - 1;
            }
        }
        return output.ToArray();
    }
}