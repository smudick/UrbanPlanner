using System;

namespace UrbanPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building FiveOneTwoEight = new Building("512 8th Avenue");
            FiveOneTwoEight.Width = 50;
            FiveOneTwoEight.Depth = 40;
            FiveOneTwoEight.Stories = 15;
            FiveOneTwoEight.Design("Frank Lloyd Wright");
            FiveOneTwoEight.Construct();
            FiveOneTwoEight.Purchase("Sam Mudick");
            //FiveOneTwoEight.Write();

            Building MyHouse = new Building("3713 Burrus Street");
            MyHouse.Width = 6.67;
            MyHouse.Depth = 6.67;
            MyHouse.Stories = 2;
            MyHouse.Design("Some dude in the 40s");
            MyHouse.Construct();
            MyHouse.Purchase("Sam Mudick");
            //MyHouse.Write();

            City nashville = new City("Nashville");
            nashville.Election("May Orr");
            nashville.AddBuildings(MyHouse);
            nashville.AddBuildings(FiveOneTwoEight);
            Console.WriteLine($"{nashville.Name}'s buildings are as follows:" +
                $"");
            foreach (Building building in nashville.Buildings)
            {
                
                building.Write();

            }

        }
    }
}
