using System;
namespace FactoryPatternExercise
{
    public class Car : IVehicle
    {
        public Car()
        {
        }

        public void Build()
        {
            Console.WriteLine("The car has been built");
        }
    }
}

