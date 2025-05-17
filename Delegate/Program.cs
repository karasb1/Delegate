namespace Delegate
{
    delegate int[] ArrayOperation(int[] arr);
    class Program
    {
        static void Main(string[] args)
        {
            int [] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            ArrayOperation GetEvenNumbers = EvenNumbers;
            ArrayOperation GetOddNumbers = OddNumbers;
            ArrayOperation GetPrimeNumbers = PrimeNumbers;
            ArrayOperation GetFibonacciNumbers = FibonacciNumbers;
            
            Console.WriteLine("Even Numbers: " + string.Join(", ", GetEvenNumbers(numbers)));
            Console.WriteLine("Odd Numbers: " + string.Join(", ", GetOddNumbers(numbers)));
            Console.WriteLine("Prime Numbers: " + string.Join(", ", GetPrimeNumbers(numbers)));
            Console.WriteLine("Fibonacci Numbers: " + string.Join(", ", GetFibonacciNumbers(numbers)));
        }
        static int[] EvenNumbers(int[] arr)
        {
            return arr.Where(x => x % 2 == 0).ToArray();
        }
        static int[] OddNumbers(int[] arr)
        {
            return arr.Where(x => x % 2 != 0).ToArray();
        }
        static int[] PrimeNumbers(int[] arr)
        {
            return arr.Where(IsPrime).ToArray();
        }
        static int[] FibonacciNumbers(int[] arr)
        {
            return arr.Where(IsFibonacci).ToArray();
        }
        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
        static bool IsFibonacci(int number)
        {
            if (number < 0) return false;
            int a = 0, b = 1, c = 0;
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