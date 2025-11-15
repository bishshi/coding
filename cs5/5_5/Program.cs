namespace _5_5
{
    public struct Complex
    {
        public int real;
        public int imag;
        public Complex(int r, int i)
        {
            this.real = r;
            this.imag = i;
        }
        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(c1.real + c2.real, c1.imag + c2.imag);
        }
        public static Complex operator -(Complex c1, Complex c2)
        {
            return new Complex(c1.real - c2.real, c1.imag - c2.imag);
        }
        public static Complex operator *(Complex c1, Complex c2)
        {
            return new Complex(c1.real * c2.real - c1.imag * c2.imag, c1.real * c2.imag + c1.imag * c2.real);
        }
        public override string ToString()
        {
            return (string.Format("{0}+{1}i", this.real, this.imag));
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex(2, 3);
            Complex c2 = new Complex(4, 5);
            Complex sum = c1 + c2;
            Complex diff = c1 - c2;
            Complex prod = c1 * c2;
            Console.WriteLine("第一个复数" + c1);
            Console.WriteLine("第二个复数" + c2);
            Console.WriteLine("复数的和" + sum);
            Console.WriteLine("复数的差" + diff);
            Console.WriteLine("复数的积" + prod);
            Console.ReadKey();
        }
    }
}
