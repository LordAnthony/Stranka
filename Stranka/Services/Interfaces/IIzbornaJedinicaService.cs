using System.Collections.Generic;
using Stranka.Services.Entities;

namespace Stranka.Services.Interfaces
{
    public interface IIzbornaJedinicaService
    {
        List<IzbornaJedinica> GetAllConstituencies();
    }
}
