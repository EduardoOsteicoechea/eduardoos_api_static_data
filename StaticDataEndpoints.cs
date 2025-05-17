namespace eduardoos_api_static_data;

public static class StaticDataEndpoints
{
	public static void MapBetweenTheRoleAndTheTragedy(this WebApplication app)
	{
		app.MapGet("/static_data", (HttpContext context) =>
		{
			try
			{
				Results.Json(JsonFileManager.RetrieveContent("BetweenTheRoleAndTheTragedy.json"));
			}
			catch (System.Exception exception)
			{
				Results.Json(exception);
			}
		});
	}
}