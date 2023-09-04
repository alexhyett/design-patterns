public interface ISubscriber
{
    string Name { get; }
    void Update(IPublisher subject);
}