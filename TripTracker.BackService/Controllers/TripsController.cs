using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripTracker.BackService.Models;

namespace TripTracker.BackService.Controllers
{
    [Route("api/[controller]")]
    public class TripsController: Controller
    {
        private readonly Repository _repository;

        public TripsController(Repository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<Trip> Get()
        {
            return _repository.Get();
        }
        [HttpGet("{id}")]
        public  Trip Get(int id)
        {
            return _repository.Get(id);
        }
        [HttpPost]
        public void Post([FromBody] Trip trip)
        {
            _repository.Add(trip);
        }
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Trip trip)
        {
            _repository.Update(trip);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
