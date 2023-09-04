public class DecoratedComponent : IComponent
{
    private readonly IComponent _component;

    public DecoratedComponent(IComponent component)
    {
        _component = component ?? throw new ArgumentNullException(nameof(component));
    }

    public void DoSomething()
    {
        Console.WriteLine("I can add functionality before");
        _component.DoSomething();
        Console.WriteLine("I can add functionality after");
    }
}