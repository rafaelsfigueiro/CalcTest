using Playground;


namespace CalculadoraTeste
{
    public class CalculadoraTeste
    {

        static Calculadora _calc;
        
        public CalculadoraTeste()
        {
            _calc = new Calculadora();
        }

        
        [Fact]
        public  static void testaAdicaoValor() //metodologia a.a.a
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
            int div1 = 7;
            int div2 = 2;


        }

    }
}