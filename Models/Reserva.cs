namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }
    
        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*
            if (Suite.Capacidade>= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                // *IMPLEMENTE AQUI*
                throw new InvalidCastException($"A capacidade da súite é de {Suite.Capacidade} pessoas");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
            {
            return Hospedes.Count;
            }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            decimal valorDiaria = DiasReservados * Suite.ValorDiaria;
            // *IMPLEMENTE AQUI*
            decimal valorDaReserva = valorDiaria;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if (DiasReservados >= 10)
            {
                valorDaReserva = valorDiaria - (valorDiaria * 0.10M);
                Console.WriteLine($"Valor da reserva com 10% de desconto: {valorDaReserva}");
            }
            return valorDaReserva;
            
        }
    }
}