using Microsoft.VisualStudio.TestPlatform.Utilities;
using ProjetoCalculadora;
using ProjetoCalculadora.Exceptions;
using static ProjetoCalculadora.Calculadora ;

namespace TestesUnitarios;

public class CalculadoraTeste
{

    private Calculadora calculadora;

    public CalculadoraTeste()
    {
        calculadora = new Calculadora();
    }


    [Fact] // annotations
    public void GivenSomaWhenSomandoDoisNumerosThenReturnTheSum()
    {
        //given/arrange

        double firstValue = 2.0;
        double secondValue = 3.0;
        double expectedValue = 5.0;

        //when - act - agir

        double resultValue = Somar(firstValue, secondValue);

        //then - assert - teste
        Assert.Equal(expectedValue, resultValue);

     }



    [Fact] // annotations
    public void GivenProdutoWhenMultiplicandoDoisNumerosThenReturnTheProduct()
    {
        //given/arrange

        double firstValue = 10.0;
        double secondValue = 10.0;
        double expectedValue = 100.0;

        //when - act - agir

        double resultValue = Multiplicar(firstValue, secondValue);

        //then - assert - teste
        Assert.Equal(expectedValue, resultValue);

    }

    [Fact] // annotations
    public void GivenDiferencaWhenSubtraindoDoisNumerosThenReturnTheSubtracao()
    {
        //given/arrange

        double firstValue = 10.0;
        double secondValue = 3.0;
        double expectedValue = 7.0;

        //when - act - agir

        double resultValue = Subtrair(firstValue, secondValue);

        //then - assert - teste
        Assert.Equal(expectedValue, resultValue);

   }

    [Fact] // annotations
    public void GivenDivisaoWhenDividindoDoisNumerosThenReturnTheDivision()
    {
        //given/arrange

        double firstValue = 20.0;
        double secondValue = 5.0;
        double expectedValue = 4.0;

        //when - act - agir

        double resultValue = Dividir(firstValue, secondValue);

        //then - assert - teste
        Assert.Equal(expectedValue, resultValue);

    }

    [Fact (DisplayName="Divisão por Zero")] // annotations
    public void GivenDivisaoWhenDividindoPorZeroThenReturnThrowsDivisionByZeroException()
    {
        //given/arrange

        double firstValue = 20.0;
        double secondValue = 0.0;
        double expectedValue = 4.0;

        //when - act - agir

        double resultValue = Dividir(firstValue, secondValue);

        //then - assert - teste
        //Assert.Equal(expectedValue, resultValue);
        Assert.Throws<DivisionByZeroException>(() => Dividir(firstValue, secondValue));

    }




    //GWT = Given When Then
    //dado alguma coisa, quando alguma coisa, então ...
    //AAA = Arrange Act Assert
    //Dado...Faça...Garanta...

    //SEVT
    //Setup Execute Verify Teardown
    //Configura...Executa...Verifica...Limpa

    // Piramide de teste
    // teste unitários
    // teste automatizados

    // Interface/Frontend > Services > Unidades/Funções
    // mais alto => maior custo
    // mais baixo => mais veloz
    // mais baixo maior a quantidade

    // TDD => Test Development Drive
    // RGR => Red: Falha => Green: Sucesso => Refactor


}