using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EMSINFO.EventModels;
using EMSINFO.Interface;
using Microsoft.AspNetCore.Mvc;

namespace EMSINFO.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventController : ControllerBase
    {
        
        private readonly EMSContext _context;
        private readonly IEvents _eventdata;
        public EventController(EMSContext context, IEvents eventdata)
        {
            _eventdata = eventdata;
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var events = await _eventdata.GetAllEventsAsync();
            return Ok(events);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Eventmaster events)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            await _eventdata.CreateEventsAsync(events);
            return Ok(events);
        }
    }
}