namespace ShipItAssignmentIT
{
    internal class LawnMower : IShippable
    {
        public decimal ShipCost
        { get{ return 24.00M;} }

        public string Product
        { get { return "Lawn Mower"; } }
    }
}
