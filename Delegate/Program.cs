namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            double baseLength = 5;
            double height = 10;
            Action printCurrentTime = PrintCurrentTime;
            Action printCurrentDate = PrintCurrentDate;
            Action printDayOfWeek = PrintDayOfWeek;
            Func<double, double, double> triangleArea = TriangleArea;
            Func<double, double, double> rectangleArea = RectangleArea;
            printCurrentTime.Invoke();
            printCurrentDate.Invoke();
            printDayOfWeek.Invoke();
            Console.WriteLine(triangleArea(baseLength, height));
            Console.WriteLine(rectangleArea(baseLength, height));
        }
        static void PrintCurrentTime()
        {
            Console.WriteLine(DateTime.Now.ToString("hh:mm:ss"));
        }
        static void PrintCurrentDate()
        {
            Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy"));
        }
        static void PrintDayOfWeek()
        {
            Console.WriteLine(DateTime.Now.DayOfWeek);
        }
        static double TriangleArea(double baseLength, double height)
        {
            return (baseLength * height) / 2;
        }
        static double RectangleArea(double baseLength, double height)
        {
            return baseLength * height;
        }
    }
}