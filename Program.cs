using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o seu nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Entre com sua altura em metros. Ex: 1,65");
            float altura = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Entre com o seu peso em Kg. Ex: 67,7");
            float peso = Convert.ToSingle(Console.ReadLine());

            Individuo i1 = new Individuo(nome, peso, altura);

            Console.WriteLine(i1.IMC);
            Console.WriteLine(i1.ClassificacaoIMC());
            Console.WriteLine(i1.ParaPesoIdeal());

        }
    }
}
