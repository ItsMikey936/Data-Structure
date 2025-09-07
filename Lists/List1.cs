using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    public class List1
    {

        List<int> numbers = new List<int>(10);

        public void AddNumber(int number)
        {
            numbers.Add(number);
        }

        public void SortNumbers()
        {
            numbers.Sort();
        }

        public void PrintNumbers()
        {
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public void TopNumber()
        {
            if (numbers.Count > 0)
            {
                Console.WriteLine("El número más alto es: " + numbers.Max());
            }
            else
            {
                Console.WriteLine("La lista está vacía.");
            }
        }

    }
}
