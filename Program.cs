using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioFixacaoAula78_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o numero de Funcionarios que deseja add a lista: ");
            int nFuncionarios = int.Parse(Console.ReadLine());

            List<Funcionario> lista = new List<Funcionario>();

            for(int i = 0; i < nFuncionarios; i++)
            {
                Console.WriteLine($"Funcionario #{i}: ");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                lista.Add(new Funcionario(id, nome, salario));
                Console.WriteLine();
            }

            Console.Write("Entre com o Id do funcionario que deseja aumentar o salario: ");
            int enterId = int.Parse(Console.ReadLine());

            Funcionario f1 = lista.Find(x => x.Id == enterId);
            if(f1 != null)
            {
                Console.Write("Entre com a porcentagem para aumento: ");
                double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                f1.AumentarSalario(percent);
            }
            else
            {
                Console.WriteLine("Numero Id não existente! ");
            }
            Console.WriteLine();

            Console.WriteLine("Lista de funcionarios Atualizada: ");
            foreach(Funcionario f in lista)
            {
                Console.WriteLine(f);
            }

            Console.ReadLine();
        }
    }
}
