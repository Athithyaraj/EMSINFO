using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EMSINFO.EventModels;

namespace EMSINFO.Interface
{
    public interface IEvents
    {
        Task<List<Eventmaster>> GetAllEventsAsync();
        Task<Eventmaster> CreateEventsAsync(Eventmaster EventModel);
    }
}