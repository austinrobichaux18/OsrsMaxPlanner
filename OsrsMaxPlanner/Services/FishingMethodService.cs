using OsrsMaxPlanner.Models;

namespace OsrsMaxPlanner.Services;
public class FishingMethodService : IMethodService
{
    public IEnumerable<Method> GetMethods()
    {
        yield return new Method
        {
            Number = 1,
            Name = "3t Fishing with herb tar 110k+ Xp/HR",
            PrimarySkill = SkillEnum.Fishing,
            Videos = new List<Video>
            {
                new Video { Url = "https://www.youtube.com/watch?v=Lgcxfeq9cUc", Title = "Example video" },
                new Video { Url = "https://youtu.be/_sXEJYc7Iao", Title = "1 min guide" }
            },
            Description = "Using this method you are able to speed up the rate at which you catch fish. " +
                           "Normally you have a chance to catch a fish every 5 game ticks. By using an herb (Guam, " +
                           "Marrentill, Harralander, Tarromin) on swamp tar, and then clicking the fishing spot, " +
                           "you are able to catch a fish every 3 game ticks, making this method close to double the xp/hr " +
                           "of afk barbarian fishing.",
            SkillMethods = new List<SkillMethod>
            {
                new SkillMethod
                {
                    Name = SkillEnum.Fishing,
                    LevelRequired = 48,
                    XpHour = 110000
                }
            }
        };
        yield return new Method
        {
            Number = 2,
            Name = "3t Fishing + cutting fish Xp/hr 110k+ Fishing, 15k+ Cooking, 10k+ Str/Agi",
            PrimarySkill = SkillEnum.Fishing, // Assuming Fishing is the primary skill
            Videos = new List<Video>
            {
                new Video { Url = "https://streamable.com/q0mpua", Title = "Eat-cut fishing" }
            },
            Description = "This is a great method to learn after you have regular 3 ticking down. " +
                  "Once you’ve started the 3 tick cycle you’re able to continue it by eating roe / caviar. " +
                  "This means that you can continuously keep up the cycle without needing to drop fish. " +
                  "You also receive cooking xp for each fish you successfully cut, making this method more total xp/hr. " +
                  "You can’t start a 3 tick cycle by eating roe/caviar; if you mess up / the spot changes, " +
                  "you’ll need to herb tar or knife log again to start the cycle. " +
                  "Items are used at the top of the inventory as placeholders to allow the fish roe/caviar to predictably appear " +
                  "in the same inventory spot when cutting one fish. " +
                  "This also minimises mouse movement needed to perform the cycle when paired with a camera angle " +
                  "positioning the inventory closer to the fishing spot. " +
                  "It should be noted you do not have to worry about clicking the fish offcuts and then the fishing spot cancelling " +
                  "your cycle. You will always have the knife option 'use' active when you click the fish to cut or click " +
                  "where the offcuts are if you do not roll a catch.",
            SkillMethods = new List<SkillMethod>
            {
                new SkillMethod
                {
                    Name = SkillEnum.Fishing,
                    LevelRequired = 48, // Assuming level requirement for Fishing
                    XpHour = 110000 // Assuming this is the expected XP per hour for Fishing
                },
                new SkillMethod
                {
                    Name = SkillEnum.Cooking,
                    LevelRequired = 1, // Assuming level requirement for Cooking (change as needed)
                    XpHour = 15000 // Expected XP per hour for Cooking
                },
                new SkillMethod
                {
                    Name = SkillEnum.Strength,
                    LevelRequired = 1, // Assuming level requirement for Strength (change as needed)
                    XpHour = 10000 // Expected XP per hour for Strength
                },
                new SkillMethod
                {
                    Name = SkillEnum.Agility,
                    LevelRequired = 1, // Assuming level requirement for Agility (change as needed)
                    XpHour = 10000 // Expected XP per hour for Agility
                }
            }
        };
        yield return new Method
        {
            Number = 3,
            Name = "Afk karambwans: 41k fishing + 150k banked cooking xp/hr",
            PrimarySkill = SkillEnum.Fishing, // Assuming Fishing is the primary skill
            Videos = new List<Video>
            {
                new Video { Url = "https://youtu.be/Uju5kUHMPQ8", Title = "With barrel" },
                new Video { Url = "https://youtu.be/AZqKQZ_pa4Y", Title = "Without barrel" }
            },
            Description = "Travel to DKP with a fairy ring, afk an inventory full of karambwans, then bank them and return as quickly as you can. " +
                  "Ideally teleport to your PoH, click your fairy ring, call your butler and have him take the karambwans to the bank and repeat. " +
                  "This method is very good when you need to AFK but you're able to do something more click intensive than redwoods / NMZ. " +
                  "You should be 1 ticking the karambwans to cook them to make this method a lot more efficient.",
            SkillMethods = new List<SkillMethod>
            {
                new SkillMethod
                {
                    Name = SkillEnum.Fishing,
                    LevelRequired = 1, // Assuming level requirement for Fishing (change as needed)
                    XpHour = 41000 // Expected XP per hour for Fishing
                },
                new SkillMethod
                {
                    Name = SkillEnum.Cooking,
                    LevelRequired = 1, // Assuming level requirement for Cooking (change as needed)
                    XpHour = 150000 // Expected XP per hour for Cooking
                }
            }
        };

        yield return new Method
        {
            Number = 4, // Set the method number to 4 for the next method
            Name = "Cook eating karambwans - 48k fishing and 180k cook / hr",
            PrimarySkill = SkillEnum.Fishing, // Assuming Fishing is the primary skill
            Videos = new List<Video>
            {
                new Video { Url = "https://youtu.be/sQfy7S7hG_M", Title = "Cook eating karambwans" }
            },
            Description = "Fish some karambwans then start cooking one and eating one whenever you see your bait go down 1. " +
                          "You're also able to fish 1, cook 2 for more downtime, do whatever you prefer. " +
                          "You don't need an alt to light logs for you, but it's recommended.",
            SkillMethods = new List<SkillMethod>
            {
                new SkillMethod
                {
                    Name = SkillEnum.Fishing,
                    LevelRequired = 1, // Assuming level requirement for Fishing (change as needed)
                    XpHour = 48000 // Expected XP per hour for Fishing
                },
                new SkillMethod
                {
                    Name = SkillEnum.Cooking,
                    LevelRequired = 1, // Assuming level requirement for Cooking (change as needed)
                    XpHour = 180000 // Expected XP per hour for Cooking
                }
            }
        };
        yield return new Method
        {
            Number = 0, // Set the method number to 4 for Karambwanji
            Name = "Obtaining Karambwanji",
            PrimarySkill = SkillEnum.Fishing, // Assuming Fishing is the primary skill
            Videos = new List<Video>
        {
            new Video { Url = "https://youtu.be/w-HkNPc9osM", Title = "2 Tick Fishing" }
        },
            Description = "Brew down your alt to 0 stats, use bronze darts and range lowering gear (moonclan/splitbark/granite), " +
                          "fill up both accounts' inventories with brews and keep your main's ranged below 60. " +
                          "You can buy bait while buying and banking karambwans if you're a regular ironman, this is effectively 300k bait /hr. " +
                          "You could also afk Karambwanji on mobile during IRL stuff, since you get a good 2-3 minutes+ of afk each click.",
            SkillMethods = new List<SkillMethod>
        {
            new SkillMethod
            {
                Name = SkillEnum.Fishing,
                LevelRequired = 1, // Assuming level requirement for Fishing (change as needed)
                XpHour = 300000 // Expected XP per hour for baiting
            }
        }
        };

        yield return new Method
        {
            Number = 5, // Set the method number to 5 for 3 Tick Fly Fishing
            Name = "3 tick Fly Fishing cook + eat - 71,400 fishing + 95,854 cooking xp/hr",
            PrimarySkill = SkillEnum.Fishing, // Assuming Fishing is the primary skill
            Videos = new List<Video>
        {
            new Video { Url = "https://streamable.com/90mz74", Title = "Members Video" },
            new Video { Url = "https://youtu.be/Bt5BlieARmU", Title = "Erierie's Original F2P Video" }
        },
            Description = "Erie fishing is a lower level and more finicky version of eat-cut 3t barb fishing. " +
                          "On the tick of a roll, click a cooked fish or click to use a knife on a log. " +
                          "On the same tick, if the roll was successful and a fish was caught, use the raw fish on a fire. " +
                          "On the next tick, click the fishing spot. There's absolutely no wiggle room in these clicks, so be careful. " +
                          "Be sure your inventory contains no raw fish before restarting the method after a misclick. " +
                          "Clicking to drop burnt food is best done just before clicking the fishing spot. " +
                          "Firemaking gives a 4t skilling delay which can be used at the start of the method. " +
                          "This method is the fishing meta in f2p.",
            SkillMethods = new List<SkillMethod>
        {
            new SkillMethod
            {
                Name = SkillEnum.Fishing,
                LevelRequired = 1, // Assuming level requirement for Fishing (change as needed)
                XpHour = 71400 // Expected XP per hour for Fishing
            },
            new SkillMethod
            {
                Name = SkillEnum.Cooking,
                LevelRequired = 1, // Assuming level requirement for Cooking (change as needed)
                XpHour = 95854 // Expected XP per hour for Cooking
            }
        }
        };

        yield return new Method
        {
            Number = 6, // Set the method number to 6 for Aerial Fishing
            Name = "Aerial fishing - 75k+ fishing / 95k+ hunter / 20k+ cooking",
            PrimarySkill = SkillEnum.Fishing, // Assuming Fishing is the primary skill
            Videos = new List<Video>
        {
            new Video { Url = "https://youtu.be/W7wLucNIbxQ", Title = "Aerial Fishing" }
        },
            Description = "Getting there: Fairy ring DJR and run south west. " +
                          "Trio rates are unconfirmed, possible it's higher for the 2 players on the West and East but poor rates for the South coast player. " +
                          "Duo can get above Jagex's polled xp/hr, 1 player on the West and 1 on East coast, this allows pools to be shared evenly between both players. " +
                          "Avoid worlds with random players in as your rates will drop. " +
                          "Gear: Full angler set (not a requirement), empty weapon, shield and gloves slot. " +
                          "A knife + bait. Get bait by picking up worms found on the island, then sustaining fish chunks by cutting fish you get while doing the method. " +
                          "Starting off: Pick up bird from Alry the Angler on the Island, click pools to catch fish+salamanders in exchange for Fishing + Hunter xp. " +
                          "Tactics: Stick to the coast area you're on, moving from West to the South for example will lower xp rates. " +
                          "Cast the bird to the nearest pools, prioritising those that are closest. " +
                          "Each pool lasts 7-12 seconds and will move once the bird has been cast to it. " +
                          "Cut fish whilst the bird is flying to a spot, avoid cutting or moving whilst the bird is in your hand as this will waste time gaining experience. " +
                          "Move up and down the shore whilst the bird is flying if you see clusters of pools closer to the shoreline further up/down.",
            SkillMethods = new List<SkillMethod>
        {
            new SkillMethod
            {
                Name = SkillEnum.Fishing,
                LevelRequired = 1, // Assuming level requirement for Fishing (change as needed)
                XpHour = 75000 // Expected XP per hour for Fishing
            },
            new SkillMethod
            {
                Name = SkillEnum.Hunter,
                LevelRequired = 1, // Assuming level requirement for Hunter (change as needed)
                XpHour = 95000 // Expected XP per hour for Hunter
            },
            new SkillMethod
            {
                Name = SkillEnum.Cooking,
                LevelRequired = 1, // Assuming level requirement for Cooking (change as needed)
                XpHour = 20000 // Expected XP per hour for Cooking
            }
        }
        };

        yield return new Method
        {
            Number = 7, // Set the method number to 7 for 2t Swordfish/Tuna
            Name = "2t Swordfish/Tuna - ~137k xp/hr",
            PrimarySkill = SkillEnum.Fishing, // Assuming Fishing is the primary skill
            Videos = new List<Video>
        {
            new Video { Url = "https://streamable.com/w7t7cq", Title = "Off Ticking the Rats" },
            new Video { Url = "https://streamable.com/8mmqfi", Title = "Moving Between Spots" },
            new Video { Url = "https://streamable.com/ybcwlu", Title = "Luring the Rats" }
        },
            Description = "Location and setup: It's highly recommended to use a 3rd party client plugin to swap the 'harpoon' option on the fishing spot to being left click. " +
                          "In RuneLite, this is under the 'menu entry swapper' plugin, with the 'harpoon' option selected. " +
                          "This method can be up to 137k+ fishing xp/hr with the use of a crystal harpoon, and around 125k/hr if only using a dragon harpoon. " +
                          "It is important to setup the rats exactly as shown in the video, and to be cautious when changing spots to prevent the rats from getting off cycle. " +
                          "How to afk if needed: You can't just click the spot to afk, you need get on cycle and then click once off cycle. " +
                          "You're free to then AFK until your inventory fills or the spot moves. It's also pretty easy to AFK and continue 2 ticking with chrome remote desktop.",
            SkillMethods = new List<SkillMethod>
        {
            new SkillMethod
            {
                Name = SkillEnum.Fishing,
                LevelRequired = 1, // Assuming level requirement for Fishing (change as needed)
                XpHour = 137000 // Expected XP per hour for Fishing
            }
        }
        };

        yield return new Method
        {
            Number = 8, // Set the method number to 8 for Solo Tempoross
            Name = "Solo Tempoross for XP",
            PrimarySkill = SkillEnum.Fishing, // Assuming Fishing is the primary skill
            Videos = new List<Video>
        {
            new Video { Url = "https://www.youtube.com/watch?v=lqRHEjxJsO0", Title = "Solo Tempoross" },
            new Video { Url = "https://www.youtube.com/watch?v=9aSnIHdet3I", Title = "Solo Tempoross" }
        },
            Description = "This method revolves around dealing 0 damage to Tempoross during his first attack phase and keeping his energy at 10% or below. " +
                          "The mechanics are predictable so each kill follows a repeating cycle: " +
                          "Fish 25-26, dump all fish into the Ammunition crate, grab 5 buckets and fill them, clear fire (make sure to clear the fire on the boat before leaving), " +
                          "drop buckets, fish 27, dump remaining fish, fish 27, dump 3 fish, attack Tempoross, dump remaining fish. " +
                          "When dealing with the COLOSSAL WAVES (Don't tether unless you still have fish while depositing), fish 22-27 (This will vary depending on Tempoross's Essence but 24% should be low enough to deposit 27 fish), dump remaining fish, kill Tempoross, grab bucket.",
            SkillMethods = new List<SkillMethod>
        {
            new SkillMethod
            {
                Name = SkillEnum.Fishing,
                LevelRequired = 1, // Assuming level requirement for Fishing (change as needed)
                XpHour = 100000 // Expected XP per hour for Fishing
            }
        }
        };

        yield return new Method
        {
            Number = 9, // Set the method number to 9 for Barblore
            Name = "Barblore",
            PrimarySkill = SkillEnum.Fishing, // Assuming Fishing is the primary skill
            Videos = new List<Video>
        {
            new Video { Url = "https://www.youtube.com/watch?v=NI3JTs6YcU0", Title = "Decanting Method" },
            new Video { Url = "https://www.youtube.com/watch?v=RcwyFjGLtcw", Title = "2-dose + Dropping" }
        },
            Description = "Requirements: 70 fishing (with 45 agility and strength), 47+ herblore, games necklaces if not 99 fishing, ‘Menu Entry Swapper’ on RuneLite to toggle left-click and shift-click swaps. " +
                          "Barblore is currently the most macro-efficient way to train fishing. The method is similar to eat-cut barbarian fishing, but with the addition of making barbarian mixes and banking caviar for herblore experience. " +
                          "Fill your inventory with potions and leave at least 4 inventory spaces empty, and teleport to Otto’s Grotto. 3-tick fish similarly to eat-cut fishing, and use the caviar on 2-dose potions to make mixes while staying on cycle. " +
                          "Wear the highest-tier Rada’s blessing available for extra sturgeon. Once you have used up all your potions, fill your inventory with caviar and bank for more potions. " +
                          "You can increase trip length by bringing 4-dose potions and decanting them into 2-doses while fishing. To get the empty vials for decanting, you’ll need to withdraw 1 empty vial at the bank and empty the mixes while fishing. " +
                          "Making a mix, cutting a fish, emptying a potion, dropping and decanting a potion are all 0-tick actions. Doing these actions is only limited by your click speed and accuracy. " +
                          "Mixes count as food, so they can be drunk to continue the 3-tick cycle (similarly to eating roe). " +
                          "While learning, it’s recommended to leave more empty inventory space for the fish and not wear the Rada’s blessing. " +
                          "This makes it easier to keep up with making the mixes as your inventory won’t get full as fast. When you get more comfortable with the method, start wearing the Rada’s blessing for more sturgeon and bring 4-dose potions to use the decant method. " +
                          "You can also cut the trout and salmon for extra cooking experience.",
            SkillMethods = new List<SkillMethod>
        {
            new SkillMethod
            {
                Name = SkillEnum.Fishing,
                LevelRequired = 70, // Required level for Fishing
                XpHour = 105600 // Expected XP per hour for Fishing
            },
            new SkillMethod
            {
                Name = SkillEnum.Agility,
                LevelRequired = 45, // Required level for Agility
                XpHour = 9000 // Expected XP per hour for Agility
            },
            new SkillMethod
            {
                Name = SkillEnum.Strength,
                LevelRequired = 45, // Required level for Strength
                XpHour = 9000 // Expected XP per hour for Strength
            },
            new SkillMethod
            {
                Name = SkillEnum.Herblore,
                LevelRequired = 47, // Required level for Herblore
                XpHour = 20800 // Expected XP per hour for Herblore
            },
            new SkillMethod
            {
                Name = SkillEnum.Cooking,
                LevelRequired = 1, // Assuming level requirement for Cooking (change as needed)
                XpHour = 17600 // Expected XP per hour for Cooking
            }
        }
        };
    }
}
