﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess
{
    class Program
    {
        static void Main(string[] args)
        {

            Board chess = new Board(8);
            chess.Fill();
            chess.Print();
            chess.Question();
            System.Console.ReadKey();
            


        }
    }
}
