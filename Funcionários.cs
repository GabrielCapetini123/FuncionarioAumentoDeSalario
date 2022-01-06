using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ConsoleApp6
{
    class Funcionários
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

       public Funcionários(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void IncluirSalario(double percentage)
        {
            Salario += Salario * percentage / 100.0;
        }

        public override string ToString()
        {
            return Id
                + ", "
                + Nome
                + ", "
                + Salario.ToString("F3", CultureInfo.InvariantCulture);
        }
    }
}
