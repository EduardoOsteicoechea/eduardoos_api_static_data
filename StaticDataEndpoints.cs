namespace eduardoos_api_static_data;

public static class StaticDataEndpoints
{
	public static void MapBetweenTheRoleAndTheTragedyQuestions(this WebApplication app)
	{
		app.MapGet("/static_data/between_the_role_and_the_tragedy/", async (IWebHostEnvironment env) =>
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
	public static void MapBetweenTheRoleAndTheTragedyModelTunning(this WebApplication app)
	{
		app.MapGet("/static_data/between_the_role_and_the_tragedy/model_tunning", async (IWebHostEnvironment env) =>
		{
			var filePath = Path.Combine(env.WebRootPath, "BetweenTheRoleAndTheTragedy_ModelTunning.txt");

			if (!File.Exists(filePath))
			{
				return Results.NotFound();
			}

			try
			{
				var jsonString = await File.ReadAllTextAsync(filePath);
				return Results.Text(jsonString, "application/text");
			}
			catch (Exception ex)
			{
				return Results.Problem($"Error reading file: {ex.Message}");
			}
		});
	}
	public static void MapBetweenTheRoleAndTheTragedyModelRagData(this WebApplication app)
	{
		app.MapGet("/static_data/between_the_role_and_the_tragedy/rag_data", async (IWebHostEnvironment env) =>
		{
			var filePath = Path.Combine(env.WebRootPath, "BetweenTheRoleAndTheTragedy_RagData.txt");

			if (!File.Exists(filePath))
			{
				return Results.NotFound();
			}

			try
			{
				var jsonString = await File.ReadAllTextAsync(filePath);
				return Results.Text(jsonString, "application/text");
			}
			catch (Exception ex)
			{
				return Results.Problem($"Error reading file: {ex.Message}");
			}
		});
	}
}