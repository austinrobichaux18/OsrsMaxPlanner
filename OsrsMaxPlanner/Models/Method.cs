﻿namespace OsrsMaxPlanner.Models;
public class Method
{
    public int Number { get; set; }
    public string Name { get; set; }
    public SkillEnum PrimarySkill { get; set; }
    public List<Video> Videos { get; set; }
    public List<Video> Images { get; set; }
    public List<string> Requirements { get; set; }
    public string Description { get; set; }
    public int TotalXpForNon99Skills { get; set; }
    public int NumberOfSkillsTrainedNon99Skills { get; set; }
    public List<SkillMethod> SkillMethods { get; set; }
}
public class Video
{
    public string Url { get; set; }
    public string Title { get; set; }
}

public class SkillMethod
{
    public SkillEnum Name { get; set; }
    public int LevelRequired { get; set; }
    public int XpHour { get; set; }
}
