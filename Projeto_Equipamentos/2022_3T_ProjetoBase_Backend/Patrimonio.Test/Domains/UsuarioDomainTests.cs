using Patrimonio.Domains;
using Xunit;

namespace Patrimonio.Test.Domains
{
    public class UsuarioDomainTests
    {

        [Fact] // Descrição
        public void DeveRetornarUsuarioPreenchido()
        {

            // Pré-condição / Arrange
            Usuario usuario = new Usuario();
            usuario.Email = "paulo@email.com";
            usuario.Senha = "1236548997";


            // Procedimento / Act
            bool resultado = true;

            if(usuario.Senha == null || usuario.Email == null)
            {
                resultado = false;
            }


            // Resultado Esperado / Assert
            Assert.True(resultado);

        }

    }
}
