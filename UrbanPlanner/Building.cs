using System;
using System.Collections.Generic;
using System.Text;

namespace UrbanPlanner
{
    class Building
    {
        private string _designer { get; set; }
        private DateTime _dateContructed { get; set; }
        private string _address { get; set; }
        private string _owner { get; set; }
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume => Width * Depth * (3 * Stories);

        public Building(string address)
        {
            _address = address;
        }

        public void Construct()
        {
            _dateContructed = DateTime.Now;
        }
        public void Purchase(string purchaser)
        {
            _owner = purchaser;
        }
        public void Design(string designer)
        {
            _designer = designer;
        }
        public void Write()
        {
            Console.WriteLine($"{_address}-----------");
            Console.WriteLine($"Designed by {_designer}");
            Console.WriteLine($"Constructed on {_dateContructed}");
            Console.WriteLine($"Owned by {_owner}");
            Console.WriteLine($"{Volume} cubic meters of space");
        }

   
    }
}
