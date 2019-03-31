using System.Collections.Generic;

namespace src.InitialDesign
{

    public interface IBeverage
    {
        string Name { get; set; }
        void AddTopping(ITopping topping);
        string GetDescription();
        double GetCost();
    }

    public abstract class Beverage : IBeverage
    {
        protected List<ITopping> Toppings { get; set; } = new List<ITopping>();
        public abstract string Name { get; set; }
        protected abstract double cost { get; set; }

        public void AddTopping(ITopping topping)
        {
            Toppings.Add(topping);
        }

        public string GetDescription()
        {
            string description = this.Name + ", ";
            foreach (var topping in Toppings)
            {
                description += topping.Name + ", ";
            }

            description += $"Totoal Cost is {this.GetCost()}";

            return description;
        }

        public double GetCost()
        {
            var totalCost = this.cost;
            foreach (var topping in Toppings)
            {
                totalCost += topping.Cost;
            }
            return totalCost;
        }
    }

    public class DarkRoast : Beverage
    {
        public override string Name { get; set; } = "DarkRoast";
        protected override double cost { get; set; } = 1;
    }

    public class Decaf : Beverage
    {
        public override string Name { get; set; } = "Decaf";
        protected override double cost { get; set; } = 1;
    }

    public class Espresso : Beverage
    {
        public override string Name { get; set; } = "Espresso";
        protected override double cost { get; set; } = 1;
    }
}