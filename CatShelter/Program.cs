using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatShelter
{
    class Program
    {
        static void Main(string[] args)
        {
            CatShelter catShelter = new CatShelter();
            catShelter.Cats = new List<Cat>();
            catShelter.addCat(new Cat("bobik", 3, true, ConsoleColor.Black, 5, 3));
            catShelter.showCats();
        }
    }
}
