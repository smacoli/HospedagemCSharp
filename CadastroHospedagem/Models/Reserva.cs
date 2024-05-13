using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroHospedagem.Models
{
    class Reserva
    {

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

            if (hospedes.Count > Suite.Capacidade)
            {
                throw new InvalidOperationException("O numero de hospedes excede a capacidade da suite. Escolha uma suite de maior capacidade.");
            }
            else if (hospedes.Count < Suite.Capacidade)
            {

                throw new InvalidOperationException("O numero de hospedes e menor que a capacidade da suite. Escolha uma suite de menor capacidade.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes(List<Pessoa> hospedes)
        {
            return hospedes.Count;
        }

        public decimal CalcularValorDiaria(Reserva r)
        {
            decimal valor = 0;

            if (r.DiasReservados >= 10)
            {
                valor = ((DiasReservados * Suite.ValorDiaria) * 10) / 100;

            } else if (r.DiasReservados < 10)
            {
                valor = DiasReservados * Suite.ValorDiaria;
            }

            return valor;
        }
    }
}
