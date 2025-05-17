using eduardoos_api_static_data;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseStaticFiles();

app.MapBetweenTheRoleAndTheTragedy();

app.Run(); 