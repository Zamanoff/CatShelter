using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatShelter
{
    class Cat
    {
        public Cat()
        {
        }

        public Cat(string name, int age, bool gender, ConsoleColor color, int weight, int mimimi)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Age = age;
            Gender = gender;
            Color = color;
            Weight = weight;
            Mimimi = mimimi;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public bool Gender { get; set; }
        public ConsoleColor Color { get; set; }
        public int Weight { get; set; }
        public int Mimimi { get; set; }

    }
}
