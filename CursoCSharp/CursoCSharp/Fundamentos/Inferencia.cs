using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class Inferencia {
        public static void Executar() {
            var nome = "Julio";
            // nome = 123;
            Console.WriteLine(nome);

            var idade = 32;
            // int idade;
            Console.WriteLine(idade);

            
            //eclarando a variavel e atribuindo o valor dela na proxima linha
            int a;
            a = 3;

            //Declarando a variavel e atribuindo o valor dela na mesma linha
            int b = 2;

            Console.WriteLine(a + b);
        }
    }
}
