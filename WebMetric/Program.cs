using Prometheus;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Adiciona middleware para expor métricas no endpoint /metrics
app.UseRouting(); // Necessário para habilitar o roteamento

app.UseHttpMetrics();
app.MapMetrics(); // Substitui o uso de UseEndpoints

app.Run();
