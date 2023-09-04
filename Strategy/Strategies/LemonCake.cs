using StrategyCake.Model;

namespace StrategyCake.Strategies;

public class LemonCake : ICakeStrategy
{
    public List<Ingredient> GetIngredients()
    {
        var ingredients = new List<Ingredient>
        {
            new Ingredient(5, "", "free-range eggs"),
            new Ingredient(300, "g", "caster sugar"),
            new Ingredient(140, "ml", "double cream"),
            new Ingredient(3, "", "lemons, zest only"),
            new Ingredient(1.5m, "tbsp", "dark rum"),
            new Ingredient(1, "pinch", "salt"),
            new Ingredient(80, "g", "unsalted butter"),
            new Ingredient(240, "g", "plain flour"),
            new Ingredient(0.5m, "tsp", "baking powder"),
        };
        return ingredients;
    }

    public List<string> GetMethod()
    {
        var method = new List<string>
        {
            "Preheat the oven to 180C/350F/Gas 4. Lightly butter a 26cm x 9cm x 8cm/10in x 3½in x 3in loaf tin and line it with greaseproof paper.",
            "In a large mixing bowl, whisk together the eggs, sugar, cream, lemon zest, rum, salt and butter.",
            "Sift the flour and baking powder into a separate bowl then whisk it into the egg mixture until you have a smooth batter.",
            "Pour the batter into the prepared tin and bake in the oven for 50-60 minutes, turning halfway through cooking. The cake is cooked when a knife blade inserted into the middle comes out clean."
        };
        return method;
    }
}