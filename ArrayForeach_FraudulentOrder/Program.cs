/*Your team has found a pattern. Orders that start with the letter "B" encounter fraud at a rate 25 times greater than the normal rate. You'll write new code that outputs the Order ID of new orders where the Order ID starts with the letter "B". This will be used by the fraud team to investigate further.*/

string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string orderID in orderIDs)
{
    if (orderID.StartsWith("B"))
    {
        Console.WriteLine($"{orderID} can be a potentially fraudulent order");
    }
}