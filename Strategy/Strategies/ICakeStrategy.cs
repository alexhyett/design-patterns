using StrategyCake.Model;

namespace StrategyCake.Strategies;

public interface ICakeStrategy
{
    List<Ingredient> GetIngredients();
    List<string> GetMethod();
}