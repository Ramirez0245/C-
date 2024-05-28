// Second, declaring your own namespaces can help you control the 
// scope of class and method names in larger programming projects. 
// Use the namespace keyword to declare a 
// namespace, as in the following example
namespace SampleNamespace
{
    class SampleClass
    {
        public void SampleMethod()
        {
            System.Console.WriteLine(
                "SampleMethod inside SampleNamespace");
        }
    }
}