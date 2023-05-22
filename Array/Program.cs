//   ===================ARRAY==================

//Declare Array
string[] fraudulentOrderIDs = new string[3];


//Assign the value of array
fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";

/*fraudulentOrderIDs[3] = "D000";*/
// ERROR Index was outside the bounds of the array


Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
//Reassign the value of array
fraudulentOrderIDs[0] = "F000";
Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
/*Console.WriteLine($"Third: {fraudulentOrderIDs[3]}");*/
// ERROR Index was outside the bounds of the array

//Initialize an array
string[] fraudulentOrderIDs2 = { "A123", "B234", "C345" };

//Length of Array
Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");


//   ===================FOREACH==================

Console.WriteLine("List of ID: ");
foreach(string orderID in fraudulentOrderIDs)
{
    Console.WriteLine(orderID);
}

int[] inventory = { 203, 569, 15, 35, 8798 };
int totalInventory = 0;
int bin = 0;
Console.WriteLine("Total inventory: ");
foreach ( int item in inventory)
{
    bin++;
    totalInventory += item;
    Console.WriteLine($"Bin {bin} has {item} items. Running total: {totalInventory}");
}
Console.WriteLine("Total inventory: " + totalInventory);


/*Your team has found a pattern. Orders that start with the letter "B" encounter fraud at a rate 25 times greater than the normal rate. You'll write new code that outputs the Order ID of new orders where the Order ID starts with the letter "B". This will be used by the fraud team to investigate further.*/

string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string orderID in orderIDs)
{
    if (orderID.StartsWith("B"))
    {
        Console.WriteLine($"{orderID} can be a potentially fraudulent order");
    }
}
