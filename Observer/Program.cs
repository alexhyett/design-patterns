
var publisher = new Publisher();

var subscriberA = new Subscriber("Alex");
publisher.Subscribe(subscriberA);

var subscriberB = new Subscriber("Bob");
publisher.Subscribe(subscriberB);

publisher.PublishNewsletter();
publisher.PublishNewsletter();
publisher.PublishNewsletter();

publisher.Unsubscribe(subscriberB);

publisher.PublishNewsletter();
