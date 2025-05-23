using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo_Estacionamento.Models
{
    internal class Estacionamento(decimal x, decimal y)
    {

        List<string> veiculos = new List<string>();
        public decimal entrada = x, valorHora = y;


        public void AddVeiculo()
        {
            string? placa;
            Console.WriteLine("Digite a placa do veiculo");


            placa = Console.ReadLine();

            if (placa != null)
            {
                veiculos.Add(placa);
                Console.WriteLine("Veiculo adicionado com sucesso\n");
            }
            else
            {
                Console.WriteLine("Erro tente novamente \n");
            }

        }

        public void RemoverVeiculo()
        {
            string? placa;
            Console.WriteLine("Digite a placa do veiculo para remover");
            placa = Console.ReadLine();

            if (placa != null)
            {
                veiculos.Remove(placa);
                Console.WriteLine("Veiculo removido com sucesso\n");
            }
            else
            {
                Console.WriteLine("Erro tente novamente \n");
            }
        }

        public void ListarVeiculos()
        {
            foreach (var item in veiculos)
            {
                Console.WriteLine($"Veiculo : {item}");
            }
        }

        public void Encerrar()
        {
            Environment.Exit(0);
        }

    }
}
