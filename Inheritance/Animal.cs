using Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Animal
    {
        public string Name { get; set; }
        public string Size { get; set; }  // small, medium, large
        public string Sex { get; set; } // male, female
        public bool IsHairy { get; set; } // has hair, true; does not have hair, false;
    }
}

    public class Bird : Animal
    {
        public string BeakShape { get; set; }
        public bool IsMigratory { get; set; }
        public bool IsWaterBird { get; set; }
        public bool CanFly { get; set; }
        public Bird() { }
        public void BirdDescription()
        {
        Console.WriteLine($"The {Name} is a {Size} sized animal. \nIs it hairy? {IsHairy}, it's a bird. \nIs it migratory? {IsMigratory}. " +
            $"\nCan it fly? {CanFly}. \nIs it a water bird? {IsWaterBird}. \nWhatever the case, with a {BeakShape} beak, it will mess you up, even if it's {Sex}.\n");
        }
    }

    public class Reptile : Animal
    {
        public bool IsVenomous { get; set; }
        public bool IsPet { get; set; }
        public string[] ColorPattern { get; set; }
        public bool HasRattle { get; set; }
        public Reptile() { }
        public void ReptileDescription()
        {
        Console.WriteLine($"The {Name} is a {Size} sized animal. \nIs it hairy? {IsHairy}, it's a repitle. \nIs it venomous? {IsVenomous}. " +
            $"\nShould it be a pet? {IsPet}. \nDoes it rattle before it strikes? {HasRattle}. \nWhatever the case, a {Sex} {Name} should be left alone in the wild.");
            Console.WriteLine("Here's what colors to look for:");
            foreach (var color in ColorPattern)
            {
                Console.WriteLine(color);
            }
        }
    }
