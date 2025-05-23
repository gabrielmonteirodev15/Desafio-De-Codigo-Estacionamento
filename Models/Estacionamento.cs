using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo_Estacionamento.Models
{
    ///Clase Estacionamento
    ///Contém as ações que pode ser feitas
    ///Adicionar veiculos
    ///Remover veiculos
    ///Listar veiculos 
    ///Encerrar o programa
    internal class Estacionamento(decimal x, decimal y)
    {

        List<string> veiculos = new List<string>();
        public decimal entrada = x, valorHora = y;


        ///Metodo para adicionar veiculos 
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

        ///Metodo oara remover veiculos 
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

        ///Metodo para listar os veiculos
        public void ListarVeiculos()
        {
            foreach (var item in veiculos)
            {
                Console.WriteLine($"Veiculo : {item}");
            }
        }

        ///Metodo para encerrar o programa
        public void Encerrar()
        {
            Environment.Exit(0);
        }

    }
}
