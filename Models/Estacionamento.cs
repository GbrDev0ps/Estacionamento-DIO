using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estacionamento_DIO.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora){
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;

        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veiculo para estacionar: ");
            string veiculo = Console.ReadLine();
            veiculos.Add(veiculo);
            Console.WriteLine("veiculo estacionado.");
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veiculo para remover: ");
            string placa = Console.ReadLine();
            

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veiculo permaneceu estacionado: ");
                int horas = int.Parse(Console.ReadLine());

                decimal valorTotal = precoInicial + (precoPorHora * horas);

                veiculos.Remove(placa);
                Console.WriteLine("Veiculo removido, siga para o pagamento e boa-viagem!");
            }
            else{
                Console.WriteLine("Desculpe, essa placa não está registrada no estacionamento. Peço que confira se digitou os nuúmeros corretamente");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veiculos estacionados são: ");
                foreach ( var veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            } 
            else {
                Console.WriteLine("Não tem veiculos estacionados: ");
            }
        }

    }
}