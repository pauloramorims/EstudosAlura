using Alura.Estacionamento.Modelos;
using Xunit;

namespace Alura.Estacionamento.Testes
{
    public class VeiculoTestes
    {
        private Veiculo veiculo;

        public VeiculoTestes()
        {
            veiculo = new Veiculo();
        }
        
        [Fact(DisplayName ="Teste Veiculo Acelerar")]
        [Trait("Funcionalidade","Acelerar")] //Agrupa os teste por categoria
        public void TestaVeiculoAcelerar()
        {
            //Arrange
           
            //Act
            veiculo.Acelerar(10);
            //Assert
            Assert.Equal(100, veiculo.VelocidadeAtual);
        }

        [Fact(DisplayName = "Teste Veiculo Frear")]
        [Trait("Funcionalidade", "Frear")] //Agrupa os teste por categoria

        public void TestaVeiculoFrear()
        {
            //Arrange
            
            //Act
            veiculo.Frear(10);
            //Assert
            Assert.Equal(-150, veiculo.VelocidadeAtual);
        }

        [Fact(Skip ="Teste não implementado, ignorar!")]
        public void ValidarqualquerCoisa()
        {

        }
    }
}