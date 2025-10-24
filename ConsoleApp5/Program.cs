namespace ConsoleApp5
{
    public class Person
    {
        public string name;
        protected int age;
        public Person()
        {
            this.name = "未知"; this.age = 0;
        }
        public Person(string name, int age)
        {
            this.name = name; this.age = age;
        }
        public void Print()
        {
            Console.WriteLine("name = {0}, age = {1}", this.name, this.age);
        }
    }
    class Persontest2
    {
        static void Main(string[] args)
        {
            Person personA;
            personA = new Person("张三", 25);
            Person personB;
            personB = new Person("李四", 18);
            personA.Print();
            personB.Print();
        }
    }
}
