using System;
using Wall_E;
using Xunit;

namespace WallEUnitTests
{
    public class MapaUnitTests
    {

        // Verifica se a primeira posicao, que começa a 0, passou para a segunda linha.
        [Fact]
        public void AdicionarCasasYNorte_Test()
        {
            Mapa mapa = CreateDefaultMapa();

            mapa.AdicionarCasasY(0);

            Assert.Equal(0, mapa.Grelha[1][0]);
        }

        // Verifica se a primeira posicao, que começa a 0, se manteve na mesma linha e se foi adicionada uma nova linha no final da grelha.
        [Fact]
        public void AdicionarCasasYSul_Test()
        {
            Mapa mapa = CreateDefaultMapa();

            mapa.AdicionarCasasY(mapa.Grelha.Count - 1);

            Assert.Equal(0, mapa.Grelha[0][0]);
            Assert.Equal(5, mapa.Grelha.Count);
        }


        // Verifica se foram adicionadas novas casas à primeira linha.
        [Fact]
        public void AdicionarCasasEste_Test()
        {
            Mapa mapa = CreateDefaultMapa();
            Jogador jogador = new()
            {
                PosicaoX = mapa.Grelha[0].Count - 1
            };

            mapa.AdicionarCasasEste(jogador);

            Assert.Equal(20, mapa.Grelha[0].Count);
        }

        //Verifica se foram adicionadas novas casas à primeira linha, e se a primeira posicao, que começa a 0, passou para a posicao 10.
        [Fact]
        public void AdicionarCasasOeste_Test()
        {
            Mapa mapa = CreateDefaultMapa();
            Jogador jogador = new();

            mapa.AdicionarCasasOeste(jogador);

            Assert.Equal(0, mapa.Grelha[0][10]);
            Assert.Equal(20, mapa.Grelha[0].Count);
        }

        private Mapa CreateDefaultMapa()
        {
            return new Mapa();
        }
    }
}
