package space.solveit.easy.t2873;

// https://solvit.space/coding/2873

public class Solution {
    public void reverseString(char[] s) {
        for (var i = 0; i < s.length/2; i++) {
            var t = s[i];
            s[i] = s[s.length - i - 1];
            s[s.length - i - 1] = t;
        }
    }
}
