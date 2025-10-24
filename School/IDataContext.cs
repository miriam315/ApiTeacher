using School.Entities;

namespace School
{
    public interface IDataContext
    {
        public List<Teachers> teachers { get; set; }
        public List<Student> students { get; set; }
    }
}
