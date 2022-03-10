namespace lab;

public class programm
{
    public static void Main()
    {
        QuacklessStrategy QuacklessStrategy = new QuacklessStrategy();
        SwimlessStrategy SwimlessStrategy = new SwimlessStrategy();
        FlightlessStrategy FlightlessStrategy = new FlightlessStrategy();
        LoudQuackStrategy LoudQuackStrategy = new LoudQuackStrategy();
        AngryFlightStrategy AngryFlightStrategy = new AngryFlightStrategy();
        AngrySwimStrategy AngrySwimStrategy = new AngrySwimStrategy();

        Duck firstDuck = new StupidDuck(QuacklessStrategy, SwimlessStrategy, FlightlessStrategy);
        Duck secondDuck = new GreenDuck(LoudQuackStrategy, AngrySwimStrategy, AngryFlightStrategy);
        firstDuck.display();
        secondDuck.display();
        
        Console.WriteLine('\n');

        firstDuck.quack();
        secondDuck.quack();
        
        Console.WriteLine('\n');
        
        firstDuck.fly();
        secondDuck.fly();
        
        Console.WriteLine('\n');
        
        firstDuck.swim();
        secondDuck.swim();
    }
    
}