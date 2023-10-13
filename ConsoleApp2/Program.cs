﻿using Console_Application;
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
            string answer;
   
            do
            {
                addDepartmet();
                Console.Write("Enter another department (y/n)? ");
                answer = Console.ReadLine();
            } while (answer == "y"); 


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
