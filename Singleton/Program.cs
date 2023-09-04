var nonSingleton1 = new NonSingleton("A");
var nonSingleton2 = new NonSingleton("B");
Console.WriteLine(nonSingleton1.Value);
Console.WriteLine(nonSingleton2.Value);
TestSingleton(nonSingleton1, nonSingleton2);

var simpleSingleton1 = SimpleSingleton.GetInstance("A");
var simpleSingleton2 = SimpleSingleton.GetInstance("B");
Console.WriteLine(simpleSingleton1.Value);
Console.WriteLine(simpleSingleton2.Value);
TestSingleton(simpleSingleton1, simpleSingleton2);


var threadSafeSingleton1 = ThreadSafeSingleton.GetInstance("A");
var threadSafeSingleton2 = ThreadSafeSingleton.GetInstance("B");
Console.WriteLine(threadSafeSingleton1.Value);
Console.WriteLine(threadSafeSingleton2.Value);
TestSingleton(threadSafeSingleton1, threadSafeSingleton2);


var lazySingleton1 = LazySingleton.GetInstance("A");
var lazySingleton2 = LazySingleton.GetInstance("B");
Console.WriteLine(lazySingleton1.Value);
Console.WriteLine(lazySingleton2.Value);
TestSingleton(lazySingleton1, lazySingleton2);

static void TestSingleton<T>(T object1, T object2) where T : class
{
    if (object1 == object2)
    {
        Console.WriteLine($"{typeof(T).FullName}: These are singletons");
    }
    else
    {
        Console.WriteLine($"{typeof(T).FullName}: These are NOT singletons");
    }
}