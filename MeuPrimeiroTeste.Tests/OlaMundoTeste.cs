using Xunit;
using MeuPrimeiroTeste.App;

namespace MeuPrimeiroTeste.Tests;

public class OlaMundoTeste
{
    [Fact]
    public void ObterMensagem_DeveRetornarHelloWorld()
    {
        // Arrange
        var olaMundo = new OlaMundo();

        // Act
        var resultado = olaMundo.ObterMensagem();

        // Assert
        Assert.Equal("Hello, World!", resultado);
    }
}