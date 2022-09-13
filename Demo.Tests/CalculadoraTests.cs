﻿using Xunit;

namespace Demo.Tests
{
    public class CalculadoraTests
    {
        [Fact]
        public void Calculadora_Somar_RetornarValorSoma()
        {
            //Arrange
            var calculadora = new Calculadora();

            //Act
            var resultado = calculadora.Somar(2, 2);

            //Assert
            Assert.Equal(4, resultado);
        }

        [Fact]
        public void Calculadora_Dividir_RetornaValorDivisao()
        {
            //Arrange 
            var calculadora = new Calculadora();

            //Act
            var resultado = calculadora.Dividir(4, 2);

            //Assert
            Assert.Equal(2, resultado);
        }

        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]
        [InlineData(3, 3, 6)]
        [InlineData(4, 4, 8)]
        [InlineData(6, 6, 12)]
        public void Calculadora_Somar_RetornarValoresSomaCorretos(int v1, int v2, double total)
        {
            //Arrange 
            var calculadora = new Calculadora();

            //Act
            var resultado = calculadora.Somar(v1, v2);

            //Assert
            Assert.Equal(total, resultado);
        }
    }
}
