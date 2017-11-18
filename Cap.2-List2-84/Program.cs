using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap._2_List2_84
{
    class Program
    {
        static void Main(string[] args)
        {
            UnmanagedWrapper wrapper = new UnmanagedWrapper();
        }
    }

    class UnmanagedWrapper : IDisposable
    {
        public FileStream Stream { get; private set; } 
        public UnmanagedWrapper()
        {
            this.Stream = File.Open("temp.dat", FileMode.Create);
        }

        ~UnmanagedWrapper()
        {
            Dispose(false);
        }

        public void Close()
        {
            Dispose();
        }

        public void Dispose()
        {
            Dispose(true);
            System.GC.SuppressFinalize(this);
        }

        public void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (Stream != null) { Stream.Close(); }
            }
        }
    }
}

/*
 * Implementing IDisposable and a finalizer
 * */
