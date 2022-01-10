
namespace ExercicioHeranca.Entidades {
    class FuncionarioTerceirizado : Funcionario {

        public double DespesaAdicional { get; set; }

        public FuncionarioTerceirizado(string nome, int horas, double valorPorHora, double despesaAdicional)
            : base(nome, horas, valorPorHora) {
            this.DespesaAdicional = despesaAdicional;
        }

        public override double Pagamento() {
            return base.Pagamento() + 1.1 * DespesaAdicional;
        }
    }
}
