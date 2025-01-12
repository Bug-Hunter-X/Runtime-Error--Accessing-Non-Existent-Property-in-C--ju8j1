public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        MyProperty = value;
    }

    public void MyMethod()
    {
        // Accessing a non-existent property will not throw a compile-time error,
        // but will throw a runtime error if not handled.
        Console.WriteLine(NonExistentProperty); 
    }
}