namespace Delegate
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Predicate<int> isEven = IsEven;
            Predicate<int> isOdd = IsOdd;
            Predicate<int> isPrime = IsPrime;
            Predicate<int> isFibonacci = IsFibonacci;
            
            int number = 5;
            Console.WriteLine($"Is {number} even? {IsEven(number)}");
            Console.WriteLine($"Is {number} odd? {IsOdd(number)}");
            Console.WriteLine($"Is {number} prime? {IsPrime(number)}");
            Console.WriteLine($"Is {number} Fibonacci? {IsFibonacci(number)}");
        }
        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
        static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }
        static bool IsPrime(int number)
        {
            if (number < 2)
                return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
        static bool IsFibonacci(int number)
        {
            int a = 0, b = 1, c = 0;
            if (number == 0 || number == 1)
                return true;
            while (c < number)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c == number;
        }
    }
}