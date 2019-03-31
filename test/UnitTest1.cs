using System;
using Xunit;
using src;

namespace test
{
    public class UnitTest1
    {
        [Fact]
        public void InitialDesign()
        {
            /* REQUIREMENT
            
            Every Starbucks item has Description and Cost associated that.
            Beverage Types - HouseBlend, Decaf, Espresso and the base cost varies
            Some toppings cost are free like Milk, Sugar, Honey and some toppings are cost associated such as Chocolate, Whip Cream.
            Toppings can be added more than once such as "Double Chocolate and "Double Whip Cream"
            Should the print the label with type and toppings and final cost
            
             */

            var darkRoast = new src.InitialDesign.DarkRoast();
            darkRoast.AddTopping(new src.InitialDesign.Milk());
            darkRoast.AddTopping(new src.InitialDesign.Sugar());
            darkRoast.AddTopping(new src.InitialDesign.Chocolate());
            var description = darkRoast.GetDescription();

            var espresso = new src.InitialDesign.Espresso();
            espresso.AddTopping(new src.InitialDesign.Milk());
            espresso.AddTopping(new src.InitialDesign.WhipCream());
            espresso.AddTopping(new src.InitialDesign.WhipCream());
            description = espresso.GetDescription();

            /*
                ISSUE With this approach
                Basically this approach takes strategy pattern.
                In the Strategy pattern, the Base class created with common behaviorus among all beverages
                And Class (Entities) created for varying behaviours for ex - Toppings vary (Sugar, Milk, Chocolate & Wipcream) in products like DarkRoast, Decaf and Espresso
                In any changes in the Behaviour class such as WipCream topping is giving discount only certain beverages. In such case these would go in all Beverage class which is creating the impact. 
                In nutshell, strategy pattern, the Beverage class takes the toppings as dependent objects and mutates itself
                In the Decorator pattern, the Beverage class passed to Topping class and the Topping class mutate the Beverage class
             */

        }


        [Fact]
        public void IdealDesign()
        {
            /* REQUIREMENT
            
            Every Starbucks item has Description and Cost associated that.
            Beverage Types - HouseBlend, Decaf, Espresso and the base cost varies
            Some toppings cost are free like Milk, Sugar, Honey and some toppings are cost associated such as Chocolate, Whip Cream.
            Toppings can be added more than once such as "Double Chocolate and "Double Whip Cream"
            Should the print the label with type and toppings and final cost
            
             */

            src.IdealDesign.IBeverage darkRoast = new src.IdealDesign.DarkRoast();
            darkRoast = new src.IdealDesign.Milk(darkRoast);
            darkRoast = new src.IdealDesign.Chocholate(darkRoast);
            darkRoast = new src.IdealDesign.WhipCream(darkRoast);

            var description = darkRoast.GetDescription();
            var cost = darkRoast.GetCost();
            Assert.Equal("DarkRoast, Milk, Chocolate, WhipCream", description);
            Assert.Equal(1.50, cost);

            src.IdealDesign.IBeverage espresso = new src.IdealDesign.DarkRoast();
            espresso = new src.IdealDesign.Milk(darkRoast);
            espresso = new src.IdealDesign.Chocholate(darkRoast);
            espresso = new src.IdealDesign.WhipCream(darkRoast);
            description = espresso.GetDescription();

            /*
                The good thing about this approach is - 
                The beverage (orignal component) object is passed to decorater objects
                The decorator objects can mutate the the original component
                If any changes in the docorater affect the decorator class and it will not impact the component class (Beverage)


                Principle : Attache the additional responsibility to the object dynamically with decorators
                Decorators change the behavior of their components by adding new functionality before and/or after (or even in place of) method calls to the component.
             */

        }
    }
}
