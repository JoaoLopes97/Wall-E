using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Wall_E
{
    public static class Leitor
    {
        /// <summary>
        /// Lê uma sequencia da consola e retorna a mesma, caso a sequencia não seja valida é pedida novamente.
        /// </summary>
        /// <returns>sequencia valida inserida pelo jogador. </returns>
        public static string LerSequencia()
        {
            Console.WriteLine("Indique qual a sequência de movimentos que pretende fazer (N,S,E,O):");
            var sequencia = Console.ReadLine().ToUpper();

            if (VerificarSequencia(sequencia)) return sequencia;
            else
            {
                Console.WriteLine("A sequência fornecida têm caracteres proibidos, deverá só utilizar os seguintes: N,S,E,O");
                return LerSequencia();
            }
        }

        /// <summary>
        /// Recebe uma sequencia e verifica se a mesma é valida para o jogo.
        /// </summary>
        /// <param name="sequencia">sequencia inserida pelo jogador.</param>
        /// <returns>boolean </returns>
        public static bool VerificarSequencia(string sequencia)
        {
            Regex rg = new("[NSEO]");

            return !string.IsNullOrEmpty(sequencia) && sequencia.All(ch => rg.Match(ch.ToString()).Success);
        }
    }
}
