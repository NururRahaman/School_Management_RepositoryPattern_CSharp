
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository_Domain;
using Repository_Source;

namespace Repository_Pattern
{
    public class StudentXMLRepository : XMLRepositoryBase<XMLSet<Student>, Student, int>, IStudentRepository
    {
        public StudentXMLRepository() : base("StudentInformation.xml")
        {

        }
        public Student GetStudentById(int StudentID)
        {
            return GetAll().FirstOrDefault(c => c.StudentID == StudentID);
        }

        public Student GetStudentByName(string StudentName)
        {
            return GetAll().FirstOrDefault(c => c.StudentName == StudentName);
        }
        public List<Student> GetStudentByClass(string ClassName)
        {
            var allStudent = GetAll();
            return allStudent
            .Where(c => c.ClassName.Equals(ClassName, StringComparison.OrdinalIgnoreCase))
             .ToList();
        }
        public bool RemoveByClass(string ClassName)
        {
            try
            {
                var StudentToRemove = m_context.Data.Where(c => c.ClassName == ClassName).ToList();
                foreach (var Student in StudentToRemove)
                {
                    m_context.Data.Remove(Student);
                }
                m_context.Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool RemoveAll()
        {
            try
            {
                m_context.Data.Clear();
                m_context.Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public bool Update(int StudentID, Student updatedStudent)
        {
            try
            {
                var Student = m_context.Data.FirstOrDefault(c => c.StudentID == StudentID);
                if (Student != null)
                {
                    // Update the course properties with the values from updatedCourse
                    Student.StudentName = updatedStudent.StudentName;
                    Student.ClassName = updatedStudent.ClassName;
                    Student.ClassRoll = updatedStudent.ClassRoll;
                    Student.CellPhoneNo = updatedStudent.CellPhoneNo;

                    // Save changes to the XML file
                    m_context.Save();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}

