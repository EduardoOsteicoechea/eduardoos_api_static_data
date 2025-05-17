using eduardoos_api_static_data;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapBetweenTheRoleAndTheTragedy();

app.Run(); 