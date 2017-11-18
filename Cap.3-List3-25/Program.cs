using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Cap._3_List3_25
{
    class Program
    {
        static void Main(string[] args)
        {
            //this is Imperative CAS

            FileIOPermission f = new FileIOPermission(PermissionState.None);
            f.AllLocalFiles = FileIOPermissionAccess.Read;

            try
            {
                f.Demand();
            }
            catch(SecurityException s)
            {
                Console.WriteLine(s.Message);
            }

            DeclarativeCAS();
        }

        [FileIOPermission(SecurityAction.Demand, AllLocalFiles = FileIOPermissionAccess.Read)]
        public static void DeclarativeCAS()
        {
            //this block is Declarative CAS
        }
    }
}

/*
 * You can specify CAS = "Code Access Security", in two ways: declarative or imperative
 * 
 * */
