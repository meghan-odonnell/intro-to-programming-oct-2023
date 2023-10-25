namespace DemoApi.ContractTests;

public class UnitTest1
{
    [Fact]
    public async Task Test1()
    {
        var client = new HttpClient();
        client.BaseAddress = new Uri("http://localhost:1337");

        var response = await client.GetAsync("temperatures/farenheit/100/celcius");

        Assert.Equal(HttpStatusCode.OK, response.StatusCode)
    }
}