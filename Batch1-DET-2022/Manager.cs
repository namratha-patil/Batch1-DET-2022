using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class Manager :Emp1 
    {
        public string Project { get; set; }
        public int Teamsize { get; set; }
        public DateTime DateTime { get; }
        public string V1 { get; }
        public int V2 { get; }

        /// <summary>
        /// calling base class constructor from derived class 'base' keyword
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="doj"></param>
        /// <param name="project"></param>
        /// <param name="teamsize"></param>
        public Manager(int id, string name, DateOnly doj, string project, int teamsize) : base(id, name, doj)
        {
            this.Project = project;
            Teamsize = teamsize;
        }

        public Manager(int id, string name, DateTime dateTime, string v1, int v2) : base(id, name)
        {
            DateTime = dateTime;
            V1 = v1;
            V2 = v2;
        }

        override public string ToString()
        {
            return $"Emp Details={base.Print()}, Project={Project},Teamsize={Teamsize}";
        }
    }
}
