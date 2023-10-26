namespace DemoApi.UnitTests;
internal class StandardFeeCalculatorTest
{
    [Theory]
    [InlineData("10/29/2023 3:21:38 PM -04:00")] // Saturday
    [InlineData("10/30/2023 3:21:38 PM -04:00")] // Sunday



    public void NoFeesOnWeekends(string when)
    {
        var calculator = new StandardFeeCalculator();
        var fee = calculator.GetCurrentFee();
        Assert.Equal(0, fee);


    }



    [Theory]
    [InlineData("10/25/2023 3:21:38 PM -04:00")] // Wednesday
    [InlineData("10/26/2023 3:21:38 PM -04:00")] // Thursday
    public void FeesOnWeekdays(string when)
    {
        var calculator = new StandardFeeCalculator();
        var fee = calculator.GetCurrentFee();
        Assert.Equal(.03M, fee);


    }

}
