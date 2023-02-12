namespace GenericP331
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintOut<string>("salam"); 
            Swap<int>(5,5);                   
            Swap<string>("Salam", "Sagol");     
        }
        

        static void PrintOut<T>(T value)
        {
            Console.WriteLine(value);
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        static void Swap<T>(T a, T b)
        {
            T val = a;
            a = b;
            b = val;

            Console.WriteLine($"{a} ===> {b}");
        }
    }
}