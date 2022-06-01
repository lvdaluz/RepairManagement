using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PeopleController : ControllerBase
    {
        private readonly IPeopleRepository _repository;

        public PeopleController(IPeopleRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Get() =>
            Ok(_repository.Get());
    }
}