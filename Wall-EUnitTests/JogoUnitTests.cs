using System;
using System.IO;
using Xunit;
using Wall_E;

namespace WallEUnitTests
{
    public class JogoUnitTests
    {
        private Jogo Jogo { get; set; }

        public JogoUnitTests()
        {
            Jogo = new();
        }

        [Fact]
        public void TestarSequenciaNorte_Jogar_Test()
        {
            var sequencia = new StringReader("NNNNN");
            Console.SetIn(sequencia);

            var result = Jogo.Jogar();

            Assert.Equal(6,result);
        }

        [Fact]
        public void TestarSequenciaNorteSul_Jogar_Test()
        {
            var sequencia = new StringReader("NSNSNSNSNSNSNS");
            Console.SetIn(sequencia);

            var result = Jogo.Jogar();

            Assert.Equal(2, result);
        }

        [Fact]
        public void TestarSequenciaQuadrado_Jogar_Test()
        {
            var sequencia = new StringReader("NESO");
            Console.SetIn(sequencia);

            var result = Jogo.Jogar();

            Assert.Equal(4, result);
        }


        [Fact]
        public void TestarSequenciaEsteOeste_Jogar_Test()
        {
            var sequencia = new StringReader("EEEEEEOOOOOOEEEEEE");
            Console.SetIn(sequencia);

            var result = Jogo.Jogar();

            Assert.Equal(7, result);
        }
    }
}
