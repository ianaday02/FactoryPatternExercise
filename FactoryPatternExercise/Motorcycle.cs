using System;
namespace FactoryPatternExercise
{
    public class Motorcycle : IVehicle
    {
        public Motorcycle()
        {
        }

        public void Build()
        {
            Console.WriteLine("The motorcycle has been built");
        }
    }
}

