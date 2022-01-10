using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioHeranca.Entidades {
    internal class Funcionario {
        public string Nome { get; set; }
        public int Horas { get; set; }
        public double ValorPorHora { get; set; }

        public Funcionario(string nome, int horas, double valorPorHora) {
            this.Nome = nome;
            this.Horas = horas;
            this.ValorPorHora = valorPorHora;
        }
        public virtual double Pagamento() {
            return Horas * ValorPorHora;
        }
    }
}
