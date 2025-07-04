using Playground;


namespace CalculadoraTeste
{
    public class CalculadoraTeste
    {

        private Calculadora _calc;
        
        public CalculadoraTeste()
        {
            _calc = new Calculadora();
        }

        
        [Fact]
        public void testaAdicaoValorDeveRetornar15() //metodologia a.a.a
        {
            // arrange 
            int num1 = 10;
            int num2= 5;


            // act 
            int resultado = _calc.Adicao(num1, num2);

            // assert
            Assert.Equal(15, resultado);

        }

        [Fact]
        public void testaComValor7e10Resultado15()
        {
            int num1 = 7;
            int num2 = 10;

            int resultado = _calc.Adicao(num1, num2);

            Assert.Equal(17, resultado);
        }


        [Fact]
        public void Dividir()
        {
            //int div1 = 7;
            //int div2 = 2;


        }

        [Theory]
        [InlineData(10,5,15)]
        [InlineData(7, 10, 17)]
            

        public void testaadicaoDeRetornarExpectativa(int a, int b, int Expectativa)
        {
            

            int resultado = _calc.Adicao(a, b);

            Assert.Equal(Expectativa, resultado);
        }





    }
}