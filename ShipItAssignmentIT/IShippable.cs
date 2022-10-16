namespace ShipItAssignmentIT
{
    internal interface IShippable // The interface that the shipment items inherit from
    {
        decimal ShipCost { get; }
        string Product { get; }


    }
}
