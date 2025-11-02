using School.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Core.Service
{
    public interface ITeacherService
    {
        public List<Teachers> GetAll();
        public Teachers GetById(int id);
    }
}
