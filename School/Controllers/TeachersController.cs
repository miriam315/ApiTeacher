using Microsoft.AspNetCore.Mvc;
using School.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace School.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        public IDataContext _context { get; set; }

        public TeachersController(IDataContext context)
        {
            _context = context;
        }

        // GET: api/<TeachersController>
        [HttpGet]
        public IEnumerable<Teachers> Get()
        {
            return _context.teachers;
        }

        // GET api/<TeachersController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var teacher = _context.teachers.Find(t => t.Id == id);
            if (teacher != null)
                return Ok(teacher);
            return NotFound();
        }

        // POST api/<TeachersController>
        [HttpPost]
        public ActionResult Post([FromBody] Teachers value)
        {
            var t = _context.teachers.Find(x => x.Id == value.Id);
            if (t != null)
            {
                return Conflict();//209
            }
            _context.teachers.Add(value);
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
