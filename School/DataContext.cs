using School.Entities;

namespace School
{
    public class DataContext : IDataContext
    {
        public List<Teachers> teachers { get; set; }
        public List<Student> students { get; set; }
        public DataContext()
        {
            teachers = new List<Teachers> { new Teachers { Address = "Rabi", Email = "ghf@gmail.com", Hours = 5, Id = 1, Name = "Chana", Phone = "0583212859" } };
            students = new List<Student> { new Student { Address = "gfd", Id = 1, IsActive = true, Name = "gfjd", Phone = "0589745478" } };
        }
    }
}
