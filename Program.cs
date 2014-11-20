﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleshipTest.BoardData;
using System.Windows.Forms;

namespace BattleshipTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu m = new Menu();
            PlayerManager playerManager = new PlayerManager(m.difficulty);

            bool didSomeoneWin = false;
            //Main game loop
            while (didSomeoneWin == false)
            {
                playerManager.update(m.humanGoesFirst, m.debugMode);
            }
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();

        }
    }
}
