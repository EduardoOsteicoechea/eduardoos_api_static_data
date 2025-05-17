namespace eduardoos_api_static_data;

public static class StaticDataEndpoints
{
	static readonly string QuestionsUrl = "/static_data/between_the_role_and_the_tragedy/";
	static readonly string ModelTunningUrl = "/static_data/between_the_role_and_the_tragedy/rag_data";
	static readonly string RagDataUrl = "/static_data/between_the_role_and_the_tragedy/model_tunning";
	static readonly string QuestionsFileName = "BetweenTheRoleAndTheTragedy.json";
	static readonly string ModelTuningFileName = "BetweenTheRoleAndTheTragedy_ModelTunning.txt";
	static readonly string RagDataFineName = "BetweenTheRoleAndTheTragedy_RagData.txt";
	public static void MapBetweenTheRoleAndTheTragedyQuestions(this WebApplication app)
	{
		app.MapGet(QuestionsUrl, async (IWebHostEnvironment env) =>
		{
			var filePath = Path.Combine(env.WebRootPath, QuestionsFileName);

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
		app.MapGet(ModelTunningUrl, async (IWebHostEnvironment env) =>
		{
			var filePath = Path.Combine(env.WebRootPath, ModelTuningFileName);

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
		app.MapGet(RagDataUrl, async (IWebHostEnvironment env) =>
		{
			var filePath = Path.Combine(env.WebRootPath, RagDataFineName);

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