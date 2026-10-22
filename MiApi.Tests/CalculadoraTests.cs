namespace MiApi.Tests;

public class CalculadoraTests
{
    private readonly Calculadora _calculadora = new();

    [Fact]
    public void Sumar_DosNumeros_DevuelveLaSuma()
    {
        Assert.Equal(5, _calculadora.Sumar(2, 5));
    }

    [Fact]
    public void Restar_DosNumeros_DevuelveLaResta()
    {
        Assert.Equal(1, _calculadora.Restar(3, 2));
    }

    [Fact]
    public void Multiplicar_DosNumeros_DevuelveElProducto()
    {
        Assert.Equal(12, _calculadora.Multiplicar(3, 4));
    }

    [Fact]
    public void Dividir_DosNumeros_DevuelveElCociente()
    {
        Assert.Equal(2.5, _calculadora.Dividir(5, 2));
    }

    [Fact]
    public void Dividir_PorCero_LanzaExcepcion()
    {
        Assert.Throws<DivideByZeroException>(() => _calculadora.Dividir(5, 0));
    }
}
