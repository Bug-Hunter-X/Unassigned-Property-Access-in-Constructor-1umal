public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a property before it is assigned a value in the constructor.
        int x = MyProperty; 
    }
}