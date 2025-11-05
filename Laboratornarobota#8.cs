using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornarobota_8
{
    public enum Gender
    {
        Male,
        Female
    }

    public class Cat
    {
        public string Name { get; }
        public Gender Gender { get; }

        private double energy;

        public static readonly double MaxEnergy = 20;
        public static readonly double MinEnergy = 0;
        public static readonly double SleepEnergyGain = 10;
        public static readonly double JumpEnergyDrain = 0.5;

        public double Energy
        {
            get { return energy; }
            private set
            {
                if (value < MinEnergy)
                    throw new Exception("Недостатньо енергії для стрибку");

                if (value > MaxEnergy)
                    energy = MaxEnergy;
                else
                    energy = value;
            }
        }

        public Cat(string name, Gender gender)
        {
            Name = name;
            Gender = gender;
            Energy = MaxEnergy;
        }

        public void Jump()
        {
            Energy -= JumpEnergyDrain;
        }

        public void Sleep()
        {
            Energy += SleepEnergyGain;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Мурчик", Gender.Male);

            Console.WriteLine($"{cat.Name} ({cat.Gender}) має енергію {cat.Energy}");

            cat.Jump();
            Console.WriteLine($"Після стрибка: {cat.Energy}");

            cat.Sleep();
            Console.WriteLine($"Після сну: {cat.Energy}");
        }
    }
}
