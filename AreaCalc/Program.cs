namespace AreaCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AreaCalc.Rectangle rectangle = new AreaCalc.Rectangle("Rectangle1");
            rectangle.Length = 10;
            rectangle.Width = 20;

            rectangle.Display();
        }
    }
}
