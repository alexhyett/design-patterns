using StrategyCake.Model;

namespace StrategyCake.Strategies;

public class ChocolateFudgeCake : ICakeStrategy
{
    public List<Ingredient> GetIngredients()
    {
        var ingredients = new List<Ingredient>
        {
            new Ingredient(150, "ml", "sunflower oil"),
            new Ingredient(175, "g", "self-raising flour"),
            new Ingredient(2, "tbsp", "cocoa powder"),
            new Ingredient(1, "tsp", "bicarbonate of soda"),
            new Ingredient(150, "g", "caster sugar"),
            new Ingredient(2, "tbsp", "golden syrup"),
            new Ingredient(2, "", "large eggs"),
            new Ingredient(150, "ml", "semi-skimmed milk"),
        };
        return ingredients;
    }

    public List<string> GetMethod()
    {
        var method = new List<string>
        {
            "Heat the oven to 180C/160C fan/gas 4. Oil and line the base of two 18cm sandwich tins.",
            "Sieve the flour, cocoa powder and bicarbonate of soda into a bowl. Add the caster sugar and mix well.",
            "Make a well in the centre and add the golden syrup, eggs, sunflower oil and milk. Beat well with an electric whisk until smooth.",
            "Pour the mixture into the two tins and bake for 25-30 mins until risen and firm to the touch. Remove from oven, leave to cool for 10 mins before turning out onto a cooling rack."
        };
        return method;
    }
}