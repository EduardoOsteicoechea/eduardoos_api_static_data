namespace eduardoos_api_static_data;

public static class StaticDataEndpoints
{
	public static void MapBetweenTheRoleAndTheTragedy(this WebApplication app)
	{
		app.MapGet("/static_data", async (IWebHostEnvironment env) =>
		{
			var filePath = Path.Combine(env.WebRootPath, "BetweenTheRoleAndTheTragedy.json");

			if (!File.Exists(filePath))
			{
				return Results.NotFound();
			}

			try
			{
				var jsonString = await File.ReadAllTextAsync(filePath);
				return Results.Text(jsonString, "application/json");
			}
			catch (Exception ex)
			{
				return Results.Problem($"Error reading file: {ex.Message}");
			}
		});
	}
}