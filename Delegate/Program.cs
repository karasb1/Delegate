namespace Delegate
{
    internal class Program
    {
        delegate void ShowMessage(string message);

        static void Main(string[] args)
        {
            ShowMessage showMessage = Show;
            showMessage += Show2;
            showMessage += Show3;
            showMessage("Hello, World!");
        }
        static void Show(string message)
        {
            Console.WriteLine(message);
        }
        static void Show2(string message)
        {
            Console.WriteLine(message.ToUpper());
        }
        static void Show3(string message)
        {
            Console.WriteLine(message.ToLower());
        }
    }
}