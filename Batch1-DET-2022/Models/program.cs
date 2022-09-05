using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022.Models
{
    internal class Program
    {
     private static void Main(string[] arg)
        {
          //GetEmpDetailsByID();
            Console.ReadLine();
            // AddNewEmployee();
            //DeleteEmployee();
            updateEmployee();


        }
        private static void GetEmpDetailsByID()
        {
            var ctx = new trainingContext();
            var emp = ctx.Emps.Where(e => e.Empno == 7654).SingleOrDefault();

            Console.WriteLine(emp.Ename + "" + emp.Sal);
        }
        public static void AddNewEmployee()
        {
            var ctx = new trainingContext();

            try
            {
                Emp employee = new Emp();
                employee.Empno = 2979;
                employee.Ename = "sheela";
                employee.Sal = 1000;
                employee.Deptno = 30;
                employee.Job = "Trainner";
                ctx.Add(employee);
                ctx.SaveChanges();
                Console.WriteLine("New employee added");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void DeleteEmployee()
        {
            var ctx = new trainingContext();

            try
            {
                Emp employee = new Emp();
                employee.Empno = 7369;
                employee.Ename = "sheela";
                employee.Sal = 1000;
                employee.Deptno = 1;
                employee.Job = "Trainner";
                ctx.Remove(employee);
                ctx.SaveChanges();
                Console.WriteLine("New employee delete");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }



        private static void updateEmployee()



        {

            var ctx = new trainingContext();

            try

            {

                Emp employee = new Emp();

                employee.Empno = 7782;

                employee.Ename = "virat";

                employee.Deptno = 30;

                ctx.Update(employee);

                ctx.SaveChanges();

                Console.WriteLine("Employee updated");

            }

            catch (Exception ex)

            {

                Console.WriteLine(ex.InnerException.Message);

            }

        }
       
    
        }
    }
