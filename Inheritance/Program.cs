using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird penguin = new Bird() { Name = "emperor penguin", Size = "medium", Sex = "male", IsHairy = false, BeakShape = "pointed", IsMigratory = false, IsWaterBird = false, CanFly = false };
            penguin.BirdDescription();

            Reptile rattlesnake = new Reptile() { Name = "rattle snake", Size = "large", Sex = "female", IsHairy = false, HasRattle = true, IsPet = false, IsVenomous = true };
            rattlesnake.ColorPattern = new string[] { "brown", "gray", "black" };
            rattlesnake.ReptileDescription();
        }
    }
}
