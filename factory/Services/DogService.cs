using factory.Contracts;
using factory.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace factory.Services
{
    public class DogService : BaseService, IDog
    {
        public string Bark() => "guau guau guau";
    }
}
