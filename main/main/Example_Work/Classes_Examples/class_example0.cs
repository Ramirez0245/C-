using Class_example1;

namespace Namespace_class_example0
{
    //[access modifier] - [class] - [identifier]
    public class Class_Example_0
    {
        // Initialize capacity field to a default value of 10:
        private int _cap = 10;

        // You can require callers to provide an initial value by defining a 
        // constructor that's responsible for setting that initial value:
        private int _capacity;
        public Class_Example_0(int capacity) => _capacity = capacity;    


        //  This reference refers to the new object but 
        //  doesn't contain the object data itself. In fact, 
        //  you can create an object reference without creating 
        //  an object at all:
        Class_Example_1 object2;
    }

    
}