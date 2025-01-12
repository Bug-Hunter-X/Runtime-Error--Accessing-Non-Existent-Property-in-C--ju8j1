public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        MyProperty = value;
    }

    public void MyMethod()
    {
        // Solution: Check if the property exists before accessing it.
        // This example uses reflection, but other methods may be more appropriate
        // depending on your application's design.
        try
        {
            var property = this.GetType().GetProperty("MyProperty");
            if (property != null)
            {
                var value = property.GetValue(this, null);
                Console.WriteLine(value);
            }
            else
            {
                Console.WriteLine("Property does not exist.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}