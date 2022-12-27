using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    public class Aluno
    {
        public string _Nome { get; set; }
        public string _Email { get; set; }
        public double Aluguel { get; set; }
        protected int _quarto;

        public int Quarto
        {
            get { return _quarto; }
            set
            {
                bool aux = true;
                while (aux == true)
                {
                    if (value < 0)
                    {
                        Console.WriteLine("Quarto não existe. Quarto a partir de 0 a 10. ");
                        Console.Write("Digite  qual quarto você tem interesse: ");
                        value = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        _quarto = value;
                        aux = false;
                    }
                }
            }
        }


    }
}

