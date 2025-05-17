namespace eduardoos_api_static_data;

public static class StaticDataEndpoints
{
	public static void MapBetweenTheRoleAndTheTragedy(this WebApplication app)
	{
		app.MapGet("/static_data", async (HttpContext context, IWebHostEnvironment env) =>
		{
			try
			{
				string fileContent = await File.ReadAllTextAsync(Path.Combine(env.WebRootPath, "BetweenTheRoleAndTheTragedy.json"));
				Results.Text(fileContent);
			}
			catch (System.Exception exception)
			{
				Results.Json(exception);
			}
		});
	}
}