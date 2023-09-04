public class BadCakeProgram
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

        // Ingredients
        Console.WriteLine("INGREDIENTS:");
        if (cake == Cake.BirthdayCake)
        {
            Console.WriteLine("225g \tself-raising flour");
            Console.WriteLine("2 tsp \tbaking powder");
            Console.WriteLine("4 \teggs");
            Console.WriteLine("225g \tsoft margarine");
            Console.WriteLine("225g \tcaster sugar");
            Console.WriteLine("6 \tdrops vanilla extract");
            Console.WriteLine("2tsp \tmilk");
        }

        if (cake == Cake.RedVelvetCake)
        {
            Console.WriteLine("295g \tself-raising flour");
            Console.WriteLine("1 tsp \tbaking soda");
            Console.WriteLine("22g \tunsweetened cocoa powder");
            Console.WriteLine("1 tsp \tbaking soda");
            Console.WriteLine("½ tsp \tsalt");
            Console.WriteLine("115g \tunsalted butter softened");
            Console.WriteLine("350g \tgranulated sugar");
            Console.WriteLine("2 \tlarge eggs");
            Console.WriteLine("120ml \tcanola or vegetable oil");
            Console.WriteLine("1 \tbottle liquid red food color");
            Console.WriteLine("2 tsp \tpure vanilla extract");
            Console.WriteLine("1 tsp \tdistilled white vinegar");
            Console.WriteLine("320ml \tbuttermilk");
        }

        if (cake == Cake.CarrotCake)
        {
            Console.WriteLine("100g \tnatural yogurt");
            Console.WriteLine("4 \tlarge eggs");
            Console.WriteLine("1½ tsp \tvanilla extract");
            Console.WriteLine("½ \torange, zested");
            Console.WriteLine("265g \tself-raising flour");
            Console.WriteLine("335g \tlight muscovado sugar");
            Console.WriteLine("2½ tsp \tground cinnamon");
            Console.WriteLine("¼ \tfresh nutmeg, finely grated");
            Console.WriteLine("265g \tcarrots, grated");
            Console.WriteLine("100g \tsultanas or raisins");
            Console.WriteLine("100g \twalnuts or pecans, roughly chopped");
        }

        // Method
        Console.WriteLine();
        Console.WriteLine("METHOD:");
        if (cake == Cake.BirthdayCake)
        {
            Console.WriteLine("1. \tPreheat the oven to 160ºC/140ºC fan");
            Console.WriteLine("2. \tLine your baking tin");
            Console.WriteLine("3. \tSift the self-raising flour and baking powder into a large bowl.");
            Console.WriteLine("4. \tAdd the remaining ingredients and beat until thoroughly mixed.");
            Console.WriteLine("5. \tPour into the tin");
            Console.WriteLine("6. \tBake for 30-35 minutes.");
            Console.WriteLine("7. \tLeave to cool in the tin for about 10 minutes and then move to a wire rack to cool completely");
        }

        if (cake == Cake.RedVelvetCake)
        {
            Console.WriteLine("1. \tPreheat the oven to 180°C.");
            Console.WriteLine("2. \tSpray two 9 - inch cake pans well with nonstick cooking spray, line the bottoms of the pans with parchment paper.");
            Console.WriteLine("3. \tIn a large mixing bowl, whisk together the cake flour, cocoa powder, baking soda, and salt. Then, sift the dry ingredients to remove any lumps of cocoa powder.");
            Console.WriteLine("4. \tIn the bowl of a stand mixer fitted with the paddle attachment, or in a large mixing bowl using a handheld mixer, cream together the butter and sugar on medium speed for 4 to 5 minutes.Add the eggs and mix until fully combined, then mix in the oil, red food coloring, vanilla extract, and vinegar, stopping to scrape down the sides of the bowl as needed.");
            Console.WriteLine("5. \tMix in the dry ingredients in three additions alternating with the buttermilk, starting and ending with the dry ingredients.Make sure to mix in each addition until just combined and be careful not to over mix the batter.");
            Console.WriteLine("6. \tEvenly distribute the cake batter between the two prepared cake pans and spread the batter around into one even layer.");
            Console.WriteLine("7. \tBake for 28 to 32 minutes or until a toothpick inserted into the center of the cakes comes out clean. Carefully remove from the oven and place on a wire rack to cool in the pans for 15 to 20 minutes. Then, carefully remove the cakes from the cake pans and place on the wire rack to cool completely.");
        }

        if (cake == Cake.CarrotCake)
        {
            Console.WriteLine("1. \tHeat the oven to 180C/160C fan/gas 4. Oil and line the base and sides of two 20cm cake tins with baking parchment.");
            Console.WriteLine("2. \tWhisk the oil, yogurt, eggs, vanilla and zest in a jug. Mix the flour, sugar, cinnamon and nutmeg with a good pinch of salt in a bowl. Squeeze any lumps of sugar through your fingers, shaking the bowl a few times to bring the lumps to the surface.");
            Console.WriteLine("3. \tAdd the wet ingredients to the dry, along with the carrots, raisins and half the nuts, if using. Mix well to combine, then divide between the tins.");
            Console.WriteLine("4. \tBake for 25-30 mins or until a skewer inserted into the centre of the cake comes out clean. If any wet mixture clings to the skewer, return to the oven for 5 mins, then check again. Leave to cool in the tins.");
        }
    }

    private static void PrintCakeOptions()
    {
        Console.WriteLine("Which cake would you like to bake?");
        Console.WriteLine("1. Birthday Cake");
        Console.WriteLine("2. Red Velvet Cake");
        Console.WriteLine("3. Carrot Cake");
        Console.WriteLine();

        Console.WriteLine("Select a number between 1 - 3:");
    }


    private static Cake SelectCake()
    {
        int cakeNumber = 0;
        while (cakeNumber <= 0 || cakeNumber > 3)
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

}
