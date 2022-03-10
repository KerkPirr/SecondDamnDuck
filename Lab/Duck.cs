namespace lab;

public class Duck
    {
        private Strategy quackStrategy;
        private Strategy swimStrategy;
        private Strategy flyStrategy;

        public Duck(Strategy quackStrategy, Strategy swimStrategy, Strategy flyStrategy)
        {
            this.quackStrategy = quackStrategy;
            this.flyStrategy = flyStrategy;
            this.swimStrategy = swimStrategy;
        }

        public virtual void display()
        {
            Console.WriteLine("Duck>humans");
        }

        public void quack()
        {
            quackStrategy.action();
        }

        public void swim()
        {
            swimStrategy.action();
        }

        public void fly()
        {
            flyStrategy.action();
        }
    }
    