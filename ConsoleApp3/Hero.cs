using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Hero
    {
        public string Name { get; set; }

        public void Init(string name)
        {
            this.Name = name;
        }

        internal void ActiveSkill()
        {
            Console.WriteLine("{0} : 드래곤~~~~~~~슬레이이이이이이브브으으으으으으",this.Name);
        }
    }
}
