using ProgrammingChallenges.DesignPatterns;

namespace ProgrammingChallenges;

public class DesignPatternsQuestions
{
    public void Main()
    {
        var ff = new FanFactory();
        var fan = ff.CreateFan(FanType.CeilingFan);
        
        fan.SwitchOn();
    }
}