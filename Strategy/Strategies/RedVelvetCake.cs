using StrategyCake.Model;

namespace StrategyCake.Strategies;

public class RedVelvetCake : ICakeStrategy
{
    public List<Ingredient> GetIngredients()
    {
        var ingredients = new List<Ingredient>
        {
            new Ingredient(295, "g", "self-raising flour"),
            new Ingredient(1, "tsp", "baking soda"),
            new Ingredient(22, "g", "unsweetened cocoa powder"),
            new Ingredient(1,"tsp","baking soda"),
            new Ingredient(0.5m, "tsp", "salt"),
            new Ingredient(115, "g", "unsalted butter softened"),
            new Ingredient(350, "g", "granulated sugar"),
            new Ingredient(2, "", "large eggs"),
            new Ingredient(120,"ml", "canola or vegetable oil"),
            new Ingredient(1, "bottle", "liquid red food color"),
            new Ingredient(2, "tsp", "pure vanilla extract"),
            new Ingredient(1, "tsp", "distilled white vinegar"),
            new Ingredient(320, "ml", "buttermilk")
        };

        return ingredients;
    }

    public List<string> GetMethod()
    {
        var method = new List<string>
        {
            "Preheat the oven to 180°C.",
            "Spray two 9 - inch cake pans well with nonstick cooking spray, line the bottoms of the pans with parchment paper.",
            "In a large mixing bowl, whisk together the cake flour, cocoa powder, baking soda, and salt. Then, sift the dry ingredients to remove any lumps of cocoa powder.",
            "In the bowl of a stand mixer fitted with the paddle attachment, or in a large mixing bowl using a handheld mixer, cream together the butter and sugar on medium speed for 4 to 5 minutes.Add the eggs and mix until fully combined, then mix in the oil, red food coloring, vanilla extract, and vinegar, stopping to scrape down the sides of the bowl as needed.",
            "Mix in the dry ingredients in three additions alternating with the buttermilk, starting and ending with the dry ingredients.Make sure to mix in each addition until just combined and be careful not to over mix the batter.",
            "Evenly distribute the cake batter between the two prepared cake pans and spread the batter around into one even layer.",
            "Bake for 28 to 32 minutes or until a toothpick inserted into the center of the cakes comes out clean. Carefully remove from the oven and place on a wire rack to cool in the pans for 15 to 20 minutes. Then, carefully remove the cakes from the cake pans and place on the wire rack to cool completely."
        };

        return method;
    }
}