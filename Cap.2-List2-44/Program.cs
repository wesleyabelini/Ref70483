using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap._2_List2_44
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimal animal = new Dog();
        }
    }

    interface IAnimal
    {
        void Move();
    }

    class Dog : IAnimal
    {
        public void Move()
        {
            //...
        }

        public void Bark()
        {
            //...
        }
    }
}

/*
 * work like a contract
 * */
