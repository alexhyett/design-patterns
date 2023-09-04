using StrategyCake.Model;
using StrategyCake.Strategies;

namespace StrategyCake;

public class StrategyCakeProgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine(@"   ____      _          _____          _                   ");
        Console.WriteLine(@"  / ___|__ _| | _____  |  ___|_ _  ___| |_ ___  _ __ _   _ ");
        Console.WriteLine(@" | |   / _` | |/ / _ \ | |_ / _` |/ __| __/ _ \| '__| | | |");
        Console.WriteLine(@" | |__| (_| |   <  __/ |  _| (_| | (__| || (_) | |  | |_| |");
        Console.WriteLine(@"  \____\__,_|_|\_\___| |_|  \__,_|\___|\__\___/|_|   \__, |");
        Console.WriteLine(@"                                                     |___/ ");

        // Select cake
        var cake = SelectCake();
        var strategy = GetStrategy(cake);


        // Ingredients
        var ingredients = strategy.GetIngredients();
        PrintIngredients(ingredients);

        // Method
        Console.WriteLine();
        var method = strategy.GetMethod();
        PrintMethod(method);
    }

    private static void PrintCakeOptions()
    {
        Console.WriteLine("Which cake would you like to bake?");
        Console.WriteLine("1. Birthday Cake");
        Console.WriteLine("2. Red Velvet Cake");
        Console.WriteLine("3. Carrot Cake");
        Console.WriteLine("4. Coffee & Walnut Cake");
        Console.WriteLine("5. Lemon Cake");
        Console.WriteLine("6. Chocolate Fudge Cake");
        Console.WriteLine();

        Console.WriteLine("Select a number between 1 - 6:");
    }


    private static Cake SelectCake()
    {
        int cakeNumber = 0;
        int maxCake = Enum.GetValues(typeof(Cake)).Cast<int>().Max();
        while (cakeNumber <= 0 || cakeNumber > maxCake)
        {
            PrintCakeOptions();
            var input = Console.ReadLine();
            if (!int.TryParse(input, out cakeNumber))
            {
                Console.WriteLine();
                Console.WriteLine("Invalid number entered");
                Console.WriteLine();
            }
        }

        return (Cake)cakeNumber;
    }

    private static ICakeStrategy GetStrategy(Cake cake)
    {
        switch (cake)
        {
            case Cake.BirthdayCake:
                return new BirthdayCake();
            case Cake.RedVelvetCake:
                return new RedVelvetCake();
            case Cake.CarrotCake:
                return new CarrotCake();
            case Cake.CoffeeAndWalnutCake:
                return new CoffeeWalnutCake();
            case Cake.LemonCake:
                return new LemonCake();
            case Cake.ChocolateFudgeCake:
                return new ChocolateFudgeCake();

        }
        return new BirthdayCake();
    }

    private static void PrintIngredients(List<Ingredient> ingredients)
    {
        Console.WriteLine("INGREDIENTS:");
        foreach (var ingredient in ingredients)
        {
            Console.WriteLine($"{ingredient.Quantity} {ingredient.Unit} {ingredient.Item}");
        }
    }

    private static void PrintMethod(List<string> steps)
    {
        Console.WriteLine("METHOD:");
        for (int i = 0; i < steps.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {steps[i]}");
        }
    }
}







