using System;
using System.Collections;
namespace _5_7
{
    public class NameListEventArgs : EventArgs
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public NameListEventArgs(string name, int count)
        {
            Name = name;
            Count = count;
        }
    }
    public delegate void NameListEventHandler(object source, NameListEventArgs e);
    public class NameList
    {
        ArrayList list;
        public event NameListEventHandler nameListEvent;
        public NameList()
        {
            list = new ArrayList();
        }
        public void Add(string name)
        {
            list.Add(name);
            if (nameListEvent != null)
            {
                nameListEvent(this, new NameListEventArgs(name, list.Count));
            }
        }
    }
    public class EventDemo
    {
        public static void Method1(object source, NameListEventArgs e)
        {
            Console.WriteLine("增加项目 {0}", e.Name);
        }
        public static void Method2(object source, NameListEventArgs e)
        {
            Console.WriteLine("当前项目总数 {0}", e.Count);
        }
        public static void Main()
        {
            NameList myList = new NameList();
            myList.nameListEvent += new NameListEventHandler(Method1);
            myList.nameListEvent += new NameListEventHandler(Method2);
            myList.Add("张三");
            myList.Add("李四");
            myList.Add("王五");
        }
    }
}
