using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antikvariatägarens_dotter
{
    class Book
    {
        public int price = 0;
        int rarity = 0;
        Random generator = new Random();
        private string name;
        private int actualValue;
        private string category;
        private bool cursed;

        public Book()
        {
            rarity = generator.Next(1, 11);
            price = generator.Next(49, 500);

            int c = generator.Next(5); //slumpar mellan 0-4, vilket bestämmer vad cursed får för värde
            if (c == 1)
            {
                cursed = true;
            }
            else
            {
                cursed = false;
            }

            PrintInfo();//test
        }

        public void PrintInfo()
        {
            string dinMamma;
            dinMamma = GetName(name);
            Console.WriteLine("The book's name is "+ dinMamma+" it's");

            Console.ReadLine();
        }

        public int Evaluate(int actualValue)
        {
            return actualValue;
        }

        public string GetCategory(string category)
        {
            string[] catList = { "Skräck", "Action", "Romans" };
            int b = generator.Next(3);
            category = catList[b];

            return category;
        }

        public string GetName(string name) //Skapar string name här så den kan returneras
        {
            string[] nameList = { "Galenbok", "galenbok2", "galenbok3" };
            int n = generator.Next(3);
            name = nameList[n];

            return name;
        }

        public bool IsCursed(bool cursed)
        {           
            int cursedCheck = generator.Next(5); //slumpar mellan 0-4, vilket bestämmer vad curseCheck får för värde
            if (cursedCheck == 4)
            {
                cursed = true;
            }
            else
            {
                cursed = false;
            }

            return cursed;
        }
    }
}
