using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EMSINFO.EventModels;
using EMSINFO.Interface;
using Microsoft.EntityFrameworkCore;

namespace EMSINFO.Data
{
    public class Eventdata : IEvents
    {
        private readonly EMSContext _context;
        public Eventdata(EMSContext context)
        {
            _context = context;
        }
        public async Task<List<Eventmaster>> GetAllEventsAsync()
        {
            return await _context.eventmasters.ToListAsync();
        }
        public async Task<Eventmaster> CreateEventsAsync(Eventmaster events)
        {
            await _context.eventmasters.AddAsync(events);
            await _context.SaveChangesAsync();
            return events;
        }
    }
}