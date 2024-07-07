namespace ProgrammingChallenges.ObjectOriented;

public class SmartCar : Car
{
    public SmartCar(int mileage, int maxSpeed) : base(mileage, maxSpeed)
    {
    }
    
    public override void Honk()
    {
        Console.WriteLine("Tuut, tuut!");
    }
}