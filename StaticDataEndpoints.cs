namespace eduardoos_api_static_data;

public static class StaticDataEndpoints
{
	static readonly string AboutEduardoModelTunningUrl = "/static_data/about_eduardo/model_tunning";
	static readonly string AboutEduardoRAGUrl = "/static_data/about_eduardo/profile_rag_data";
    static readonly string AboutEduardoOutputStructureUrl = "/static_data/about_eduardo/output_structure";

	static readonly string AboutEduardoModelTunningFileName = "about_eduardo_model_tunning.json";
	// static readonly string AboutEduardoModelTunningFileName = "about_eduardo_model_tunning.txt";
	static readonly string AboutEduardoRAGFileName = "about_eduardo_profile_rag_data.txt";
    static readonly string AboutEduardoOutputStructureFileName = "about_eduardo_output_structure.json";
    


    
	static readonly string QuestionsUrl = "/static_data/between_the_role_and_the_tragedy/";
	static readonly string ModelTunningUrl = "/static_data/between_the_role_and_the_tragedy/rag_data";
	static readonly string RagDataUrl = "/static_data/between_the_role_and_the_tragedy/model_tuning";
	static readonly string ArticleRichDataDataUrl = "/static_data/between_the_role_and_the_tragedy/article_rich_data";
	static readonly string QuestionsFileName = "BetweenTheRoleAndTheTragedy.json";
	static readonly string ModelTuningFileName = "BetweenTheRoleAndTheTragedy_ModelTuning.txt";
	static readonly string RagDataFileName = "BetweenTheRoleAndTheTragedy_RagData.txt";
	static readonly string ArticleRichDataFileName = "BetweenTheRoleAndTheTragedy_ArticleRichData.json";
	public static void MapBetweenTheRoleAndTheTragedyQuestions(this WebApplication app)
	{
		ReturnFileContentAsText(app, QuestionsUrl, QuestionsFileName);
	}
	public static void MapBetweenTheRoleAndTheTragedyModelTunning(this WebApplication app)
	{
		ReturnFileContentAsText(app, ModelTunningUrl, ModelTuningFileName);
	}
	public static void MapBetweenTheRoleAndTheTragedyModelRagData(this WebApplication app)
	{
		ReturnFileContentAsText(app, RagDataUrl, RagDataFileName);
	}
	public static void MapBetweenTheRoleAndTheTragedyArticleRichData(this WebApplication app)
	{
		ReturnFileContentAsText(app, ArticleRichDataDataUrl, ArticleRichDataFileName);
	}
    

	public static void MapAboutEduardoModelTunningUrl(this WebApplication app)
    {
        ReturnFileContentAsText(app, AboutEduardoModelTunningUrl, AboutEduardoModelTunningFileName);
    }
    
	public static void MapAboutEduardoRAGUrl(this WebApplication app)
    {
        ReturnFileContentAsText(app, AboutEduardoRAGUrl, AboutEduardoRAGFileName);
    }
    
	public static void MapAAboutEduardoOutputStructureUrl(this WebApplication app)
    {
        ReturnFileContentAsText(app, AboutEduardoOutputStructureUrl, AboutEduardoOutputStructureFileName);
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