using Patrimonio.Utils;
using System.Text.RegularExpressions;
using Xunit;

namespace Patrimonio.Test.Utils
{
    public class CriptografiaTests
    {

        [Fact]
        public void DeveRetornarHashEmBCrypt()
        {
            // Pré-condição / Arrange
            var senha = Criptografia.GerarHash("123456789");
            var regex = new Regex(@"^\$2[ayb]\$.{56}$");

            // Procedimento / Act
            var retorno = regex.IsMatch(senha);

            // Resultado esperado / Assert
            Assert.True(retorno);
        }

        [Fact]
        public void DeveRetornarComparacaoValida()
        {
            // Pré-condição
            var senha = "123456789";
            var hash = "$2a$11$8enVIz.W6XGk/LNBq.BzfexlJBWyCG3MNbWEzByH2n/1UnGMDZWse";

            // Procedimento
            var comparacao = Criptografia.Comparar(senha, hash);

            // Resultado esperado
            Assert.True(comparacao);
        }
    }
}
