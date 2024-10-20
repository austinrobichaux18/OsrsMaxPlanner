using Newtonsoft.Json;
using OsrsMaxPlanner.Models;
using System.Reflection;

namespace OsrsMaxPlanner.Services;
public class SkillingMethodService
{
    public List<Method> GetAllMethods()
    {
        var methods = new List<Method>();
        methods.AddRange(GetMethods(nameof(SkillEnum.Fishing)));
        methods.AddRange(GetMethods(nameof(SkillEnum.Woodcutting)));
        methods.AddRange(GetMethods(nameof(SkillEnum.Mining)));
        methods.AddRange(GetMethods(nameof(SkillEnum.Hunter)));
        return methods;
    }

    private static List<Method> GetMethods(string name)
    {
        var assemblyPath = Assembly.GetExecutingAssembly().Location;
        var directoryPath = Path.GetDirectoryName(assemblyPath);
        var jsonFilePath = Path.Combine(directoryPath, @$"..\..\..\Data\{name}.json");

        var jsonString = File.ReadAllText(jsonFilePath);

        var methods = JsonConvert.DeserializeObject<List<Method>>(jsonString);
        return methods;
    }
}
