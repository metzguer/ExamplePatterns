using factory.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace factory.Services
{
    public class CatService : BaseService, ICat
    {
        public string Meow() => "Meow meow meow";

    }
}
