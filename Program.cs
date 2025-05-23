using DesafioDeCodigo_Estacionamento.Models;

decimal entrada, valorHora;

Console.WriteLine("Bem vindo ao sistema do estacionamento");
Console.WriteLine("Qual o valor de entrada do estacionamento");

entrada = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Qual o valor da hora");

valorHora = Convert.ToDecimal(Console.ReadLine());

Estacionamento e = new Estacionamento(entrada, valorHora);

bool menu = true;

while (menu)
{
    Console.WriteLine("Menu do estacionamento \n1-Adicionar veiculo \n2-Remover veiculo \n3-Listar veiculos \n4-Encerrar");



    switch (Console.ReadLine())
    {
        case "1":
            e.AddVeiculo();
            break;

        case "2":
            e.RemoverVeiculo();
            break;

        case "3":
            e.ListarVeiculos();
            break;
        case "4":
            e.Encerrar();
            break;

        default:
            Console.WriteLine("Entrada invalida");
            break;
    }
}