namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public int capacidadeTotal;
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {    
   
            var capacidade = false;
           if(capacidadeTotal >= hospedes.Count) capacidade = true;
            if (capacidade)
            {
                Hospedes = hospedes;
                var teste = Suite;
            }
            else
            {
                new Exception("capacidade maio que permnitido");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
            capacidadeTotal = suite.Capacidade;
        }

        public int ObterQuantidadeHospedes()
        {
            if(capacidadeTotal > 0){
                return capacidadeTotal;
            }
            return 0;
        }

        public decimal CalcularValorDiaria()
        {

            decimal valor = 0;
            valor = DiasReservados * Suite.ValorDiaria;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            bool temDesconto = false;
            if(DiasReservados>= 10) temDesconto = true;
            
            if (temDesconto)
            {

                valor = valor - (valor/10);
            }

            return valor;
        }
    }
}