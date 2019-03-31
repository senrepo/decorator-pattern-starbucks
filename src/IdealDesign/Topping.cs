namespace src.IdealDesign
{
    public class Milk : Beverage
    {
        private IBeverage beverage;

        public Milk(IBeverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Milk";
        }

        public override double GetCost()
        {
            return 0 + beverage.GetCost();
        }
    }

    public class Chocholate : Beverage
    {
        private IBeverage beverage;

        public Chocholate(IBeverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Chocolate";
        }

        public override double GetCost()
        {
            return .25 + beverage.GetCost();
        }
    }    

    public class WhipCream : Beverage
    {
        private IBeverage beverage;

        public WhipCream(IBeverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", WhipCream";
        }

        public override double GetCost()
        {
            return .25 + beverage.GetCost();
        }
    }     
}