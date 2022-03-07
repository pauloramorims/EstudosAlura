using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Alura.Estacionamento.Testes;

public class PatioTeste
{
    //setup 
    private readonly Patio estacionamento;
    public PatioTeste()
    {
        estacionamento = new Patio();
    }

    [Fact]
    public void ValidaFaturamento()
    {
        //Arrange
        Veiculo veiculo = new()
        {
            Proprietario = "Andre Silva",
            Tipo = TipoVeiculo.Automovel,
            Cor = "Verde",
            Modelo = "Fusca",
            Placa = "asd-1234"
        };

        estacionamento.RegistrarEntradaVeiculo(veiculo);
        estacionamento.RegistrarSaidaVeiculo(veiculo.Placa);

        //Act
        double faturamento = estacionamento.TotalFaturado();

        //Assert
        Assert.Equal(2, faturamento);
    }

    [Theory(DisplayName = "Faturamento Total")]
    [InlineData("André Silva", "ASD-1498", "preto", "Gol")]
    [InlineData("Marcos Silva", "GTR-1498", "Vermelho", "Gol")]
    [InlineData("Maria Lima", "FRE-1498", "Azul", "Palio")]
    public void ValidaFaturamentoComVariosVeiculos(string dono,
                                                   string placa,
                                                   string cor,
                                                   string modelo)
    {
        Veiculo veiculo = new()
        {
            Proprietario = dono,
            Tipo = TipoVeiculo.Automovel,
            Cor = cor,
            Modelo = modelo,
            Placa = placa
        };

        estacionamento.RegistrarEntradaVeiculo(veiculo);
        estacionamento.RegistrarSaidaVeiculo(veiculo.Placa);

        //Act
        double faturamento = estacionamento.TotalFaturado();

        //Assert
        Assert.Equal(2, faturamento);
    }

    [Theory(DisplayName = "Localiza Veiculo")]
    [InlineData("André Silva", "ASD-1498", "preto", "Gol")]
    [InlineData("Marcos Silva", "GTR-1498", "Vermelho", "Gol")]
    public void LocalizaVeiculoNoPatio(string dono,
                                       string placa,
                                       string cor,
                                       string modelo)
    {
        //Arrange

        Veiculo veiculo = new()
        {
            Proprietario = dono,
            Tipo = TipoVeiculo.Automovel,
            Cor = cor,
            Modelo = modelo,
            Placa = placa
        };
        estacionamento.RegistrarEntradaVeiculo(veiculo);

        //Act
        var consultado = estacionamento.PesquisaVeiculo(placa);

        //Assert
        Assert.Equal(placa, consultado.Placa);
    }

}
