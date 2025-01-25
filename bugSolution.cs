public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass()
    {
        // Assigning the property a value in the constructor.
        MyProperty = 0; 
    }

    public void MyMethod()
    {
        int x = MyProperty; 
    }
}