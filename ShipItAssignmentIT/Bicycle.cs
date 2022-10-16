namespace ShipItAssignmentIT
{
    internal class Bicycle : IShippable
    {
        public decimal ShipCost
        { get { return 20.50M;} }

        public string Product
        { get { return "Bicycle"; } }
    }
}
