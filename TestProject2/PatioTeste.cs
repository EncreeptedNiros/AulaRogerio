using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;
using System.IO;
using System.Xml.Serialization;

namespace TestProject1
{
    public class PatioTeste
    {
        [Fact]
        public void ValidaFaturamentoUmVeiculoPatio()
        {
            //Arrange
            Patio estacionamento = new Patio();

            var veiculo = new Veiculo();
            veiculo.Proprietario = "Andr� Silva";
            veiculo.Tipo = TipoVeiculo.Automovel;
            veiculo.Placa = "ABC-0101";
            veiculo.Modelo = "Fusca";
            veiculo.Acelerar(10);
            veiculo.Frear(5);
            estacionamento.RegistrarEntradaVeiculo(veiculo);
            estacionamento.RegistrarSaidaVeiculo(veiculo.Placa);

            //act
            double faturamento = estacionamento.TotalFaturado();

            //Assert
            Assert.Equal(2, faturamento);


        }
        [Theory]
        [InlineData("Andr� Silva", "ASD-1498", "Preto", "Gol")]
        [InlineData("Jos� Silva", "POL-9242", "Cinza", "Fusca")]
        [InlineData("Andr� Silva", "GDR-6524", "Azul", "Opala")]
        [InlineData("Andr� Silva", "QKU-1498", "Amarelo", "HB20")]
        [InlineData("Andr� Silva", "QWZ-5154", "Verde", "Santana")]
        [InlineData("Andr� Silva", "PLU-8472", "Branco", "Logan")]
        public void ValidaFaturamentoVariosVeiculosPatio(string proprietario,
                                                         string placa,
                                                         string cor,
                                                         string modelo)

            
        {
            //Arrange
            Patio estacionamento = new Patio();

            var veiculo = new Veiculo();
            veiculo.Proprietario = proprietario;
            veiculo.Tipo = TipoVeiculo.Automovel;
            veiculo.Placa = placa;
            veiculo.Modelo = modelo;
            veiculo.Acelerar(10);
            veiculo.Frear(5);
            estacionamento.RegistrarEntradaVeiculo(veiculo);
            estacionamento.RegistrarSaidaVeiculo(veiculo.Placa);

            //act
            double faturamento = estacionamento.TotalFaturado();

            //Assert
            Assert.Equal(2, faturamento);


        }
    }
}