using Wall_E;
using Xunit;

namespace WallEUnitTests
{
    public class LeitorUnitTests
    {

        //Verifica se uma sequencia null passa na verificacao.
        [Fact]
        public void VerificarSequenciaNull_Test()
        {
            string sequencia = null;

            var result = Leitor.VerificarSequencia(sequencia);

            Assert.False(result);
        }

        //Verifica se uma sequencia vazia passa na verificacao.
        [Fact]
        public void VerificarSequenciaEmpty_Test()
        {
            string sequencia = "";

            var result = Leitor.VerificarSequencia(sequencia);

            Assert.False(result);
        }

        //Verifica se uma sequencia errada passa na verificacao.
        [Fact]
        public void VerificarSequenciaErrada_Test()
        {
            string sequencia = "ABC";

            var result = Leitor.VerificarSequencia(sequencia);

            Assert.False(result);
        }

        //Verifica se uma sequencia com caracteres validos e invalidos passa na verificacao.
        [Fact]
        public void VerificarSequenciaParteErrada_Test()
        {
            string sequencia = "NSCA";

            var result = Leitor.VerificarSequencia(sequencia);

            Assert.False(result);
        }

        //Verifica se uma sequencia valida passa na verificacao.
        [Fact]
        public void VerificarSequenciaCorreta_Test()
        {
            string sequencia = "NSOE";

            var result = Leitor.VerificarSequencia(sequencia);

            Assert.True(result);
        }
    }
}
