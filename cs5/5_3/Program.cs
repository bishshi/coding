using System;
namespace _5_3
{
    public class Person
    {
        public string name;
        public uint age;
        public Person(string name, uint age)
        {
            this.name = name;
            this.age = age;
        }
        public virtual void GetInfo()
        {
            Console.WriteLine("Name:{0}",name);
            Console.WriteLine("Age:{0}",age);
        }
    }
    public class Teacher:Person
    {
        public string teacherID;
        public Teacher(string name, uint age, string id):base(name,age)
        {
            this.teacherID = id;
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("teacherID:{0}",teacherID);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher objteacher = new Teacher("Alice",30,"T12345985452");
            objteacher.GetInfo();
        }
    }
}
