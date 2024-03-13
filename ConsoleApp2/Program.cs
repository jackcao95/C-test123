namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(23, 15);
            a.ConPoint(a);

            Console.Read();
        }

        public class Point
        {
            public int x;
            public int y;
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            public void ConPoint(dynamic point)
            {
                Console.WriteLine($"坐标点的位置为x:{point.x},y:{point.y}");
                Console.WriteLine("测试");
                Console.WriteLine("测试123");
            }
        }

        
    }
}