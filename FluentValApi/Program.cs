using FluentValApi;
using FluentValApi.Models.MY;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<Func<string, IQuoteValidator>>(ServiceProvider => key =>
{
    switch (key)

    {
        case "MY":
            return ServiceProvider.GetService<QuoteMYValidator>();

        case "TH":
            return ServiceProvider.GetService<QuoteTHValidator>();

        default: return ServiceProvider.GetService<QuoteDefaultValidator>();
    }
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
