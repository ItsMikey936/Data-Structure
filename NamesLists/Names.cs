using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NamesLists
{
    public class Names
    {
        List<String> names = new List<String>();

        public void addName(string name)
        {
            names.Add(name);
        }

        public void sortList()
        {
            names.Sort();
        }

        public void showNames()
        {
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }

    }
}
