using System;

namespace DesafioClassesDeHeroi
{
    public class Heroi
    {
        private string nome = "";
        private int idade = 0;
        private string tipo = "";

        public string Nome 
        {
            get {return nome;}
            set {nome = value;}
        }

        public int Idade 
        {
            get {return idade;}
            set {idade = value;}
        }

        public string Tipo
        {
            get {return tipo;}
            set {tipo = value;}
        }

        public Heroi(string nome, int idade, string tipo)
        {
            Nome = nome;
            Idade = idade;
            Tipo = tipo;
        }

        public string VerificaAtaque()
        {   
            string ataque = "";

            if (tipo == "mago")
            {
                ataque = "magia";
            }
            else if (tipo == "guerreiro")
            {
                ataque = "espada";
            }
            else if (tipo == "monge")
            {
                ataque = "artes marciais";
            }
            else if (tipo == "ninja")
            {
                ataque = "shuriken";
            }

            return ataque;
        }
        public void Ataca()
        {   
            string ataque = VerificaAtaque();

            Console.WriteLine($"O {tipo} atacou usando {ataque}");
        }
    }
}