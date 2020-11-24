using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace MestreDosCodigos_Exercicio04
{
    public class Aluno
    {
        public string Nome { get; private set; }
        public IReadOnlyList<double> Notas { get; private set; }

        public Aluno(string nome, IReadOnlyList<double> notas)
        {
            Nome = nome;
            Notas = notas;
        }

        public double CalcularMediaDasNotas()
        {
            return (Notas.Sum() / Notas.Count);
        }

        public override string ToString()
        {
            var mediaDasNotas = CalcularMediaDasNotas();
            return $"Aluno: {Nome} | Média das notas: {mediaDasNotas.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
