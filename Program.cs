// int saleAmount = 1001;
// int discount = saleAmount > 1000 ? 100 : 50;
// Console.WriteLine($"Discount: {discount}");
// Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

Random rndm = new Random();

int number = rndm.Next(1, 11); // Generate a number between 1 and 1000.

// if (number <= 5)
// {
//     Console.WriteLine("Heads");
// }
// else
// {
//     Console.WriteLine("Tails");
// }

// Console.WriteLine($"{number}");

string result = (number <= 5 ? "Heads" : "Tails");
Console.WriteLine(result);

Console.WriteLine($"result: {(number <= 5 ? "heads" : "Tails")}");