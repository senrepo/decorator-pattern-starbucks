namespace src.IdealDesign
{

    public interface IBeverage
    {
        string GetDescription();
        double GetCost();
    }


    public abstract class Beverage : IBeverage
    {
        protected string description = string.Empty;
        public abstract double GetCost();

        public abstract string GetDescription();

    }

    public class DarkRoast : Beverage
    {

        public override string GetDescription()
        {
            return "DarkRoast";
        }

        public override double GetCost()
        {
            return 1.0;
        }
    }

    public class Decaf : Beverage
    {
        public override string GetDescription()
        {
            return "Decaf";
        }

        public override double GetCost()
        {
            return 1.25;
        }
    }  

    public class Espresso : Beverage
    {
        public override string GetDescription()
        {
            return "Espresso";
        }

        public override double GetCost()
        {
            return 1.50;
        }
    }       
}