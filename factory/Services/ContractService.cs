using factory.Contracts;
using factory.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace factory.Services
{
    public static class ContractService
    {
        public static T SetAnimal<T>()
        {
            Object ojb = null;
             
            if (typeof(T) == typeof(IDog))
                ojb = new DogService();

            if (typeof(T) == typeof(ICat))
                ojb =  new CatService();

            return (T)ojb;
        }

    }
}
