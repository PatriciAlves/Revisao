using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {

                switch (opcaoUsuario)

                {
                    case "1":
                        //TODO: add alunos
                        break;

                    case "2":

                        //TODO: lista alunos
                        break;

                    case "3":
                        //TODO: Calcula a média geral
                        break;

                    default: // caso não seja nenhum desses valores
                        throw new ArgumentOutOfRangeException();
                        // dispara um excessao informando que o valor esta fora do "range" programado.
                }
            }
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1 - Inserir novo aluno. ");
            Console.WriteLine("2 - Listar alunos.");
            Console.WriteLine("3 - Calcular media geral.");
            Console.WriteLine("X - Sair.");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            return opcaoUsuario;
        }
    }
}
