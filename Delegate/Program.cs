namespace Delegate
{
    public class Program
    {
        public delegate int DelCalculate(int a, int b);

        public static void Main(string[] args)
        {
            DelCalculate del = new DelCalculate(Add);
            DelCalculate del2 = new DelCalculate(Subtract);
            DelCalculate del3 = new DelCalculate(Multiply);
            
            Console.WriteLine("Addition: " + del.Invoke(10, 20));
            Console.WriteLine("Subtraction: " + del2.Invoke(20, 10));
            Console.WriteLine("Multiplication: " + del3.Invoke(10, 20));
        }
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}