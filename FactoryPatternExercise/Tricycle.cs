using System;
namespace FactoryPatternExercise
{
    public class Tricycle : IVehicle
    {
        public Tricycle()
        {
        }

        public void Build()
        {
            Console.WriteLine("Your tricycle is built!");
        }
    }
}

