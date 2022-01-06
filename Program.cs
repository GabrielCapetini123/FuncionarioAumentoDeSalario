using System;
using System.Collections.Generic;
using System.Globalization;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos funcionários vão ser registrados? ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionários> list = new List<Funcionários>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Funcionário # " + i + ": ");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Funcionários(id, nome, salario));
                Console.WriteLine();
            }

            Console.WriteLine("Digite o Id de quem deseja aumentar o salário: ");
            int searchId = int.Parse(Console.ReadLine());

            Funcionários emp = list.Find(x => x.Id == searchId);
            if (emp != null)
            {
                Console.WriteLine("Entre com a porcentagem: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncluirSalario(percentage);
            }
            else
            {
                Console.WriteLine("Este Id não existe! ");
            }

            Console.WriteLine();
            Console.WriteLine("Lista de funcionários: ");
            foreach(Funcionários obj in list)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
