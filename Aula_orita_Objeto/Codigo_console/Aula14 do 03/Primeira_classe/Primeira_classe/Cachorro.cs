using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeira_classe
{
    class Cachorro
    {
        //Atributos
        public string nome;
        public string raça;
        public int idade;
        public float peso;

        //Metodos
        public void latir()
        {
            Console.WriteLine($"{nome} esta latindo");
        }

        public void abanar()
        {
            Console.WriteLine($"{nome} esta animado");
        }
    }
}
