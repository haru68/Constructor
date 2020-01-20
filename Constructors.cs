using System;

namespace Constructeurs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter the number of floor you wish in your future building: ");
            int numberOfFloors = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please, enter the final size of the building you wish: ");
            double buildingSize = Convert.ToDouble(Console.ReadLine());

            Building ModularBuilding = new Building(numberOfFloors, buildingSize);

            double floorMaxSize = ModularBuilding.GetFloorMaxSize();
            Console.WriteLine("The maximum size of a floor is: " + floorMaxSize + " m");

            Building FixedFloorSizeBuilding = new Building(numberOfFloors);

            Console.WriteLine();
            Console.WriteLine("Considering a wishing number of floors of " + numberOfFloors + " and a recommanded floor size of 3m,");

            double FixedFloorSizeBuildingSize = FixedFloorSizeBuilding.GetSize();
            Console.WriteLine("We advise you to construct a building of final size of " + FixedFloorSizeBuildingSize +" m high.");
        }
    }

    public class Building
    {
        private int _NumberOfFloors;
        private double _BuildingSize;

        public Building(int NumberOfFloors, double BuildingSize)
        {
            _NumberOfFloors = NumberOfFloors;
            _BuildingSize = BuildingSize;
        }

        public Building(int NumberOfFloors)
        {
            _NumberOfFloors = NumberOfFloors;
            _BuildingSize = _NumberOfFloors * 3;
        }

        public double GetFloorMaxSize()
        {
            double GetFloorMaxSize = Convert.ToDouble(_BuildingSize) / _NumberOfFloors;
            return GetFloorMaxSize;
        }

        public int GetFloorCount()
        {
            return _NumberOfFloors;
        }

        public double GetSize()
        {
            return _BuildingSize;
        }
            
    }
}
