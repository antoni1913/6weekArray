string[] fruitBasket = { "apples", "bananas", "oranges" };

Console.WriteLine($"there are {fruitBasket.Length} fruit in your basket ");




fruitBasket[0] = "pine-apple";
fruitBasket[2] = "grape";


for (int i = 0; i < fruitBasket.Length; i++)
{
    Console.WriteLine(fruitBasket[i]);

}



string[] colors = { "red", "green", "blue", "pink", "yellow" };
Random rnd = new Random();
string randomColor = colors[rnd.Next(0, colors.Length)];
Console.WriteLine($"You should wear {randomColor} today.");