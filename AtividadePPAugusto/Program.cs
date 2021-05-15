using System;

namespace AtividadePPAugusto
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
            string nome;
            int ponto = 0;
            int nivel = 0;


            Console.WriteLine("Infomre seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("************VAMOS COMEÇAR**************" +
                "\n**************1º NIVEL:***************");

             Perguntas ler; 
             ler = new Perguntas();

            for (int i = 0; i <= ler.PERG.Length; i++)
            {
                nivel = +i;
                if (nivel == 0)
                {
                    Console.WriteLine(ler.PERG[nivel] +
                        "\nA)Brasil \n" +
                        "B)França \n" +
                        "C)Alemanhã \n" +
                        "D)Argentina \n" +
                        "[SEU NOME:] " + nome +
                        "\n[Pontuação:] " + ponto +
                        "\n[Nivel:] " + nivel);
                    String resposta = Console.ReadLine();
                    switch (resposta)
                    {
                        case "B":
                            Console.WriteLine("Você Acertou ");
                            ponto = ponto + 10;
                            break;
                        case "A":
                            Console.WriteLine("Você Errou ");
                            ponto = ponto - ponto;
                            break;
                        case "C":
                            Console.WriteLine("Você Errou ");
                            ponto = ponto - ponto;
                            break;
                        case "D":
                            Console.WriteLine("Você Errou ");
                            ponto = ponto - ponto;
                            break;


                    }


                }
                else if (nivel == 1)
                {
                    Console.WriteLine(ler.PERG[nivel] +
                           "\nA)Galinha \n" +
                           "B)Zebra \n" +
                           "C)Macaco \n" +
                           "D)Leão \n" +
                           "[SEU NOME:] " + nome +
                           "\n[Pontuação:] " + ponto +
                           "\n[Nivel:] " + nivel);
                    String resposta = Console.ReadLine();
                    switch (resposta)
                    {
                        case "D":
                            Console.WriteLine("Você Acertou ");
                            ponto = ponto + 30;
                            break;
                        case "A":
                            Console.WriteLine("Você Errou ");
                            ponto = ponto - ponto;
                            break;
                        case "C":
                            Console.WriteLine("Você Errou ");
                            ponto = ponto - ponto;
                            break;
                        case "B":
                            Console.WriteLine("Você Errou ");
                            ponto = ponto - ponto;
                            break;
                    }
                } else if (nivel==2) 
                {
                    Console.WriteLine(ler.PERG[nivel] +
                            "\nA)Morango \n" +
                            "B)Abobora \n" +
                            "C)Castanha \n" +
                            "D)Limão \n" +
                            "[SEU NOME:] " + nome +
                            "\n[Pontuação:] " + ponto +
                            "\n[Nivel:] " + nivel);
                    String resposta = Console.ReadLine();
                    switch (resposta)
                    {
                        case "B":
                            Console.WriteLine("Você Acertou ");
                            ponto = ponto + 13;
                            break;
                        case "A":
                            Console.WriteLine("Você Errou ");
                            ponto = ponto - ponto;
                            break;
                        case "C":
                            Console.WriteLine("Você Errou ");
                            ponto = ponto - ponto;
                            break;
                        case "D":
                            Console.WriteLine("Você Errou ");
                            ponto = ponto - ponto;
                            break;
                    }
                }
            }


     
           




        }

      

    }
}
