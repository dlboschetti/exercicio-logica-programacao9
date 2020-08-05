using System;

namespace exercicio_logica_programacao9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Percentual de votos em relação ao total de eleitores

            //Considerando as variáveis abaixo:

            //            total de eleitores
            //              válidos
            //              votos brancos
            //              nulos

            //Faça uma classe com 3 métodos que calculam:

            //      -o percentual do votos válidos em relação ao total de eleitores,
            //      -o percentual de brancos em relação ao total de eleitores
            //      - o percentual de nulos em relação ao total de eleitores.

            //Dica: “em relação ao total” significa que você deve dividir, por exemplo, “nulos” pelo total de eleitores,
            //válidos pelo total de eleitores, etc…

            //Utilize programação orientada a objetos.

            Eleicao eleicao = new Eleicao();

            Console.WriteLine("Informar total de eleitores:");
            eleicao.totalEleitores = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informar total de votos validos:");
            eleicao.votosValidos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informar total de votos nulos:");
            eleicao.votosNulos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informar total de votos em branco:");
            eleicao.votosBrancos = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine($"Percentual de votos válidos:  {eleicao.PercVotosValidos()}.");
            Console.WriteLine($"Percentual de votos nulos:  {eleicao.PercVotosNulos()}.");
            Console.WriteLine($"Percentual de votos brancos:  {eleicao.PercVotosBrancos()}.");




        }
    }
}
