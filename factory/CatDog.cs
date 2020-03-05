using factory.Contracts;
using factory.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace factory
{
    public class CatDog
    {
        IDog dog = ContractService.SetAnimal<IDog>();
        ICat cat = ContractService.SetAnimal<ICat>();

        public string DogName(string name) => dog.Name(name);
        public string CatName(string name) => cat.Name(name);
        public string SoundDog() => dog.Bark();
        public string SoundCat() => cat.Meow();
        public int LegsCat(int legs) => cat.Legs(legs);
        public int LegsDog(int legs) => dog.Legs(legs);

    }
}
