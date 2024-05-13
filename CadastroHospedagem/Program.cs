using System;
using System.Collections.Generic;
using System.Text;
using CadastroHospedagem.Models;

namespace CadastroHospedagem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Cria os modelos de hóspedes e cadastra na lista de hóspedes
            List<Pessoa> hospedes = new List<Pessoa>();

            Console.WriteLine("Quantidade de hospedes na reserva: ");
            string SNumHospedes = Console.ReadLine();
            int numHospedes = Int32.Parse(SNumHospedes);

            for(int i = 0; i < numHospedes; i++)
            {
                Console.WriteLine("Nome do hóspede " + i + ": ");
                string nomeHospede = Console.ReadLine();

                hospedes.Add(new Pessoa(nome: nomeHospede));
            }

            Console.WriteLine("Qual o tipo da suite: ");
            string tipoSuite = Console.ReadLine();

            if(tipoSuite == "Premium" && numHospedes == 2)
            {
                Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);
                Reserva reserva = new Reserva(diasReservados: 5);
                reserva.CadastrarSuite(suite);
                reserva.CadastrarHospedes(hospedes);

                // Exibe a quantidade de hóspedes e o valor da diária
                Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes(hospedes)}");
                Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria(reserva)}");

            } else if (tipoSuite == "Premium" && numHospedes != 2)
            {
                Console.WriteLine("Capacidade da suíte nao corresponde ao numero de hóspedes!");

            } else if (tipoSuite == "Standart" && numHospedes == 1)
            {
                Suite suite = new Suite(tipoSuite: "Standart", capacidade: 1, valorDiaria: 20);
                Reserva reserva = new Reserva(diasReservados: 5);
                reserva.CadastrarSuite(suite);
                reserva.CadastrarHospedes(hospedes);

                // Exibe a quantidade de hóspedes e o valor da diária
                Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes(hospedes)}");
                Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria(reserva)}");
            } else if (tipoSuite == "Standart" && numHospedes != 1)
            {
                Console.WriteLine("Capacidade da suíte nao corresponde ao numero de hóspedes!");
            }


        }
    }
}
