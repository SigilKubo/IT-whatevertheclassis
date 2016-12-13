﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator elevator1 = new Elevator(2, 400);
            elevator1.AddOccupant(new Passenger("A1", 180), 0);
            elevator1.AddOccupant(new Passenger("A2", 220), 1);
            bool elevator1IsOverMaxCapacity = new bool();
            double WeightForElevator1 = elevator1.GetCurrentWeight();
            elevator1IsOverMaxCapacity = elevator1.isOverMaxCapacity(WeightForElevator1);

            Elevator elevator2 = new Elevator(3, 600);
            elevator2.AddOccupant(new Passenger("A1", 200), 0);
            elevator2.AddOccupant(new Passenger("A2", 200), 1);
            elevator2.AddOccupant(new Passenger("A3", 201), 2);
            bool elevator2IsOverMaxCapacity = new bool();
            double WeightForElevator2 = elevator2.GetCurrentWeight();
            elevator2IsOverMaxCapacity = elevator2.isOverMaxCapacity(WeightForElevator2);
        }
    }
}
