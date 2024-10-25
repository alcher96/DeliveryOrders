using FilterToDelivery.ActionFilters;
using FilterToDelivery.Extentions;

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.

builder.Services.ConfigureCors();
builder.Services.ConfigureSqlContext(builder.Configuration);
builder.Services.AddSwaggerGen();
builder.Services.ConfigureRepositoryManager();
builder.Services.AddScoped<ValidateOrderExistsAttribute>();


builder.Services.AddControllers();
builder.Services.AddCors();

builder.Services.AddAutoMapper(typeof(Program));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}




if (app.Environment.IsProduction())
    app.UseHsts();



app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();

app.MapControllers();

app.Run();
