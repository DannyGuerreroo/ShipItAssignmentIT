namespace ShipItAssignmentIT
{
    internal interface IShippable
    {
        decimal ShipCost { get; }
        string Product { get; }
    }
}
