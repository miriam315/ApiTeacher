using School.Core.Entities;
using School.Core.Repositories;
using School.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Service
{
    public class TeacherService : ITeacherService /// בחלק זה נרשום את כל הלוגיקה העיסקית
    {
        private readonly ITeacherRepository _teacherRepository;
        public TeacherService(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }
        public List<Teachers> GetAll()
        {
            return _teacherRepository.GetAllTeachers();
        }

        public Teachers GetById(int id)
        {
            return _teacherRepository.GetById(id);
        }
    }
}
