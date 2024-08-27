using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository_Domain;
using Repository_Pattern;


namespace School_project
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool isRun = true; while (isRun)
            {
                Console.Clear();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("================= Select Your Process=================");
                Console.WriteLine("Press 1 : To Get  Student Information");
                Console.WriteLine("Press 2 : To Create  New student Information");
                Console.WriteLine("Press 3 : To Exit The Application");
                string inputKey = Console.ReadLine();

                Console.Clear();
                if (inputKey == "1")
                {
                    var source =
                    RepositoryFactory.Create<IStudentRepository>(ContextTypes.XMLSource);
                    var Students = source.GetAll();
                    Console.WriteLine();
                    Console.WriteLine("=============Students Information===========");
                    foreach (var Student in Students)
                    {
                        Console.WriteLine(Student.StudentID
                    + ", " + Student.StudentName + ", " + Student.ClassName + ", " + Student.CellPhoneNo);
                    }
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                }
                else if (inputKey == "2")
                {
                    Student st = new Student();
                    Console.Write("Student ID : ");
                    st.StudentID = int.Parse(Console.ReadLine());
                   

                    Console.Write("Student Name : ");
                    st.StudentName = Console.ReadLine();

                    Console.Write("Class Name  : ");
                    st.ClassName = Console.ReadLine();

                    Console.Write("Cell Phone No. : ");
                    st.CellPhoneNo = Console.ReadLine();

                    Console.Clear();
                    IStudentRepository source =
                    RepositoryFactory.Create<IStudentRepository>(ContextTypes.XMLSource);
                    try
                    {
                        source.Insert(st);
                    }
                    catch (Exception ex)
                    {
                        Console.Write(ex);
                        Console.ReadKey();
                        continue;
                    }
                }
                else if (inputKey == "3")
                {
                    isRun = false;
                }
            }
        }
    }
}



