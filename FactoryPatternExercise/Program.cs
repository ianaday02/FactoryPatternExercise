using System;

namespace FactoryPatternExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            int wheelCount;

            bool input = false;

            do
            {
                Console.WriteLine("How many tires do you need for the vehicle you want to create?");

                input = int.TryParse(Console.ReadLine(), out wheelCount);

            } while (input == false);

            var vehicle = VehicleFactory.GetVehicle(wheelCount);
            vehicle.Build();
        }
    }
}

