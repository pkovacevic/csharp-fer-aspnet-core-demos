using System.Collections.Generic;
using ASPNetCoreDemo1.Core.Models;

namespace ASPNetCoreDemo1.Core.Interfaces
{
    public interface IStudentRepository
    {
        Student Add(Student s);
        List<Student> GetAll();
        Student Get(string jmbag);
    }
}
