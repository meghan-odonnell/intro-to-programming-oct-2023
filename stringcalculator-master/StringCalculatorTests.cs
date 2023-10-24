
namespace StringCalculator;


public class StringCalculatorTests
{
    //  [Theory]
    //  [InlineData("")]
    //  [InlineData("1")]
    //  [InlineData("1,2")]


    [Fact]
    public void EmptyStringReturnsZero()
    {
        var calculator = new StringCalculator();

        var result = calculator.Add("");

        Assert.Equal(0, result);
    }


    [Fact]
    public void OneInputReturnsThatNumber()
    {
        var calculator = new StringCalculator();
        var result = calculator.Add("1");
        Assert.Equal(1, result);

    }
}
