string[] tvShows = { "Firefly", "Office", "The Last of Us", "Friends", "Twin Peaks", "House", "Stranger Things" };
string[] food = { "sushi", "pizza", "Chinese takeaway", "burger and chips", "chicken wings", "chips", "popcorn" };
string[] drinks = { "mineral water", "Coca-Cola", "apple juice", "milk", "beer" };

string randomMovie = PickRandomFromArray(tvShows);
string randomFood = PickRandomFromArray(food);
string randomDrink = PickRandomFromArray(drinks);

Console.WriteLine($"I recommend you to watch {randomMovie} tonight.");
Console.WriteLine($"Order some {randomFood} and {randomDrink}.");

PickRandomFromArray(tvShows);
PickRandomFromArray(food);
PickRandomFromArray(drinks);

static string PickRandomFromArray(string[] SomeArray)
{
    Random rnd = new Random();

    int randomIndex = rnd.Next(0, SomeArray.Length);
    string randomElement = SomeArray[randomIndex];
    return randomElement;
}


//Random rnd = new Random();

//int randomIndex = rnd.Next(0, tvShows.Length);

////Console.WriteLine(randomIndex);

////Console.WriteLine(tvShows[randomIndex]);

//string randomMovie  = tvShows[randomIndex];
//Console.WriteLine(randomMovie);

//randomIndex = rnd.Next(0, food.Length);
//string randomFood = food[randomIndex];
//Console.WriteLine(randomFood);

//randomIndex = rnd.Next(0, drinks.Length);
//string randomDrink = drinks[randomIndex];
//Console.WriteLine(randomDrink);