using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Aluno> ListaDeAlunos = new List<Aluno>();
            bool aux = true;

            Console.Write("Digite a quantidade de alunos: ");


            int TotalAlunos = int.Parse(Console.ReadLine());
            while (aux)
            {
                if (TotalAlunos > 10 || TotalAlunos <= 0)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Ultrapassou o limite de quartos disponieis");
                    Console.ResetColor();
                    Console.Write("Digite a quantidade de alunos: ");
                    TotalAlunos = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("---------------------------------\n");
                    Atendimento_Estudante.Cadastrar(ListaDeAlunos, TotalAlunos);
                    Atendimento_Estudante.GetExibir(ListaDeAlunos);
                    Console.WriteLine("---------------------------------\n");
                    Atendimento_Estudante.GetQuartosOcupados(ListaDeAlunos);
                    aux = false;
                }
            }

            Console.ReadKey();



        }
    }
}
