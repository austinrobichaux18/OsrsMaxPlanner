namespace OsrsMaxPlanner.Models;
public class Skill
{
    public Skill(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public int Level { get; set; }
    public int Xp { get; set; }
    //public int Rank { get; set; }
}

//public class Activity
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public int Rank { get; set; }
//    public int Score { get; set; }
//}

public class PlayerData
{
    public List<Skill> Skills { get; set; }
    //public List<Activity> Activities { get; set; }
}