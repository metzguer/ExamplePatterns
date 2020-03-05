using factory.Contracts;
using factory.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace factory.Services
{
    public class BaseService : IBase
    {
        public int Legs(int id) => id;

        public string Name(string name) => name;
        
    }
}
