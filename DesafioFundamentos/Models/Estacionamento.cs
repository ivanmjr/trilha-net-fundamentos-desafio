namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // Implementar Adicionar Veiculo na Lista
            Console.WriteLine($"Digite a placa do veículo para estacionar:");
            veiculos.Add(Console.ReadLine());                    
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine($"Digite a placa do veículo para remover:");

            
            string placa = "";
            Console.WriteLine($"Informe a placa que deseja Remover: ");
            placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {                
                // Solicita quantidade de horas estacionado e realiza o calculo final a pagar
                int horas = 0;
                decimal valorTotal = 0; 
                Console.WriteLine($"Digite a quantidade de horas que o veículo {placa} permaneceu estacionado:");
                horas = Convert.ToInt32(Console.ReadLine());
                valorTotal = precoInicial + (precoPorHora * horas);

                // Remove a placa digitada da lista de veículos 
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                veiculos.Remove(placa); 
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // Realiza um laço de repetição, exibindo os veículos estacionados                
                int contadorVeiculo = 1;
                foreach(string item in veiculos)
                {
                    Console.WriteLine($"{contadorVeiculo} Veiculo: {item}");
                    contadorVeiculo ++;
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
