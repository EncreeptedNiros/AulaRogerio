using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2
{
    public class VeiculoTeste
    {
        [Fact(DisplayName = "Teste nº 1")]
        [Trait("Funcionalidade", "Acelerar")]
        public void TestaVeiculoAcelerar()
        {
            //Arrange
            var veiculo = new Veiculo();

            //Act
            veiculo.Acelerar(10);

            //Assert
            Assert.Equal(100, veiculo.VelocidadeAtual);



        }
        [Fact( Skip = "Teste ainda não implementado")]
        public void TestaVeiculoFrear()
        {
            //Arrange
            var veiculo = new Veiculo();

            //Act
            veiculo.Frear(10);

            //Assert
            Assert.Equal(-150, veiculo.VelocidadeAtual);



        }
        
        
        [Fact]
        public void AlteraDadosVeiculoComBaseNaPlaca()
        {
            //Arrange
            Patio estacionamento = new Patio();
            var veiculo = new Veiculo();
            veiculo.Proprietario = "José Silva";
            veiculo.Tipo = TipoVeiculo.Automovel;
            veiculo.Placa = "ZXC-8524";
            veiculo.Cor = "Verde";
            veiculo.Modelo = "Opala";
            estacionamento.RegistrarEntradaVeiculo(veiculo);

            var veiculoAlterado = new Veiculo();
            veiculoAlterado.Proprietario = "José Silva";
            veiculoAlterado.Tipo = TipoVeiculo.Automovel;
            veiculoAlterado.Placa = "ZXC-8524";
            veiculoAlterado.Cor = "Preto"; //Alterado
            veiculoAlterado.Modelo = "Opala";


            //Act
            var alterado = estacionamento.AlteraDadosVeiculo(veiculoAlterado);


            //Assert
            Assert.Equal(alterado.Cor, veiculoAlterado.Cor);



        }
    


    [Fact]
    public void GerarFichadeInformaçãodoProprioVeiculo()
    {
        //Arrange
        var veiculo = new Veiculo();
        veiculo.Proprietario = "André Silva";
        veiculo.Tipo = TipoVeiculo.Automovel;
        veiculo.Cor = "Preto";
        veiculo.Modelo = "Opala";
        veiculo.Placa = "ZXC-8888";



        //Act
        string dadosveiculo = veiculo.ToString();


        //Assert
        Assert.Contains("Ficha do Veículo", dadosveiculo);



    }
        [Fact]
        public  void TestaNomeProprietarioComDoisCaracteres()
        {
            //Arrange
            string nomeProprietario = "Ab";
            //Assert
            Assert.Throws<FormatException>(
                //Act
                () => new Veiculo(nomeProprietario) );
        }

    }
}

