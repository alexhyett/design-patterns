namespace StrategyCake.Model;

public class Ingredient
{
    public Ingredient(decimal quantity, string unit, string item)
    {
        Quantity = quantity;
        Unit = unit;
        Item = item;
    }

    public decimal Quantity { get; }
    public string Unit { get; }
    public string Item { get; }
}