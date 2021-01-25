using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];  //array; 
            var indiceAluno = 0;
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {

                switch (opcaoUsuario)

                {
                    case "1":
                        //TODO: add alunos
                        Console.WriteLine("Informe o nome do aluno: ");
                        var aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Informe a nota do aluno: ");
                            //converte int para decimal neste caso;
                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;
                        }else
                        {   //trata a excecao readLine;
                            throw new ArgumentException("Valor da nota de ser decimal");
                        }

                        alunos[indiceAluno] = aluno; 
                        indiceAluno++;
                        

                        break;

                    case "2":

                        //TODO: lista alunos
                        foreach( var a in alunos)
                        {
                            if(!string.IsNullOrEmpty(a.Nome))
                            {
                            Console.WriteLine($"Aluno: {a.Nome} - Nota: {a.Nota}");

                            }
                        }
                        break;

                    case "3":
                        //TODO: Calcula a média geral

                        decimal notaTotal =0;
                        var nrAlunos =0;

                        for(int i=0; i< alunos.Length; i++)
                        {
                            if(!String.IsNullOrEmpty(alunos[i].Nome))
                            {
                            notaTotal = notaTotal + alunos[i].Nota;
                                nrAlunos++;
                            }
                        }
                                conceitoE conceitoGeral;
                                var mediaGeral = notaTotal/nrAlunos;

                                if(mediaGeral < 2)
                                {
                                    conceitoGeral = conceitoE.E;
                                }
                                 else if(mediaGeral < 4)
                                 {
                                     conceitoGeral = conceitoE.D;
                                 }
                                else if(mediaGeral <6)
                                {
                                    conceitoGeral = conceitoE.C;
                                }
                                 else if(mediaGeral <8)
                                {
                                    conceitoGeral = conceitoE.B;
                                }
                                else{
                                    conceitoGeral = conceitoE.A;
                                }

                                Console.WriteLine($"Media geral: {mediaGeral}");
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
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
