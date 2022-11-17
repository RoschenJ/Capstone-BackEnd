var builder = WebApplication.CreateBuilder(args);

// Add policy
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "DefaultPolicy",
        policy =>
        {
            policy.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
        });
});
// Add services to the container.

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



builder.Services.AddControllers();


app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseCors("DefaultPolicy");

/*app.UseAuthorization();*/

app.MapControllers();

app.Run();
