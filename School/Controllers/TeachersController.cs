using Microsoft.AspNetCore.Mvc;
using School.Core.Entities;
using School.Core.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace School.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        private readonly ITeacherService _teacherService;

        public TeachersController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        // GET: api/<TeachersController>
        [HttpGet]
        public IEnumerable<Teachers> Get()
        {
            return _teacherService.GetAll();
        }

        // GET api/<TeachersController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var t = _teacherService.GetById(id);
            if (t != null)
                return Ok(t);
            return NotFound();
        }

        // POST api/<TeachersController>
        [HttpPost]
        public ActionResult Post([FromBody] Teachers value)
        {
            //var t = _context.teachers.Find(x => x.Id == value.Id);
            //if (t != null)
            //{
            //    return Conflict();//209
            //}
            //_context.teachers.Add(value);
            return Ok();//200
        }

        // PUT api/<TeachersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TeachersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
