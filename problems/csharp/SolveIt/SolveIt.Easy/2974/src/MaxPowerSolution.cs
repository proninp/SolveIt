namespace SolveIt.Easy._2974.src;

public class MaxPowerSolution
{
    public int MaxPower(string s) {
        var maxPower = 1;
        var power = 1;
        for (var i = 1; i < s.Length; i++)
        {
            power = s[i] == s[i - 1] ? power + 1 : 1; 
            if (maxPower < power)
            {
                maxPower = power;
            }
        }
        return maxPower;
    }
}