using System;

namespace Flooring_Cost_Estimator
{
    class Program
    {
        static void Main(string[] args)
        {
            const double CostPerFoot = 35.75;
            const double FeetPerHour = 40;
        
            Console.WriteLine("Samuel Dole's Flooring Cost Estimator!");
            Console.WriteLine();
            Console.Write("Please enter length of floor: ");
            int lengthFloor = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter width of floor: ");
            int widthFloor = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the cost per square foot for the flooring selected: ");
            double costFloor = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("------------------------");

            int totalFloor = lengthFloor * widthFloor;
            double floorCost = Convert.ToDouble(totalFloor) * costFloor;
            Console.WriteLine($"For a total floor size of {totalFloor} the floor cost is: {floorCost.ToString("C")}");

            double totalHours = Convert.ToDouble(totalFloor) / FeetPerHour;
            double installCost = totalHours * CostPerFoot;
            double totalCost = installCost + floorCost;
            Console.WriteLine($"It will take {totalHours} hours to install the floor at a cost of {installCost.ToString("C")}");
            Console.WriteLine();
            Console.WriteLine($"The total finished cost for the new floor is: {totalCost.ToString("C")}");
        }
    }
}
