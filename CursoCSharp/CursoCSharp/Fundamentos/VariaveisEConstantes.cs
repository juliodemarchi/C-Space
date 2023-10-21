using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class VariaveisEConstantes {
        public static void Executar() {
            // area da circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            // PI = 3.1415;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Area é: " + area);

            //Tipos internos
            bool EstaChovendo = true;
            Console.WriteLine("Está chovendo " + EstaChovendo);

            //Quantidade de armazenamento
            byte idade = 45;
            Console.WriteLine("Idade " + idade);

            sbyte SaldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols " + SaldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salário " + salario);

            int menorValorInt = int.MinValue; //Mais usado dos inteiros!
            Console.WriteLine("Menor int " + menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População Brasileira " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor Valor Long " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População Mundial " + populacaoMundial);

            float PrecoDeComputador = 1299.99f;
            Console.WriteLine("Preço De Computador " + PrecoDeComputador);

            double ValorDeMercadoApple = 1_000_000_000_000_00; // Mais usado dos reais!
            Console.WriteLine("Valor Da Apple " + ValorDeMercadoApple);

            decimal DistanciaEntreEstrelas = decimal.MaxValue;  //Para valores imensos!
            Console.WriteLine("Distancia entre estrelas " + DistanciaEntreEstrelas);

            char Letra = 'A'; //Apenas um caracter
            Console.WriteLine("Letra " + Letra);

            string texto = "Seja Bem vindo ao curso de C#! "; // palavras e frases!
            Console.WriteLine(texto);



        }
    }
}
