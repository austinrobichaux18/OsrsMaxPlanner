using Newtonsoft.Json;
using OsrsMaxPlanner.Models;
using OsrsMaxPlanner.Services;

namespace OsrsMaxPlanner;

internal class Program
{
    static void Main(string[] args)
    {
        var playerData = GetPlayerData();
        var allMethods = new SkillingMethodService().GetAllMethods();

        var skillsNeedToLevel = playerData.Skills.Where(x => x.Level < 99).ToList();
        var methodsAbleToDo = allMethods.Where(x =>
                                    x.SkillMethods.All(y =>
                                        y.LevelRequired <= playerData.Skills.First(z => z.Id == (int)y.Name).Level)).ToList();

        foreach (var method in methodsAbleToDo)
        {
            var temp = method.SkillMethods.Where(x =>
                            playerData.Skills.First(z => z.Id == (int)x.Name).Level < 99)
                                .Select(x => x.XpHour).ToList();
            method.TotalXpForNon99Skills = temp.Sum();
            method.NumberOfSkillsTrainedNon99Skills = temp.Count;
        }

        var sorted = methodsAbleToDo.OrderByDescending(x => x.NumberOfSkillsTrainedNon99Skills).ThenBy(x => x.TotalXpForNon99Skills).ToList();

        var msg = JsonConvert.SerializeObject(sorted.Select(x =>
                      new { x.Name, x.NumberOfSkillsTrainedNon99Skills, x.TotalXpForNon99Skills })
                        .ToList(), Formatting.Indented);
        Console.WriteLine(msg);
    }

    private static PlayerData GetPlayerData()
    {
        var client = new HttpClient();
        var result = client.GetAsync("https://services.runescape.com/m=hiscore_oldschool/index_lite.json?player=" + "Tafani").Result;
        var resultString = result.Content.ReadAsStringAsync().Result;
        return JsonConvert.DeserializeObject<PlayerData>(resultString);
    }
}
