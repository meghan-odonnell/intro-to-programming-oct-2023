namespace DemoApi.Services;

public class TemperatureConverterService
{
	public ConversionWithFeeResponse ConvertFtoC(float temp)
	{
		var fee = .03M;
		var convertedTemp = TemperatureConverter.ConvertFromF(temp);

		return new ConversionWithFeeResponse(temp, convertedTemp, fee);
	}
}


public record ConversionWithFeeResponse(float F, float C, decimal Fee);