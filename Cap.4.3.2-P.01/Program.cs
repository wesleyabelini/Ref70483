using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap._4._3._2_P._01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pessoas = { "marcelo", "Pedro", "Abacaxi" };
            int[] num = { 1, 10, 15, 2, 8, 60, 10, 32, 58, 45, 12, 4, 5, 6, 9, 8, 5, 4, 56 };
            string[] coisa = { "Carro", "Ferro", "fruta" };

            var lamb = from p in pessoas
                       where p.Contains("marcelo")
                       select p;

            IEnumerable<int> lamNum = from n in num
                           where n > 10
                           orderby n ascending
                           select n;
            //esta sequência pode ser declarada como var


            foreach(var i in lamb)
            {
                Console.WriteLine(i);
            }

            foreach(int i in lamNum)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            buscaPessoa();
        }

        public static void buscaPessoa()
        {
            Pessoa[] p =
            {
                new Pessoa{Age=18, isMale=false, Name="Amiga Feliz", Filhos= new Filhos { Age=8, Name="Fredinho"} },
                new Pessoa{Age=23, isMale=false, Name="Joana D'arc", Filhos= new Filhos {Age=3, Name="Mariazinha" } },
                new Pessoa{Age=22, isMale=true, Name="Leonardo Da Vinci", Filhos=null},
                new Pessoa{Age=50, isMale=true, Name="Mamonas Assassinas"},
                new Pessoa{Age=35, isMale=false, Name="Maria Madalena"},
                new Pessoa{Age=82, isMale=true, Name="Papai Noel", Filhos= new Filhos {Age=30, Name="Robertão" } },
            };

            var pessoas = from pessoa in p
                          where pessoa.Age < 25 && pessoa.isMale==false
                          orderby pessoa.Age
                          select pessoa;

            var pessoaFilhos = from pFilhos in p
                               where (pFilhos.Filhos != null) && (pFilhos.Filhos.Age > 25)
                               select pFilhos;

            foreach(Pessoa valor in pessoas)
            {
                Console.WriteLine(valor.Name);
            }

            Console.WriteLine();

            foreach(Pessoa pFilhos in pessoaFilhos)
            {
                Console.WriteLine("{0} tem um filho chamado {1} de {2} anos.", pFilhos.Name, pFilhos.Filhos.Name, 
                    pFilhos.Filhos.Age);
            }
        }
    }

    public class Pessoa
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public bool isMale { get; set; }

        public Filhos Filhos { get; set; }
    }

    public class Filhos
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
