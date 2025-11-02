using School.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Core.Repositories
{
    public interface ITeacherRepository
    {
        public List<Teachers> GetAllTeachers();
        public Teachers GetById(int id);
    }
}
