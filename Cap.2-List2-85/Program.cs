using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap._2_List2_85
{
    class Program
    {
        static WeakReference data;

        static void Main(string[] args)
        {
        }

        public static void Run()
        {
            object result = GetData();
            //GC.Collect();
            result = GetData();
        }

        private static object GetData()
        {
            if (data == null)
            {
                data = new WeakReference(LoadLargeList());
            }

            if(data.Target == null)
            {
                data.Target = LoadLargeList();
            }

            return data.Target;
        }
    }
}
