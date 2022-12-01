using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_UpCasting_DownCasting.Models
{
    class Person
    {
        public Person()
        {

        }
        public Person(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        private int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        private void GetDescription(string Name,int age)
        {
            Console.WriteLine(Name+" age= "+age);
        }
    }
}
