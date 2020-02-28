﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    class Mouse : Animal
    {
        public Mouse(string alies, int damage)
            : base(alies, damage) { }
        public override void DoSomething()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{Alies} за Машку, Машка за Жучку, Жучка за внучку, внучка за бабку, бабка за дедку, дедка за репку: тянут-потянут - Вытащили репку!");
        }
        public override void CallHelp()
        {
            Console.WriteLine("Help is no longer needed");
        }
        public void Lose()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{Alies} за Машку, Машка за Жучку, Жучка за внучку, внучка за бабку, бабка за дедку, дедка за репку: тянут-потянут - Всеровно вытянуть не могут:(");
        }
    }
}