using System;
using System.Collections.Generic;
using System.Text;

namespace UrbanPlanner
{
    class City
    {
        public string Name { get; set; }
        private string _mayor { get; set; }
        private DateTime _yearEstablished { get; set; }
        public List<Building> Buildings { get; set; }

        public City(string name)
        {
            Name = name;
            Buildings = new List<Building>();
        }

        public void Election(string mayor)
        {
            _mayor = mayor;
            _yearEstablished = DateTime.Now;
            Console.WriteLine($"As of {_yearEstablished}, the mayor of {Name} is {_mayor}");
        }
        public void AddBuildings(Building building)
        {
            Buildings.Add(building);
        }


    }
}
