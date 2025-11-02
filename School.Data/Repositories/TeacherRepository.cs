using School.Core.Entities;
using School.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.Repositories
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly DataContext _context;
        public TeacherRepository(DataContext context)
        {
            _context = context;
        }
        public List<Teachers> GetAllTeachers()
        {
            return _context.teachers;
        }

        public Teachers GetById(int id)
        {
            var t = _context.teachers.Find(x => x.Id == id);
            return t;
        }


    }
}
