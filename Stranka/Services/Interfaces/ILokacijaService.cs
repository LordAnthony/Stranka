using System.Collections.Generic;
using Stranka.Services.Entities;

namespace Stranka.Services.Interfaces
{
    public interface ILokacijaService
    {
        List<Lokacija> GetAllLocations();
    }
}
