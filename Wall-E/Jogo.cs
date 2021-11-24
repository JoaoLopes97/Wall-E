namespace Wall_E
{
    public class Jogo
    {
        private Jogador PosicaoJogador { get; set; }
        private Mapa Mapa { get; set; }

        public Jogo()
        {
            PosicaoJogador = new Jogador();
            Mapa = new Mapa();
        }


        /// <summary>
        /// Metodo que consoante a sequencia que o jogador introduziu, vai realizar as jogadas respectivas, até que não hajam mais jogadas por fazer.
        /// </summary>
        /// <returns>Numero de bolas obtido durante o jogo. </returns>
        public int Jogar()
        {
            var sequencia = Leitor.LerSequencia();

            do
            {
                var direcao = sequencia[0];

                Jogada((Direcao)direcao);

                sequencia = sequencia[1..];
            } while (sequencia.Length != 0);

            return PosicaoJogador.NumBolas;
        }

        /// <summary>
        /// Recebe uma direcao, consoante a mesma e a posicao atual do jogador, são adicionadas novas linhas ou novas casas em linhas já existentes.
        /// Posteriormente é alterada a posicao do utilizador e retirada, caso exista, a bola de lixo nessa mesma posicao.
        /// </summary>
        /// <param name="direcao">direcao escolhida para avançar.</param>
        private void Jogada(Direcao direcao)
        {
            switch (direcao)
            {
                case Direcao.NORTE:
                    if (PosicaoJogador.PosicaoY == 0) Mapa.AdicionarCasasY(PosicaoJogador.PosicaoY);
                    else PosicaoJogador.PosicaoY--;
                    break;
                case Direcao.SUL:
                    if (PosicaoJogador.PosicaoY == Mapa.Grelha.Count - 1) Mapa.AdicionarCasasY(PosicaoJogador.PosicaoY);
                    PosicaoJogador.PosicaoY++;
                    break;
                case Direcao.ESTE:
                    if (PosicaoJogador.PosicaoX == Mapa.Grelha[PosicaoJogador.PosicaoY].Count - 1) Mapa.AdicionarCasasEste(PosicaoJogador);
                    PosicaoJogador.PosicaoX++;
                    break;
                case Direcao.OESTE:
                    if (PosicaoJogador.PosicaoX == 0) Mapa.AdicionarCasasOeste(PosicaoJogador);
                    PosicaoJogador.PosicaoX--;
                    break;
                default:
                    break;
            }
            if (Mapa.Grelha[PosicaoJogador.PosicaoY][PosicaoJogador.PosicaoX] != 0)
            {
                Mapa.Grelha[PosicaoJogador.PosicaoY][PosicaoJogador.PosicaoX] = 0;
                PosicaoJogador.NumBolas++;
            }
        }
    }
}
