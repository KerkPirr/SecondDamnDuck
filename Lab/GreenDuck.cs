namespace lab;

    public class GreenDuck : Duck
    {
        public GreenDuck(Strategy quackStrategy, Strategy swimStrategy, Strategy flyStrategy) :
            base(quackStrategy, swimStrategy, flyStrategy)
        {
        }
        public override void display()
        {
            Console.WriteLine("I'm Mallard duck");
        }
    }

    