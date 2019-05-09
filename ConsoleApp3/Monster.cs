﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Monster
    {
        public string Name { get; set; }
        public MonsterInfo Info { get; private set; }

        public void Init(string name)
        {
            this.Info = new MonsterInfo() { id = 1, hp = 100 };

            this.Name = name;
        }

        public void TakeDamage(int v)
        {


        }
    }
}
