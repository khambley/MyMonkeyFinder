
namespace MonkeyFinder.Services;

public class MonkeyService
{
    List<Monkey> monkeyList = new();
    HttpClient httpClient;

    public MonkeyService()
    {
        this.httpClient = new HttpClient();
    }

    public async Task<List<Monkey>> GetMonkeys()
    {
        if(monkeyList.Count > 0)
            return monkeyList;


        // retrieves same json file that is in the Resources/Raw folder
        var response = await httpClient.GetAsync("https://www.montemagno.com/monkeys.json");

        // TODO: Implement error handling
        if (response.IsSuccessStatusCode)
        {
            monkeyList = await response.Content.ReadFromJsonAsync<List<Monkey>>();
        }

        // If offline, use this for reading in the json file from the Resources/Raw folder
        //using var stream = await FileSystem.OpenAppPackageFileAsync("monkeydata.json");
        //using var reader = new StreamReader(stream);
        //var contents = await reader.ReadToEndAsync();
        //monkeyList = JsonSerializer.Deserialize<List<Monkey>>(contents);

        return monkeyList;
    }
}
