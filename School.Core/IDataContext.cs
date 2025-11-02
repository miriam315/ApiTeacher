
using School.Core.Entities;

namespace School.Core
{
    public interface IDataContext
    {
        public List<Teachers> teachers { get; set; }
        public List<Student> students { get; set; }
    }
}
