using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarroCompleto
{
    class Carro
    {
        public String cor;
        public string modelo;
        public int anoFabricacao;
        public float velocidadeAtual;
        public float velocidadeMaxima;
        public Boolean estaLigado;

        public Carro(string cor, string modelo, int anoFabricacao, float velocidadeMaxima)
        {
            this.cor = cor;
            this.modelo = modelo;
            this.anoFabricacao = anoFabricacao;
            this.velocidadeAtual = 0;
            this.velocidadeMaxima = velocidadeMaxima;
            this.estaLigado = false;
        }
        //Metodos
        public void LigarCarro()
        {
            if(!estaLigado)
            {
                estaLigado = true;
                Console.WriteLine("O carro esta ligado");
            }
            else
            {
                Console.WriteLine("O carro ja esta ligado");

            }
        }
        public void Acelerar()
        {
            if (estaLigado)
            {
                if (velocidadeAtual < velocidadeMaxima)
                {
                    velocidadeAtual += 30;
                    if (velocidadeAtual > velocidadeMaxima)
                    {
                        velocidadeAtual = velocidadeMaxima;
                    }
                    Console.WriteLine($"Velocidade atual e {velocidadeAtual}");
                }
                else
                {
                    Console.WriteLine("O carro esta na velocidade Maxima");
                }
            }
            else
            {
                Console.WriteLine("O carro esta desligado...");
            }
        }
          
    }
}
