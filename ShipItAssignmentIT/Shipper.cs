namespace ShipItAssignmentIT
{
    internal class Shipper
    {
        List<IShippable> InventoryItems = new List<IShippable>();
        // List for the shipment items
        public void Add(IShippable Item) // Function to add an item to the list
        {
            InventoryItems.Add(Item);
        }

        public decimal ComputeCost() 
        // Function to compute the total cost of the items in the list
        {
            decimal TotalCost = 0M;
            foreach (IShippable Item in InventoryItems)
            {
                TotalCost = TotalCost + Item.ShipCost;
            }
            return TotalCost;
        }

        // The number of each item in the list is calculated for the manifest
        public int ListBikes() // Counts the number of Bicycles in the inventory list
        {
            int BikeCount = InventoryItems.FindAll(Item => Item.Product.StartsWith("Bicycle")).Count;
            return BikeCount;
        }
        public int ListMowers() // Counts the number of Lawn Mowers in the inventory list
        {
            int MowerCount = InventoryItems.FindAll(Item => Item.Product.StartsWith("Lawn Mower")).Count;
            return MowerCount;
        }
        public int ListGloves() // Counts the number of Gloves in the inventory list
        {
            int GloveCount = InventoryItems.FindAll(Item => Item.Product.StartsWith("Baseball Glove")).Count;
            return GloveCount;
        }
        public int ListCrackers() // Counts the number of Crackers in the inventory list
        {
            int CrackerCount = InventoryItems.FindAll(Item => Item.Product.StartsWith("Crackers")).Count;
            return CrackerCount;
        }

    }
}
