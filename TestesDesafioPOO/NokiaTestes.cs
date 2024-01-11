using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using DesafioPOO.Models;

namespace TestesDesafioPOO
{
    public class NokiaTestes
    {
        private Nokia _nokia;
        private string Numero;
        private string Modelo;
        private string IMEI;
        private int Memoria;

        public NokiaTestes()
        {
            _nokia = new Nokia("12345678", "Lumia", "87654321", 128);
            Numero = "12345678";
            Modelo = "Lumia";
            IMEI = "87654321";
            Memoria = 128;
        }

        [Fact]
        public void TestaMetodoApresentarAparelho()
        {
            string resultadoEsperado = $"Nokia {Modelo} com {Memoria}gb, número {Numero} e IMEI {IMEI}.";

            string resultado = _nokia.ApresentarAparelho();

            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData("WhatsApp")]
        [InlineData("Instagram")]
        [InlineData("JustWatch")]
        public void TestaMetodoInstalarAplicativo(string nomeApp)
        {
            string resultadoEsperado = $"Instalando o aplicativo '{nomeApp}' no Nokia {Modelo}.";

            string resultado = _nokia.InstalarAplicativo(nomeApp);

            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData("11111111")]
        [InlineData("22222222")]
        [InlineData("33333333")]
        public void TestaMetodoLigar(string numero)
        {
            string resultadoEsperado = $"Ligando para o número {numero}...";

            string resultado = _nokia.Ligar(numero);

            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData("44444444")]
        [InlineData("55555555")]
        [InlineData("66666666")]
        public void TestaMetodoReceberLigacao(string numero)
        {
            string resultadoEsperado = $"Recebendo ligação do número {numero}...";

            string resultado = _nokia.ReceberLigacao(numero);

            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void TestaMetodoObterIMEI()
        {
            string resultadoEsperado = IMEI;

            string resultado = _nokia.ObterIMEI();

            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void TestaMetodoObterModelo()
        {
            string resultadoEsperado = Modelo;

            string resultado = _nokia.ObterModelo();

            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void TestaMetodoObterMemoria()
        {
            int resultadoEsperado = Memoria;

            int resultado = _nokia.ObterMemoria();

            Assert.Equal(resultadoEsperado, resultado);
        }
    }
}