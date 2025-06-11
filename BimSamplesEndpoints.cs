namespace eduardoos_api_static_data;

public static class BimSamplesEndpoints
{    
	static readonly string BimSampleApiUrl = "/static_data/bim_sample_api/";
	static readonly string BimSampleApiFileName = "bim_sample_api.json"; 
	public static void MapBimSampleApiUrl(this WebApplication app)
	{
		ReturnFileContentAsText(app, BimSampleApiUrl, BimSampleApiFileName);
	}
    
	private static void ReturnFileContentAsText(WebApplication app, string url, string fileName)
    {
        app.MapGet(url, async (IWebHostEnvironment env) =>
        {
            var filePath = Path.Combine(env.WebRootPath, fileName);

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