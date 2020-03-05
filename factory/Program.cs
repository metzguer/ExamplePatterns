using factory.Contracts;
using factory.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace factory
{
    class Program
    {
        static void Main(string[] args) {

            var catdog = new CatDog();
            
            Console.WriteLine($"\nEl Cachorrito {catdog.DogName("Bobby")} \nhace {catdog.SoundDog()} \ny tiene {catdog.LegsDog(4)} patas");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"\nEl Gatito {catdog.CatName("Toby")} \nhace {catdog.SoundCat()} \ny tiene {catdog.LegsCat(4)} patas");

        }
    }
}
