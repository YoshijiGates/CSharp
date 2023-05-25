using NX.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// DIするサービスを自動登録する
AppDomain.CurrentDomain.GetAssemblies();
foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
{
    builder.Services.RegisterComponents(asm.FullName!);
}

builder.Services.AddControllers();
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
