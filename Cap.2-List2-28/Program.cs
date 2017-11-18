using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap._2_List2_28
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static void DisplayInExcel(IEnumerable<dynamic> entities)
        {
            var excelApp = new Excel.Application();
            excelApp.Visible = true;
        }
    }
}

//pag 136
