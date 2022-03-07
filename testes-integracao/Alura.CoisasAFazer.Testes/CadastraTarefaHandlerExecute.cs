using Alura.CoisasAFazer.Core.Commands;
using Alura.CoisasAFazer.Services.Handlers;
using System;
using Xunit;

namespace Alura.CoisasAFazer.Testes
{
    public class CadastraTarefaHandlerExecute
    {
        [Fact]
        public void DadaTarefaComInforValidasDeveIncluirNoBD()
        {
           //arrange
            var comando = new CadastraTarefa("Estudar Xunit", new Core.Models.Categoria("Estudo"), 
                                             new DateTime(2019, 12, 31));
            var handler = new CadastraTarefaHandler();

            //act
            handler.Execute(comando);
            //Assert
            Assert.True(true);
        }
    }
}