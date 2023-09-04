using StrategyCake.Model;

namespace StrategyCake.Strategies;

public class CoffeeWalnutCake : ICakeStrategy
{
    public List<Ingredient> GetIngredients()
    {
        var ingredients = new List<Ingredient>
        {
            new Ingredient(225, "g", "unsalted butter, softened, plus extra for greasing"),
            new Ingredient(225, "g", "caster sugar"),
            new Ingredient(4, "", "free range eggs"),
            new Ingredient(50, "ml", "strong espresso coffee"),
            new Ingredient(225, "g", "self-raising flour"),
            new Ingredient(75, "g", "walnuts")

        };
        return ingredients;
    }

    public List<string> GetMethod()
    {
        var method = new List<string>
        {
            "Preheat the oven to 180C/350F/Gas 4.",
            "In a bowl, beat the butter and sugar together until very light and pale.",
            "Add the eggs one at a time to the butter and sugar mixture, beating well to completely incorporate each egg before adding the next egg.",
            "Add the espresso to the mixture and stir well.",
            "Add the flour and walnuts and stir well to completely combine.",
            "Spoon the cake mixture into two lined and greased 20cm/8in cake tins.",
            "Transfer to the oven to bake 25-30 minutes, or until a skewer inserted into the centre of the cake comes out clean and the cake is golden-brown."
        };
        return method;
    }
}