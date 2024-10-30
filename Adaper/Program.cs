namespace Adaper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point(5, 6.4);
            IVector adapter = new PointAdapter(point);
            Console.WriteLine(adapter.Magnitude);
        }
    }
}
