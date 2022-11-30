using System.Reflection;
using Utillities;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClassmyClass = new MyClass();
            Assembly assembly= Assembly.GetExecutingAssembly();
            foreach (var type in assembly.GetTypes())
            {
                Console.WriteLine($"{type.Namespace}.{type.Name}");
                foreach (var item in type.GetMembers(BindingFlags.Instance|BindingFlags.InvokeMethod))
                {
                    Console.WriteLine(item.Name);
                }
            }

        }
    }
    class Person
    {
        public Person()
        {

        }

        public Person(int id, string name, string title, string description)
        {
            Id = id;
            Name = name;
            Title = title;
            Description = description;
        }
        private string name;

        private int Id { get; set; } 
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        class MyClass
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}