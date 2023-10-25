using DemoAPI;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/tacos", () => "Delicious");

app.MapGet("/temperatures/farenheit/{temp:float}/celcius", (float temp) =>
{
    var result = TemperatureConverter.ConvertFromF(temp);
    return result;
});

app.MapGet("/temperatures/celcius/{temp:float}/farenheit", (float temp) =>
{
    var result = TemperatureConverter.ConvertFromC(temp);
    return result;
});


app.Run();
public record ConversionResponse(float F, float C);


