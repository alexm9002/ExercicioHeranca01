using System;
using System.Collections.Generic;
using System.Globalization;
using ExercicioHeranca.Entidades;


namespace ExercicioHeranca {

    class Program {
        static void Main(string[] args) {

            List<Funcionario> Lista = new List<Funcionario>();

            Console.Write("Entre como o número de funcionários: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Funcionário #{i} data:");
                Console.Write("Terceirizado? (S/N)");
                char t = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Horas: ");
                int horas = int.Parse(Console.ReadLine());
                Console.Write("Valor por Hora: ");
                double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (t == 's' || t == 'S') {
                    Console.Write("Entre com despesa adicional: ");
                    double despesaAdicional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Lista.Add(new FuncionarioTerceirizado(nome, horas, valorPorHora, despesaAdicional));
                }
                else {
                    Lista.Add(new Funcionario(nome, horas, valorPorHora));
                }


            }
            Console.WriteLine();
            Console.WriteLine("Pagamentos: ");
            foreach (Funcionario t in Lista) {
                Console.WriteLine(t.Nome + " - R$ " + t.Pagamento().ToString("F2", CultureInfo.InvariantCulture));

            }


        }
    }
}
