using factory.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace factory.Contracts
{
    public interface IDog : IBase
    {
        string Bark();
    }
}
