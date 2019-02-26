using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatShelter
{
    class CatShelter
    {
        public List<Cat> Cats { get; set; }

        public void addCat(Cat cat)
        {
            Cats.Add(cat);
        }

        public void showCats()
        {
            foreach (var item in Cats)
            {
                Console.WriteLine(item.Name);
            }
        }
        public void giveCat()
        {

        }
        public void feedCat()
        {

        }
        public void sleepCat()
        {

        }
        public List<Cat> returnArrCats(ConsoleColor color, bool gender, int weight, int age)
        {
            var five = new List<Cat>();
            return five;
        }
        public Cat generationCat(Cat male, Cat female)
        {
            Cat cat = new Cat();
            return cat;
        }
        public void sickCat() { }
        public void therapyCat() { }

    }
}
