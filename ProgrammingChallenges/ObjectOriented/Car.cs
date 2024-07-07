namespace ProgrammingChallenges.ObjectOriented;

public class Car
{
    public Car()
    {
        Mileage = 50000;
        MaxSpeed = 150;
    }

    public Car(int mileage, int maxSpeed)
    {
        Mileage = mileage;
        MaxSpeed = maxSpeed;
    }
    
    private int Mileage { get; set; }
    private int MaxSpeed { get; set; }

    public virtual void Honk()
    {
        Console.WriteLine("Honk, honk");
    }

    public int GetMaxSpeed() => MaxSpeed;
}