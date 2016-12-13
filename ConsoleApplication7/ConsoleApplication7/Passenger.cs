using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Passenger
    {
        private string Name;
        private double Weight;

        public Passenger(string name, int weight)
        {
            this.Name = name;
            this.Weight = weight;
        }
        public string GetName()
        {
            return this.Name;
        }
        public void SetName(string x)
        {
            this.Name = x;

        }
        public double GetWeight()
        {
            return this.Weight;
        }
        public void SetWeight(double X)
        {
            this.Weight = X;
        }
    }
}
