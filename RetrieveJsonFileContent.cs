namespace eduardoos_api_static_data;

public static class JsonFileManager
{
	public static string RetrieveContent(string fileName)
	{
		try
		{
			using FileStream fileStream = new (fileName, FileMode.Open, FileAccess.Read);
			using StreamReader reader = new (fileStream);
			return reader.ReadToEnd();
		}
		catch (FileNotFoundException ex)
		{
			Console.WriteLine($"Error: File not found - {fileName}\n\n{ex.StackTrace}");
			throw;
		}
		catch (Exception ex)
		{
			Console.WriteLine($"An error occurred while reading the file '{fileName}': {ex.Message}\n\n{ex.StackTrace}");
			throw;
		}
	}
}