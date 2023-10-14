using Console_Application.database;
using Console_Application.Entities;
using System;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            //string answer;
            //do
            //{
            //    addDepartmet();
            //    Console.Write("Enter another department (y/n)? ");
            //    answer = Console.ReadLine();
            //} while (answer == "y"); 


            //int[] num = new int[] {55,22,65,41,23,13};

            //var data = num.Where(x => x < 30);

            //foreach (var item in data)
            //{
            //    Console.WriteLine(item);
            //}


            Context db = new Context();

            // Query Syntax
            //var data = from department in db.Departments
            //           where department.Id > 2
            //           select department;


            // Method Syntax
            //var data = db.Departments.Where(data => data.Id > 2)
            //                        .OrderBy(data => data.DepartmentName)
            //                        .Select(data => new { data.DepartmentName});


            //foreach (var item in data)
            //{
            //    Console.WriteLine(item.DepartmentName);
            //}




            #region Class Generic
            // classGeneric<string> generic = new classGeneric<string>() { code = "string" };
            // classGeneric<Department> department = new classGeneric<Department>();
            //   List<int> vs = new List<int>() { 44,455,44,11,22  };

            //Department department = new Department() { DepartmentName = "doctor" };
            //List<int> data = new List<int>() { 2,5,6,47,9,44 };
            //int[] arr = new int[] { 1, 2, 3, 4, 6, 8 };
            //classGeneric<int> enumerable = new classGeneric<int>();
            //enumerable.myMethod(data);
            //data.Add(department);



            //Console.WriteLine("success");
            #endregion





            Console.ReadKey();
        }

        public static void addDepartmet()
        {
            #region add to db
            Department department = new Department();

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("welcome to company system");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("please enter department");
            department.DepartmentName = Console.ReadLine();

            Context db = new Context();
            db.Departments.Add(department);
            db.SaveChanges();

            Console.WriteLine("Save Successfully !");
            #endregion
        }
    }
}
