using eduardoos_api_static_data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
	options.AddPolicy("AllowLocalhostReact", policy =>
	{
		policy.WithOrigins("http://localhost:5173")
		.AllowAnyHeader()
		.AllowAnyMethod();
	});
});

var app = builder.Build();

app.UseStaticFiles();

app.MapBetweenTheRoleAndTheTragedyQuestions();
app.MapBetweenTheRoleAndTheTragedyModelTunning();
app.MapBetweenTheRoleAndTheTragedyModelRagData();
app.MapBetweenTheRoleAndTheTragedyArticleRichData();

app.Run(); 