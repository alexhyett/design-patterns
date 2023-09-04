public class Subscriber : ISubscriber
{
    private int _latestIssue = 0;

    public Subscriber(string name)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
    }

    public string Name
    {
        get; private set;
    }

    public void Update(IPublisher publisher)
    {
        var concretePublisher = (publisher as Publisher);
        if (concretePublisher.IssueNumber > _latestIssue)
        {
            _latestIssue = concretePublisher.IssueNumber;
            Console.WriteLine($"{Name}: Received Issue {_latestIssue}");
        }
    }
}