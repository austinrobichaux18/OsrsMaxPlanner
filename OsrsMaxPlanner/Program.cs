using Newtonsoft.Json;
using OsrsMaxPlanner.Models;

namespace OsrsMaxPlanner;

internal class Program
{
    static void Main(string[] args)
    {
        var playerData = GetPlayerData();

    }


    private static PlayerData GetPlayerData()
    {
        var client = new HttpClient();
        var result = client.GetAsync("https://services.runescape.com/m=hiscore_oldschool/index_lite.json?player=" + "Tafani").Result;
        var resultString = result.Content.ReadAsStringAsync().Result;
        return JsonConvert.DeserializeObject<PlayerData>(resultString);
    }
}
