using System;
using System.Collections.Generic;
using System.Text;

namespace factory.Contracts
{
    public interface IBase
    {
        string Name(string name);
        int Legs(int id);
    }
}
