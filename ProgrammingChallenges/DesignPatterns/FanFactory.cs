namespace ProgrammingChallenges.DesignPatterns;

/// <summary>
/// Simple Factory pattern
/// </summary>
public class FanFactory
{
    public IFan CreateFan(FanType fanType)
    {
        switch (fanType)
        {
            case FanType.TableFan:
                return new TableFan();

            case FanType.CeilingFan:
                return new CeilingFan();

            case FanType.ExhaustFan:
                return new ExhaustFan();
        }

        throw new Exception("Unable to create unknown fan");
    }
}