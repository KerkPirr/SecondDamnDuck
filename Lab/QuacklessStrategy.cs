namespace lab;

public class QuacklessStrategy : Strategy
{
    public override void action()
    {
        Console.WriteLine("*silent*");
    }
}