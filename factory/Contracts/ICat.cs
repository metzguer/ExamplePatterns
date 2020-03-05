using factory.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace factory.Contracts
{
    public interface ICat : IBase
    {
        string Meow();
    }
}
