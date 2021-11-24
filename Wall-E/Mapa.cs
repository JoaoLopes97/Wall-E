using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_E
{
    public class Mapa
    {
        private const int NumCasas = 10;
        public List<List<int>> Grelha { get; set; }

        public Mapa()
        {
            Grelha = new List<List<int>>
            {
                GenerateNewLine(),
                GenerateNewLine(),
                GenerateNewLine(),
                GenerateNewLine()
            };

            Grelha[0][0] = 0;
        }

        /// <summary>
        /// Atraves da posicaoY recebida vai inserir no mapa uma nova linha nessa mesma posicao.
        /// </summary>
        /// <param name="posicaoY">posicao na lista onde pretendemos adicionar a nova linha.</param>
        public void AdicionarCasasY(int posicaoY)
        {
            Grelha.Insert(posicaoY, GenerateNewLine());
        }

        /// <summary>
        /// Atraves da posicao do jogador vai inserir no mapa mais casas, sendo estas colocadas no fim da linha.
        /// </summary>
        /// <param name="posicaoJogador">posicao na lista onde pretendemos adicionar as novas casas.</param>
        public void AdicionarCasasEste(Jogador posicaoJogador)
        {
            Grelha[posicaoJogador.PosicaoY].AddRange(GenerateNewLine());
        }

        /// <summary>
        /// Atraves da posicao do jogador vai inserir no mapa mais casas, sendo estas colocadas no inicio da linha, é posteriormente alterada a posicao do jogador.
        /// </summary>
        /// <param name="posicaoJogador">posicao na lista onde pretendemos adicionar as novas casas.</param>
        public void AdicionarCasasOeste(Jogador posicaoJogador)
        {
            Grelha[posicaoJogador.PosicaoY].InsertRange(posicaoJogador.PosicaoX, GenerateNewLine());
            posicaoJogador.PosicaoX = NumCasas;
        }

        /// <summary>
        /// Gera uma nova lista com o numero de elementos definido na constante NumCasas, e onde todos elementos sao iguais a 1.
        /// </summary>
        /// <returns> Nova lista de inteiros.</returns>
        private static List<int> GenerateNewLine() => Enumerable.Repeat(1, NumCasas).ToList();
    }
}
