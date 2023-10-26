
namespace StringCalculator;
public class StringCalculatorInterationTests
{

    private readonly StringCalculator _calculator;
    private readonly ILogger _logger;
    public StringCalculatorInterationTests()
    {
        _logger = Substitute.For<ILogger>();
        _calculator = new StringCalculator(_logger);
    }

    [Theory]
    [InlineData("1")]
    public void WritesToLogger(string numbers)
    {
        _calculator.Add(numbers);

        // Assert???


        _logger.Received().Write(numbers);
    }
}