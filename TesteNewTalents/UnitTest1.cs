using NewTalents;

namespace TesteNewTalents
{
    public class UnitTest1
    {
        public UnitTest1()
        {
            _calc = new Calculadora("24/05/2024");
        }

        private Calculadora _calc;

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TesteSomar(int val1, int val2, int resultado)
        {
            int resultadoCalculadora = _calc.Somar(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TesteMultiplicar(int val1, int val2, int resultado)
        {
            int resultadoCalculadora = _calc.Multiplicar(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(5, 5, 1)]
        public void TesteDividir(int val1, int val2, int resultado)
        {
            int resultadoCalculadora = _calc.Dividir(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 4)]
        [InlineData(5, 5, 0)]
        public void TesteSubtrair(int val1, int val2, int resultado)
        {
            int resultadoCalculadora = _calc.Subtrair(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            Assert.Throws<DivideByZeroException>(() => _calc.Dividir(3, 0));
        }

        [Fact]
        public void TestarHistoricio()
        {
            _calc.Somar(1, 2);
            _calc.Somar(2, 8);
            _calc.Somar(3, 7);
            _calc.Somar(4, 1);

            List<string> lista = _calc.Historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}