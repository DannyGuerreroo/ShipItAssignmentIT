using ShipItAssignmentIT;
// By Danny Guerrero

Shipper Shipper = new Shipper(); // Instantiating shipper class

Bicycle Bicycle = new Bicycle(); // Instantiating the shipment items
LawnMower LawnMower = new LawnMower();
BaseballGlove BaseballGlove = new BaseballGlove();
Crackers Crackers = new Crackers();

bool Looper = true;
while (Looper == true) // Creating a loop for the menu, so it can be reused
{
    // The options for the user:
    Console.WriteLine("Choose an option from the following: (Type the number)");
    Console.WriteLine("1: Add Bicycle");
    Console.WriteLine("2: Add Lawn Mower");
    Console.WriteLine("3: Add Baseball Glove");
    Console.WriteLine("4: Add Crackers");
    Console.WriteLine("5: List Shipment Items");
    Console.WriteLine("6: Compute Shipping Charges");
    Console.WriteLine(" ");

    char sInput = Console.ReadKey().KeyChar; // Reading user input
    Console.WriteLine(" ");
    Console.WriteLine(" ");
    switch (sInput) // Option selected based on user input
    {
        case '1': // Adds a bicycle to manifest
            Console.WriteLine("1 Bicycle has been added.");
            Console.WriteLine(" ");
            Shipper.Add(Bicycle);
            break;
        case '2': // Adds a lawn mower to manifest
            Console.WriteLine("1 Lawn Mower has been added.");
            Console.WriteLine(" ");
            Shipper.Add(LawnMower);
            break;
        case '3': // Adds a baseball glove to manifest
            Console.WriteLine("1 Baseball Glove has been added.");
            Console.WriteLine(" ");
            Shipper.Add(BaseballGlove);
            break;
        case '4': // Adds crackers to manifest
            Console.WriteLine("1 Crackers has been added");
            Console.WriteLine(" ");
            Shipper.Add(Crackers);
            break;
        case '5': // Displays shipment manifest
            Console.WriteLine("The current shipment manifest:");

            var Bikes = Shipper.ListBikes();
            var Mowers = Shipper.ListMowers();
            var Gloves = Shipper.ListGloves();
            var Cracker = Shipper.ListCrackers();

            // If statements that show the manifest entry if any items have been added
            // They also account for pluralization of items if there are more than one
            if (Bikes > 0)
            {
                if (Bikes > 1)
                {
                    Console.WriteLine(Shipper.ListBikes() + " Bicycles");
                }
                else Console.WriteLine(Shipper.ListBikes() + " Bicycle");
            }
            if (Mowers > 0)
            {
                if (Mowers > 1)
                {
                    Console.WriteLine(Shipper.ListMowers() + " Lawn Mowers");
                }
                else Console.WriteLine(Shipper.ListMowers() + " Lawn Mower");
            }
            if (Gloves > 0)
            {
                if (Gloves > 1)
                {
                    Console.WriteLine(Shipper.ListGloves() + " Baseball Gloves");
                }
                else Console.WriteLine(Shipper.ListGloves() + " Baseball Glove");
            }
            if (Cracker > 0)
            {
                Console.WriteLine(Shipper.ListCrackers() + " Crackers");
            }

            // A unique message in case no items were added yet
            var NumberOfItems = Bikes + Mowers + Gloves + Cracker;
            if (NumberOfItems < 1)
            {
                Console.WriteLine("No items have been added yet.");
            }
            Console.WriteLine(" ");
            break;

        case '6': // Computes the total cost for all items
            Console.WriteLine("Computing shipping charges...");
            Console.WriteLine(" ");

            var ShippingCost = Shipper.ComputeCost();
            Console.WriteLine("The total cost for this order is: $" + ShippingCost);

            Console.WriteLine(" ");
            Console.WriteLine("Thank you for using the Ship It program. Goodbye.");
            Looper = false;
            break;
        default: // In case user inputs incorrect value, tells them to retry
            Console.WriteLine("Incorrect Value Error: Please try again.");
            Console.WriteLine(" ");
            break;
}



}