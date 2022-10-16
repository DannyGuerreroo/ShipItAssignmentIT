namespace ShipItAssignmentIT
{
    internal class Shipper
    {   
        // List for the shipment items
        List<IShippable> InventoryItems = new List<IShippable>();
        
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

        // The number of each item in the list is calculated for the manifest, with the provided name
        public int ListItemCount(string ItemName) 
        {
            int ItemCount = InventoryItems.FindAll(Item => Item.Product.StartsWith(ItemName)).Count;
            return ItemCount;
        }
    }
}
