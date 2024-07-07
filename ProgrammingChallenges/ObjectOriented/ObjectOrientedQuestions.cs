namespace ProgrammingChallenges.ObjectOriented;

public class ObjectOrientedQuestions
{
    public void Main()
    {
        var smartCar = new SmartCar(10000, 70);
        smartCar.Honk();

        var car = new Car();
        
        Console.WriteLine($"SmartCar max speed = {smartCar.GetMaxSpeed()}");
        Console.WriteLine($"Car max speed = {car.GetMaxSpeed()}");

        smartCar.Honk();
    }
}


