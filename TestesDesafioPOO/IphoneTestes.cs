using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using DesafioPOO.Models;

namespace TestesDesafioPOO
{
    public class IphoneTestes
    {
        private Iphone _iPhone;
        private string Numero;
        private string Modelo;
        private string IMEI;
        private int Memoria;

        public IphoneTestes()
        {
            _iPhone = new Iphone("12345678", "Xr", "87654321", 128);
            Numero = "12345678";
            Modelo = "Xr";
            IMEI = "87654321";
            Memoria = 128;
        }

        [Fact]
        public void TestaMetodoApresentarAparelho()
        {
            string resultadoEsperado = $"iPhone {Modelo} com {Memoria}gb, número {Numero} e IMEI {IMEI}.";

            string resultado = _iPhone.ApresentarAparelho();

            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData("WhatsApp")]
        [InlineData("Instagram")]
        [InlineData("JustWatch")]
        public void TestaMetodoInstalarAplicativo(string nomeApp)
        {
            string resultadoEsperado = $"Instalando o aplicativo '{nomeApp}' no iPhone {Modelo}.";

            string resultado = _iPhone.InstalarAplicativo(nomeApp);

            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData("11111111")]
        [InlineData("22222222")]
        [InlineData("33333333")]
        public void TestaMetodoLigar(string numero)
        {
            string resultadoEsperado = $"Ligando para o número {numero}...";

            string resultado = _iPhone.Ligar(numero);

            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData("44444444")]
        [InlineData("55555555")]
        [InlineData("66666666")]
        public void TestaMetodoReceberLigacao(string numero)
        {
            string resultadoEsperado = $"Recebendo ligação do número {numero}...";

            string resultado = _iPhone.ReceberLigacao(numero);

            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void TestaMetodoObterIMEI()
        {
            string resultadoEsperado = IMEI;

            string resultado = _iPhone.ObterIMEI();

            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void TestaMetodoObterModelo()
        {
            string resultadoEsperado = Modelo;

            string resultado = _iPhone.ObterModelo();

            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void TestaMetodoObterMemoria()
        {
            int resultadoEsperado = Memoria;

            int resultado = _iPhone.ObterMemoria();

            Assert.Equal(resultadoEsperado, resultado);
        }
    }
}