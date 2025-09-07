using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitLists
{
    public class list
    {
        List<string> fruits  = new List<string>();


        public void AddFruit(string fruit)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese una fruta:");
                string inFruit = Console.ReadLine();
                fruits.Add(inFruit);
            }
        }

        public void ShowList()
        {
            foreach (var fruta in fruits)
            {
                Console.WriteLine(fruta);
            }
        }

        public void deleteFruit(string fruit)
        {
            foreach (var fruta in fruits)
            {
                if (fruta == fruit)
                {
                    fruits.Remove(fruit);
                    Console.WriteLine("Fruta eliminada");
                    break;
                }
            }
        }
    }
}
