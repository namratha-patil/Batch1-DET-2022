using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022.Models
{
    internal class storedproefm
    {
        public static void Main()

        {

            Getalldetailssp();
          //Updatenames();
        }

        private static void Getalldetailssp()

        {

            var ctx = new trainingContext();

            // var employees = ctx.Emps.FromSqlRaw("GetAllEmpsDetails");

            var employees = ctx.Emps.FromSqlRaw($"GetEmpsDetailsByEmpno @p0", 7698).ToList();
            foreach (var e in employees)

            {

                Console.WriteLine(e.Ename);

            }



        }



    }
}

