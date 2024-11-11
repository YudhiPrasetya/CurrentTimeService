var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//Get UTC
app.MapGet("time/utc", () => Results.Ok(DateTime.UtcNow));

//Get Now
app.MapGet("time/now", () => Results.Ok(DateTime.Now));

//Get Month
app.MapGet("date/getMonth", () => Results.Ok(DateTime.Now.Month));

//Get Year
app.MapGet("date/getYear", () => Results.Ok(DateTime.Now.Year));

//Run async
await app.RunAsync();

