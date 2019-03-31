namespace src.InitialDesign
{
    public interface ITopping
    {
        string Name {get; }
        double Cost {get; }
    }

    public class Milk : ITopping
    {
        public string Name { get => "Milk"; }
        public double Cost { get => 0; }
    }

    public class Sugar : ITopping
    {
        public string Name { get => "Sugar"; }
        public double Cost { get => 0; }
    }

    public class Chocolate : ITopping
    {
        public string Name { get => "Chocolate"; }
        public double Cost { get => 0.25; }
    }

    public class WhipCream : ITopping
    {
        public string Name { get => "WhipCream"; }
        public double Cost { get => 0.30; }
    }    

}