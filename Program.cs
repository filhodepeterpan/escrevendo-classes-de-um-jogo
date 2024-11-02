using System;

namespace DesafioClassesDeHeroi
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "";
            int idade = 0;
            string tipo = "";

            Heroi heroi = new Heroi(nome, idade, tipo);

            Console.WriteLine($"Qual o nome do seu personagem?\n");
            nome = Console.ReadLine() ?? "";

            Console.WriteLine($"\nQual a idade do personagem?\n");
            idade = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine($"\nQual o tipo do Herói?");
            tipo = (Console.ReadLine () ?? "").ToLower();

            heroi.Nome = nome;
            heroi.Idade = idade;
            heroi.Tipo = tipo;

            heroi.Ataca();

        }
    }
}
