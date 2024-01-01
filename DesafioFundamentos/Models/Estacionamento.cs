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
            string placa;
            Console.WriteLine("Digite a placa do veículo para estacionar: ");
            placa = Console.ReadLine();
            veiculos.Add(placa);
            Console.WriteLine("Veículo adicionado com sucesso");

        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Os veículos cadastrados são:");
            foreach(var item in veiculos)
            {
                Console.WriteLine(item.ToUpper());
            }
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = 0;
                horas = Int32.Parse(Console.ReadLine());
                decimal valorTotal = 0; 
                valorTotal = precoInicial + precoPorHora * horas;
                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa.ToUpper()} foi removido e o preço total foi de: R$ {valorTotal}" +
                $" (sendo R${precoInicial} por estacionar e R${precoPorHora}/hora).");
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
                foreach(var item in veiculos)
                {
                    Console.WriteLine(item.ToUpper());
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
