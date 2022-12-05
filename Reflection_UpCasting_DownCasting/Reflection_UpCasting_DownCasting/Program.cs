using Reflection_UpCasting_DownCasting.Models;
using System.Reflection;


namespace Reflection_UpCasting_DownCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Assembly class
            //Assembly assembly = Assembly.GetExecutingAssembly();
            //var types = assembly.GetTypes();
            //if (types.Length==0)
            //{
            //    Console.WriteLine("Hello");
            //}
            //foreach (var type in types)
            //{
            //    var props = type.GetConstructors();
            //    Console.WriteLine(type.FullName);
            //    foreach (var prop in props)
            //    {
            //        Console.WriteLine(prop.GetParameters()[0].Name);
            //    }
            //    Console.WriteLine("-------------------------------------------------");
            //}
            Student student=new Student();
            student.GetName();
            #endregion

            ////Type? person = Type.GetType("Reflection_UpCasting_DownCasting.Models.Person");
            //Assembly assembly= Assembly.GetExecutingAssembly();
            //Type? personType = typeof(Person);
            ////foreach (var item in personType.GetProperties())
            ////{
            ////    Console.WriteLine(item.Name);
            ////}
            //var props = personType.GetProperties(BindingFlags.Instance|BindingFlags.NonPublic|BindingFlags.Public);
            //var propId= personType.GetProperty("Id",BindingFlags.Instance|BindingFlags.NonPublic);
            //var propDesc = personType.GetProperty("Description");
            //Person person = (Person)Activator.CreateInstance(typeof(Person));
            ////var person1 = assembly.CreateInstance(typeof(Person).FullName);

            ////    propId.SetValue(person1,5);
            ////Console.WriteLine(propId.GetValue(person1));
            //propDesc.SetValue(person, "Ali yaxsi oxu");
            //MethodInfo method = personType.GetMethod("GetDescription",BindingFlags.Instance|BindingFlags.NonPublic);

            //method.Invoke(person, new object []{"Ali Mammadov",5 });


        }
    }
  
    class Student : Person
    {

        public Student()
        {

        }
        
        public string School { get; set; }
        public void GetName()
        {
            Console.WriteLine(Name);
        }
    }
}