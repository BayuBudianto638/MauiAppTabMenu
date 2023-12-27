namespace MauiAppTabMenu.Services;

public class SampleDataService
{
	public async Task<IEnumerable<SampleItem>> GetItems()
	{
		await Task.Delay(1000); // Artifical delay to give the impression of work

		var random = new Random().Next();

		var result = new List<SampleItem>();

		for (var i = 0; i < 40; i++)
		{
			result.Add(new SampleItem
			{
				Title = $"Item {random}-{i}",
				Description = "MAUI App Test"
			});
		}

		return result;
	}
}
