using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository_Domain;

namespace Repository_Pattern
{
    public interface IStudentRepository : IRepository<Student, int>
    {

        Student GetStudentById(int SudentID);
        Student GetStudentByName(string StudentName);
        List<Student> GetStudentByClass(string ClassName);
        bool Update(int SudentID, Student updatedStudentName);
        bool RemoveByClass(string ClassName);
        bool RemoveAll();
    }
}
