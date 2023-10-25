using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class Macska
    {
        public string name {  get; set; }
        public double weight { get; set; }
        public bool hungry { get; set; }
        public Macska(string name, double weight, bool hungry)
        {
            this.name = name;
            this.weight = weight;
            this.hungry = hungry;
        }
        public Macska(string name, double weight)
        {
            this.name = name;
            this.weight = weight;
            hungry = false;
        }
        public bool Eating(double food)
        {
            if (hungry == true)
            {
                hungry = false;
                weight += food;
                return true;
            }
            else return false;
        }
        public void Running()
        {
            weight -= 0.1;
            if(hungry == false) hungry = true;
        }
        public string stringOutput()
        {
            return $"name: {name}, weight: {weight}, hungry: {hungry}";
        }


    }
}
