using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    public class Atendimento_Estudante
    {
        public static void Cadastrar(List<Aluno> ListaDeAluno, int Total)
        {

            for (int i = 0; i < Total; i++)
            {
                Console.WriteLine($" --------ESTUDANTE {i + 1}----------\n");
                Aluno aluno = new Aluno();
                Console.Write("Digite o nome do estudante: ");
                aluno._Nome = Console.ReadLine();
                Console.Write("Digite o seu email: ");
                aluno._Email = Console.ReadLine();
                Console.Write("Digite o aluguel: ");
                aluno.Aluguel = double.Parse(Console.ReadLine());
                Console.Write("Digite  qual quarto você tem interesse: ");
                int quarto = int.Parse(Console.ReadLine());
                bool aux = true;

                while (aux == true)
                {
                    if (VerificarQuarto(ListaDeAluno, quarto) == false)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Quarto ocupado: ");
                        Console.ResetColor();
                        Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                        Console.Write("Digite  qual quarto você tem interesse: ");
                        quarto = int.Parse(Console.ReadLine());
                        VerificarQuarto(ListaDeAluno, quarto);
                    }
                    else
                    {
                        aluno.Quarto = quarto;
                        aux = false;

                    }
                }
                ListaDeAluno.Add(aluno);

                Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>\n");
            }


        }
        private static bool VerificarQuarto(List<Aluno> ListaDeAluno, int quarto)
        {
            bool aux = ListaDeAluno.Exists(p => p.Quarto == quarto);
            if (aux == true)
            {
                return false;
            }
            return true;

        }

        public static void GetQuartosOcupados(List<Aluno> ListaDeAluno)
        {
            int[] quartosOcupados = new int[ListaDeAluno.Count];
            Console.WriteLine("<<<<<<<<<<<<<<<<QUARTOS OCUPADOS>>>>>>>\n");
            Console.WriteLine("QUARTO\t NOME \t EMAIL");
            for (int i = 0; i < ListaDeAluno.Count; i++)
            {
                quartosOcupados[i] = ListaDeAluno[i].Quarto;


                Console.WriteLine($"{quartosOcupados[i]} \t {ListaDeAluno[i]._Nome} \t {ListaDeAluno[i]._Email} ");
            }


        }


        public static void GetExibir(List<Aluno> ListaDeAluno)
        {
            foreach (Aluno item in ListaDeAluno)
            {
                Console.WriteLine("---------------------------------------------\n");
                Console.WriteLine($" === LISTA DOS QUARTOS ALUGADOS  === \n");
                Console.WriteLine($"Nome : {item._Nome} \n");
                Console.WriteLine($"Email : {item._Email} \n");
                Console.WriteLine($"Quarto: {item.Quarto} \n");
                Console.WriteLine($"Aluguel : {item.Aluguel:C} \n");
                Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                Console.ReadKey();
            }
        }

    }
}
