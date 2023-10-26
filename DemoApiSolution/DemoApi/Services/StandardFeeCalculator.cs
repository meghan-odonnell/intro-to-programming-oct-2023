namespace DemoApi.Services;

public class StandardFeeCalculator : ICalculateFees
{
    public decimal GetCurrentFee()
    {
        return -42;
    }
}
