using Microsoft.AspNetCore.Mvc;
using Moq;
using Patrimonio.Controllers;
using Patrimonio.Domains;
using Patrimonio.Interfaces;
using Patrimonio.ViewModels;
using Xunit;

namespace Patrimonio.Test.Controllers
{
    public class LoginControllerTest
    {
        [Fact]
        public void DeveRetornarUmUsuarioInvalido()
        {
            // Pré-condição
            var fakerepository = new Mock<IUsuarioRepository>();
            fakerepository
                .Setup(x => x.Login(It.IsAny<string>(), It.IsAny<string>()))
                .Returns((Usuario)null);

            LoginViewModel loginViewModel = new LoginViewModel();
            loginViewModel.Email = "paulo@email.com";
            loginViewModel.Senha = "123456789";

            var controller = new LoginController(fakerepository.Object);

            // Procedimento
            var resultado = controller.Login(loginViewModel);

            // Resultado esperado
            Assert.IsType<UnauthorizedObjectResult>(resultado);
        }

        [Fact]
        public void DeveRetornarUmUsuarioValido()
        {
            // Pré-condição
            var usuarioFake = new Usuario();
            usuarioFake.Email = "tsuka@email.com";
            usuarioFake.Senha = "$2a$11$AUM5AKe7WcnoTp.S7J1FTerSqZCzchPEI4YxjB5RDAvZqeepOZZ8i";
            
            var fakerepository = new Mock<IUsuarioRepository>();
            fakerepository
                .Setup(x => x.Login(It.IsAny<string>(), It.IsAny<string>()))
                .Returns((Usuario)null);

            LoginViewModel loginViewModel = new LoginViewModel();
            loginViewModel.Email = "paulo@email.com";
            loginViewModel.Senha = "123456789";

            var controller = new LoginController(fakerepository.Object);

            // Procedimento
            var resultado = controller.Login(loginViewModel);

            // Resultado esperado
            Assert.IsType<UnauthorizedObjectResult>(resultado);
        }

    }
}
