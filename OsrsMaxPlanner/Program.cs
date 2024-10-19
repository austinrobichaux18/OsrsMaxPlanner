using Newtonsoft.Json;
using OsrsMaxPlanner.Models;
using OsrsMaxPlanner.Services;

namespace OsrsMaxPlanner;

internal class Program
{
    static void Main(string[] args)
    {
        var playerData = GetPlayerData();
        var temp = new FishingMethodService().GetMethods();
        var temp2 = JsonConvert.SerializeObject(temp.OrderBy(x => x.Number), Formatting.Indented);
    }


    private static PlayerData GetPlayerData()
    {
        var client = new HttpClient();
        var result = client.GetAsync("https://services.runescape.com/m=hiscore_oldschool/index_lite.json?player=" + "Tafani").Result;
        var resultString = result.Content.ReadAsStringAsync().Result;
        return JsonConvert.DeserializeObject<PlayerData>(resultString);
    }
}
