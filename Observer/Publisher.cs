public class Publisher : IPublisher
{
    public int IssueNumber { get; set; } = 0;

    private List<ISubscriber> _subscribers = new List<ISubscriber>();

    public void Subscribe(ISubscriber subscriber)
    {
        Console.WriteLine($"Publisher: {subscriber.Name} just subscribed");
        _subscribers.Add(subscriber);
    }

    public void Unsubscribe(ISubscriber subscriber)
    {
        _subscribers.Remove(subscriber);
        Console.WriteLine($"Publisher: {subscriber.Name} just unsubscribed");
    }

    public void Notify()
    {
        Console.WriteLine("Publisher: Notify subscribers...");

        foreach (var subscriber in _subscribers)
        {
            subscriber.Update(this);
        }
    }

    public void PublishNewsletter()
    {
        this.IssueNumber++;
        Console.WriteLine($"Published #{this.IssueNumber} of Newsletter");
        this.Notify();
    }
}