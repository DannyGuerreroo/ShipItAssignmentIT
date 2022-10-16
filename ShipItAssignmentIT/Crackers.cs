namespace ShipItAssignmentIT
{
    internal class Crackers : IShippable
    {
        public decimal ShipCost
        { get{ return 0.57M;} }

        public string Product
        { get { return "Crackers"; } }
    }
}
