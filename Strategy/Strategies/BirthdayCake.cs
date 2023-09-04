using StrategyCake.Model;

namespace StrategyCake.Strategies;

public class BirthdayCake : ICakeStrategy
{
    public List<Ingredient> GetIngredients()
    {
        var ingredients = new List<Ingredient>
        {
            new Ingredient(225, "g", "self-raising flour"),
            new Ingredient(2, "tsp", "baking powder"),
            new Ingredient(4, "", "eggs"),
            new Ingredient(225, "g", "soft margarine"),
            new Ingredient(225, "g", "caster sugar"),
            new Ingredient(6, "drops", "vanilla extract"),
            new Ingredient(2, "tsp", "milk")
        };
        return ingredients;
    }

    public List<string> GetMethod()
    {
        var method = new List<string>
        {
            "Preheat the oven to 160ºC/140ºC fan",
            "Line your baking tin",
            "Sift the self-raising flour and baking powder into a large bowl.",
            "Add the remaining ingredients and beat until thoroughly mixed.",
            "Pour into the tin",
            "Bake for 30-35 minutes.",
            "Leave to cool in the tin for about 10 minutes and then move to a wire rack to cool completely"
        };
        return method;
    }
}