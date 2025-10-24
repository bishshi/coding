using System;
namespace point
{
    public class point
    {
        public int x, y;
      public point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public double Distance(point p)
        {
            return Math.Sqrt((x-p.x)*(x - p.x) +  (y-p.y)*(y - p.y));
        }
     }
    class PointTest
    {
        static void Main()
        {
            point p1 = new point(0, 4);
            point p2 = new point(3, 0);
            double dist = p1.Distance(p2);
            Console.WriteLine(dist);
        }

    }
    
}
