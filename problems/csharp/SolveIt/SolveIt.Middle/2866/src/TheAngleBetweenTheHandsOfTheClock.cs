namespace SolveIt.Middle._2866.src;

public class TheAngleBetweenTheHandsOfTheClock
{
    public double AngleClock(int hour, int minutes)
    {
        const int oneMinDegree = 6;
        const int segmentsInOneHour = 5;
        const int degreesPerHourSegment = 30;
        const int circleDegrees = 360;
        const double minInHour = 60.0;
        
        var minsDegree = oneMinDegree * minutes;
        var hourDegree = (hour % 12) * segmentsInOneHour / minInHour * circleDegrees;
        var hourDegreeRemains = minutes / minInHour * degreesPerHourSegment;
        hourDegree += hourDegreeRemains;
        var handsDiff = Math.Abs(minsDegree - hourDegree);
        return Math.Min(handsDiff, circleDegrees - handsDiff);
    }
}