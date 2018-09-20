using System.Collections.Generic;
using Stranka.Services.Entities;

namespace Stranka.Services.Interfaces
{
    public interface IIzboriService
    {
        long AddElections(Izbori elections);
        List<Izbori> GetAllElections();
    }
}
