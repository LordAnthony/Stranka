using System.Collections.Generic;
using Stranka.Services.Entities;

namespace Stranka.Services.Interfaces
{
    public interface IBirackoMjestoService
    {
        List<BirackoMjesto> GetAllPollingStations();
    }
}
