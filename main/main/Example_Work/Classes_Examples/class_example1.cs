namespace Class_example1
{        
    // var p1 = new Person(); // Error! Required properties not set
    // var p2 = new Person() { FirstName = "Grace", LastName = "Hopper" };
    public class Class_Example_1(int capacity)
    {
        // Beginning with C# 12, you can define a primary constructor 
        // as part of the class declaration:
        private int _capacity = capacity;
        
        // You can also use the required modifier on a property and allow callers 
        // to use an object initializer to set the initial value of the property:
        public required string LastName { get; set; }
        public required string FirstName { get; set; }
    }
}