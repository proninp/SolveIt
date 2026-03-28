package space.solveit.easy.t2858;

// https://solvit.space/coding/2858

import java.util.Arrays;

public class Solution {
    public int missingNumber(int[] nums) {
        var s = nums.length * (nums.length + 1) / 2;
        return s - Arrays.stream(nums).sum();
    }
}