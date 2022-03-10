namespace lab;

public class StupidDuck : Duck
{
    public StupidDuck(Strategy quackStrategy, Strategy swimStrategy, Strategy flyStrategy) :
        base(quackStrategy, swimStrategy, flyStrategy)
    {
    }

    public override void display()
    {
        Console.WriteLine("2D>3D");
    }
}