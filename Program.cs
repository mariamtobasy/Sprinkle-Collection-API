using sprinklrGcs.Options;

var builder = WebApplication.CreateBuilder(args);

// --- Service registrations (MUST be before builder.Build()) ---
builder.Services.Configure<ExternalApiOptions>(
    builder.Configuration.GetSection("ExternalApi"));

// Register HttpClient + GeocoderClient
builder.Services.AddHttpClient<IGeocoderClient, GeocoderClient>();

// Add MVC + Swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// --- Build the app (after this, no more builder.Services) ---
var app = builder.Build();

// --- Middleware pipeline ---
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
