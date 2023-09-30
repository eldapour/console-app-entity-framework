using Console_Application;
using Console_Application.database;
using Console_Application.Entities;
using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region add to db
            //Department department = new Department();

            //Console.WriteLine("----------------------------------------------");
            //Console.WriteLine("welcome to company system");
            //Console.WriteLine("----------------------------------------------");
            //Console.WriteLine("please enter department");
            //department.DepartmentName = Console.ReadLine();

            //Context db = new Context();
            //db.Departments.Add(department);
            //db.SaveChanges();

            //Console.WriteLine("Save Successfully !");
            #endregion


            #region Class Generic
            // classGeneric<string> generic = new classGeneric<string>() { code = "string" };
            // classGeneric<Department> department = new classGeneric<Department>();
            //   List<int> vs = new List<int>() { 44,455,44,11,22  };
            #endregion


            Console.ReadKey();
        }
    }
}
