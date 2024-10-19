namespace OsrsMaxPlanner.Models;
public enum SkillEnum
{
    Overall = 0,
    Attack = 1,
    Defence = 2,
    Strength = 3,
    Hitpoints = 4,
    Ranged = 5,
    Prayer = 6,
    Magic = 7,
    Cooking = 8,
    Woodcutting = 9,
    Fletching = 10,
    Fishing = 11,
    Firemaking = 12,
    Crafting = 13,
    Smithing = 14,
    Mining = 15,
    Herblore = 16,
    Agility = 17,
    Thieving = 18,
    Slayer = 19,
    Farming = 20,
    Runecraft = 21,
    Hunter = 22,
    Construction = 23
}

public static class Skills
{
    public static Skill Overall { get; } = new Skill(0, "Overall");
    public static Skill Attack { get; } = new Skill(1, "Attack");
    public static Skill Defence { get; } = new Skill(2, "Defence");
    public static Skill Strength { get; } = new Skill(3, "Strength");
    public static Skill Hitpoints { get; } = new Skill(4, "Hitpoints");
    public static Skill Ranged { get; } = new Skill(5, "Ranged");
    public static Skill Prayer { get; } = new Skill(6, "Prayer");
    public static Skill Magic { get; } = new Skill(7, "Magic");
    public static Skill Cooking { get; } = new Skill(8, "Cooking");
    public static Skill Woodcutting { get; } = new Skill(9, "Woodcutting");
    public static Skill Fletching { get; } = new Skill(10, "Fletching");
    public static Skill Fishing { get; } = new Skill(11, "Fishing");
    public static Skill Firemaking { get; } = new Skill(12, "Firemaking");
    public static Skill Crafting { get; } = new Skill(13, "Crafting");
    public static Skill Smithing { get; } = new Skill(14, "Smithing");
    public static Skill Mining { get; } = new Skill(15, "Mining");
    public static Skill Herblore { get; } = new Skill(16, "Herblore");
    public static Skill Agility { get; } = new Skill(17, "Agility");
    public static Skill Thieving { get; } = new Skill(18, "Thieving");
    public static Skill Slayer { get; } = new Skill(19, "Slayer");
    public static Skill Farming { get; } = new Skill(20, "Farming");
    public static Skill Runecraft { get; } = new Skill(21, "Runecraft");
    public static Skill Hunter { get; } = new Skill(22, "Hunter");
    public static Skill Construction { get; } = new Skill(23, "Construction");
}
