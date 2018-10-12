using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GCLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> list = new List<object>();

            for(int i = 0; i<50; i++)
            {
                list.Add(new { Id = 1, Name = "admin" });
                Thread.Sleep(500);
            }
            list = null;
            GC.Collect();
        }
    }
}
