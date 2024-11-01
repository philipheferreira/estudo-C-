
using SimplesAPI.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Adiciona os servi�os da API
builder.Services.AddControllers();

// Registra o ProdutoRepository como um servi�o que pode ser injetado
builder.Services.AddSingleton<ProdutoRepository>();

// Adiciona o Swagger para documenta��o da API (opcional, mas �til)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configura��es de desenvolvimento
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Configura o roteamento e mapeamento de controladores
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

// Inicia a aplica��o
app.Run();