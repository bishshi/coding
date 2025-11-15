namespace _5_4
{
    public abstract class Shape
    {
        protected string name;
        public Shape(string name)
        {
            this.name = name;
        }
        public abstract void Show();
        public abstract double Area();
    }
    public class Rectangle : Shape
    {
        protected double width;
        protected double height;
        public Rectangle(string name, double width, double height) : base(name)
        {
            this.width = width;
            this.height = height;
        }
        public override void Show()
        {
            Console.WriteLine("Rectangle: {0} , area :{1}", name, width * height);
        }
        public override double Area()
        {
            return width * height;
        }
    }
    public class Circle : Shape
    {
        protected double radius;
        public Circle(string name, double radius) : base(name)
        {
            this.radius = radius;
        }
        public override void Show()
        {
            Console.WriteLine("Circle: {0} , area :{1}", name, Math.PI * radius * radius);
        }
        public override double Area()
        {
            return Math.PI * radius * radius;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Shape[] s = { new Rectangle("小矩形",1.0,2.0),
                         new Circle("大源",5.0),
                        };
            foreach (Shape shape in s)
            {
                shape.Show();
            }
        }
    }
}
