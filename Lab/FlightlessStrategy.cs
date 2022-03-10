namespace lab;

public class FlightlessStrategy : Strategy
{
    public override void action()
    { 
        Console.WriteLine("I can't fly");
    }
}