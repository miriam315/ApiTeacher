using School;
using School.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTest
{
    public class FakeContext : IDataContext
    {
        public List<Teachers> teachers { get; set; }
        public List<Student> students { get; set; }
        public FakeContext()
        {
            teachers = new List<Teachers> { new Teachers { Address = "Nehmia", Email = "tre@gmail.com", Hours = 5, Id = 2, Name = "Shira", Phone = "0527954231" } };
            students = new List<Student> { new Student { Address = "gfd", Id = 6, IsActive = true, Name = "hfgg", Phone = "0598974587" } };
        }
    }
}
