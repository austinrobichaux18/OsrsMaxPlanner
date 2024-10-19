using OsrsMaxPlanner.Models;

namespace OsrsMaxPlanner.Services;
public interface IMethodService
{
    IEnumerable<Method> GetMethods();
}
