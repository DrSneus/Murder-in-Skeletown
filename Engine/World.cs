using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class World
    {
        public static readonly List<Item> Items = new List<Item>();
        public static readonly List<Clue> Clues = new List<Clue>();
        public static readonly List<NPC> NPCs = new List<NPC>();
        public static readonly List<Location> Locations = new List<Location>();

        public const int ITEM_ID_NEWS = 1;
        public const int ITEM_ID_MEMBER_CARD = 2;
        public const int ITEM_ID_MUSEUM_KEY = 3;
        public const int ITEM_ID_SHARDS = 4;
        public const int ITEM_ID_TICKET = 5;
        public const int ITEM_ID_GLOSSY_SHARD = 6;

        public const int NPC_ID_BOUNCER = 1;
        public const int NPC_ID_DIRECTOR = 2;
        public const int NPC_ID_GANGBOSS = 3;
        public const int NPC_ID_MURDERER = 4;

        public const int CLUE_ID_SOLVE_MURDER = 1;
        public const int CLUE_ID_CLOSED_BAR = 2;
        public const int CLUE_ID_CLOSED_MUSEUM = 3;
        public const int CLUE_ID_SUS_GIFT = 4;
        public const int CLUE_ID_MISSING_GEM = 5;
        public const int CLUE_ID_SPOTLESS_SCENE = 6;
        public const int CLUE_ID_FIND_HUGH = 7;

        public const int LOCATION_ID_HOME = 1;
        public const int LOCATION_ID_CITY_SQUARE = 2;
        public const int LOCATION_ID_NIGHTCLUB = 3;
        public const int LOCATION_ID_INNIGHTCLUB= 4;
        public const int LOCATION_ID_MUSEUM = 5;
        public const int LOCATION_ID_INMUSEUM = 6;
        public const int LOCATION_ID_GIFTSHOP = 7;
        public const int LOCATION_ID_CRIMESCENE = 8;
        public const int LOCATION_ID_NIGHTCLUBBACKROOM = 9;
        public const int LOCATION_ID_PARK = 10;
        public const int LOCATION_ID_BRIDGE = 11;

        public const int LOCATION_ID_ENDSCREEN = 12;

        static World()
        {
            PopulateItems();
            PopulateClues();
            PopulateNPCs();
            PopulateLocations();
        }

        private static void PopulateItems()
        {
            Items.Add(new Item(ITEM_ID_NEWS, "Today's Newspaper", "Details Benny's murder, and yesterday's nice weather"));
            Items.Add(new Item(ITEM_ID_MEMBER_CARD, "\'Bone Dry\' Member's Card", "Limited edition card, given only to CaBone members."));
            Items.Add(new Item(ITEM_ID_MUSEUM_KEY, "Museum Key", "Given to you by the museum director."));
            Items.Add(new Item(ITEM_ID_SHARDS, "White Shards", "Found scattered at the gem exhibition"));
            Items.Add(new Item(ITEM_ID_TICKET, "Ripped ticket", "Allowed park entrance yesterday."));
            Items.Add(new Item(ITEM_ID_GLOSSY_SHARD, "Glossy Shard", "Doesn't fit Benny's skull, has a reflective surface."));
        }

        private static void PopulateClues()
        {
            // Creating clues
            Clue closedBar = new Clue(CLUE_ID_CLOSED_BAR, "The Closed Bar",
                "Why did the bouncer seem so on edge?",
                "Based on the bouncer's reaction, someone from the bar must have visited the museum last night");
            Clue closedMuseum = new Clue(CLUE_ID_CLOSED_MUSEUM, "The Closed Museum",
                "I need to find someone who can get me in the museum",
                "The director's keys let me enter the museum");
            Clue susGift = new Clue(CLUE_ID_SUS_GIFT, "CaBone's Gift",
                "What gift was CaBone expecting?",
                "CaBone's gift is related to that shard I saw in the museum");
            Clue missingGem = new Clue(CLUE_ID_MISSING_GEM, "The Missing Gem",
                "A pearl was missing in the gem hall, where could it have gone?",
                "The pearl was shattered against Benny's skull");
            Clue spotlessScene = new Clue(CLUE_ID_SPOTLESS_SCENE, "The Spotless Crime Scene",
                "There's no mess at the crime scene, not even pieces from Benny's skull",
                "Benny was probably killed in the gem room, that's why the shards were missing");
            Clue findHugh = new Clue(CLUE_ID_FIND_HUGH, "Find Hugh",
                "CaBone told you Hugh's probably hiding near the city square",
                "You used Benny's note to track down Hugh");

            // Adding clues to list
            Clues.Add(closedBar);
            Clues.Add(closedMuseum);
            Clues.Add(susGift);
            Clues.Add(missingGem);
            Clues.Add(spotlessScene);
            Clues.Add(findHugh);
        }

        private static void PopulateNPCs()
        {
            // Creating NPCS
            NPC bouncer = new NPC(NPC_ID_BOUNCER, "Bouncer");
            NPC director = new NPC(NPC_ID_DIRECTOR, "Director");
            NPC gangBoss = new NPC(NPC_ID_GANGBOSS, "CaBone");
            NPC murderer = new NPC(NPC_ID_MURDERER, "Murderer");

            // Creating Dialogue, and adding flags for additional dialogues
            bouncer.DialogueTree.Add(new Dialogue("Sorry, no one in today unless you're invited.", 0,
                new string[] { "What's the occasion?", "Let me in. Now", "What do you know about Benny Bones' death?" },
                new double[] { 0.1, 0.2, 0.3 }));
            bouncer.DialogueTree.Add(new Dialogue("Boss's birthday, family and friends only. I don't think that includes you.", 0.1,
               new string[] { "I see, thanks."},
               new double[] { 99 }));
            bouncer.DialogueTree.Add(new Dialogue("Ha, thanks for making me laugh tough guy.", 0.2,
               new string[] { "Fine, I'm leaving" },
               new double[] { 99 }));
            bouncer.DialogueTree.Add(new Dialogue("Uhhh..umm..uh nothing. The boss definitely doesn't know anything either!", 0.3,
               new string[] { "Okay?" },
               new double[] { 99 },
               ClueByID(CLUE_ID_CLOSED_BAR)));
            bouncer.Flag = new DialogueFlag(ClueByID(CLUE_ID_CLOSED_BAR), ItemByID(ITEM_ID_MEMBER_CARD), 0.3,
                "Found this card at the museum last night, know anything about it?",
                new Dialogue("I..uhh...that doesn't prove nothing! It's uhhh...unrelated to our business!" +
                " But uh...I guess I can let you in, just don't tell no one about that card!", 0.4,
                new string[] { "Thanks." },
                new double[] { 99 }));

            director.DialogueTree.Add(new Dialogue("Please sir, have a look around!", 0,
                new string[] { "Who are you?", "Did you know the victim?"},
                new double[] { 0.1, 0.2 }));
            director.DialogueTree.Add(new Dialogue("Name's Clavis, Clavis Cull. I'm the director of this fine museum, as well as the gift store manager!", 0.1,
               new string[] { "How's business?", "Did you know the victim?" },
               new double[] { 0.11, 0.2 }));
            director.DialogueTree.Add(new Dialogue("To be honest, we were doing quite poorly even before the murder. Probably just a matter of time before we go under.", 0.11,
               new string[] { "Sorry to hear that", "Did you know the victim?" },
               new double[] { 99 , 0.2 }));
            director.DialogueTree.Add(new Dialogue("Benny was...a good pal of mine, and an excellent customer. Without him, the museum would have gone bankrupt ages ago.", 0.2,
               new string[] { "...", "Do you know anything about the murder?" },
               new double[] { 99, 0.21 }));
            director.DialogueTree.Add(new Dialogue("I haven't actually looked at the crime scene, cause uh y'know? Actually, you know what? You're investigating" +
                " his death, so I\'ll let you use my keys to get in.", 0.21,
               new string[] { "Thank you", "How come?" },
               new double[] { 99, 0.211 },
               ItemByID(ITEM_ID_MUSEUM_KEY)));
            director.DialogueTree.Add(new Dialogue("Not sure, but I get a weird feeling that his death will remain unsolved otherwise y'know?", 0.211,
                new string[] { "I see" },
                new double[] { 99 } ));

            gangBoss.DialogueTree.Add(new Dialogue("What do you want?", 0,
                new string[] { "Who are you?", "Found this shard", "Know anything about the victim?" },
                new double[] { 0.1, 0.2, 0.3 }));
            gangBoss.DialogueTree.Add(new Dialogue("If the CaBone family name isn't familiar to you, then you might want to keep it that way, got it?", 0.1,
               new string[] { "Understood ", "Did you know the victim?", "Happy Birthday!" },
               new double[] { 0, 0.3, 0.11 }));
            gangBoss.DialogueTree.Add(new Dialogue("Ha! Thanks kid.", 0.11,
               new string[] { "Found this shard", "Do you know the victim?" },
               new double[] { 0.2, 0.3 }));
            gangBoss.DialogueTree.Add(new Dialogue("...Why is it in pieces?", 0.2,
               new string[] { "Not sure" },
               new double[] { .21 }));
            gangBoss.DialogueTree.Add(new Dialogue("...Hugh's gotta lot to explain. Thanks for letting me know about this at least.", 0.21,
               new string[] { "What is it?", "Hugh?" },
               new double[] { .211, .212 }));
            gangBoss.DialogueTree.Add(new Dialogue("A \'gift\' as it were, at least a piece of it. You may not want to inquire further on this matter.", 0.211,
               new string[] { "Ok", "Hugh?" },
               new double[] { 0, .212 }));
            gangBoss.DialogueTree.Add(new Dialogue("Just some trash who was supposed to bring me a present, not break it. I'll send some of my boys to " +
                "\"talk\" with him later...", 0.212,
               new string[] { "Any way I can be of assistance?", "What is this shard anyways?" },
               new double[] { .2121, .211 }));
            gangBoss.DialogueTree.Add(new Dialogue("Sure, why not. He's probably hiding near the city square. I'll let you talk to him, before I...deal with him", 0.2121,
               new string[] { "Thanks" },
               new double[] { 0 },
               ClueByID(CLUE_ID_FIND_HUGH)));
            gangBoss.DialogueTree.Add(new Dialogue("That uh..Benny guy right? Nah, he wasn't involved with my family, to my knowledge anyways.", 0.3,
                new string[] { "I see" },
                new double[] { 99 }));

            murderer.DialogueTree.Add(new Dialogue("W-what do you want!", 0,
                new string[] { "Who are you?", "What do you know about Benny's murder?" },
                new double[] { 0.1, 0.2 }));
            murderer.DialogueTree.Add(new Dialogue("N-n-nobody! I mean..my n-name is Hugh! Hugh Merris", 0.1,
               new string[] { "I've been sent by CaBone" },
               new double[] { 0.11 }));
            murderer.DialogueTree.Add(new Dialogue("W-w-wait! I was going to get him his pearl honest! I was just uhhh...polishing it. Yeah that's it!", 0.11,
               new string[] { "I see" },
               new double[] { 0 }));
            murderer.DialogueTree.Add(new Dialogue("NOTHING I SWEAR! I mean uh..nothing sir. I don't know what uh, what you're talking about.", 0.2,
                new string[] { "I see" },
                new double[] { 0 }));

            murderer.Flag = new DialogueFlag(ClueByID(CLUE_ID_MISSING_GEM), ItemByID(ITEM_ID_GLOSSY_SHARD), 0.11,
                "You killed Benny with this, didn't you?",
                new Dialogue("Ah! I..no I didn't...I mean...........okay. But let me explain", 0.12,
                new string[] { "..." },
                new double[] { 0.3 }));
            murderer.DialogueTree.Add(new Dialogue("I was planning on stealing the pearl yesterday, to pay off debts to the CaBone family.", 0.3,
                new string[] { "..." },
                new double[] { 0.31 }));
            murderer.DialogueTree.Add(new Dialogue("Everything was going well, but on my way out...\"he\" was standing there", 0.31,
                new string[] { "..." },
                new double[] { 0.32 }));
            murderer.DialogueTree.Add(new Dialogue("I tried knocking him out with the pearl, but that's when everything fell apart", 0.32,
                new string[] { "..." },
                new double[] { 0.33 }));
            murderer.DialogueTree.Add(new Dialogue("I swung too hard, and both the pearl and his skull shattered.", 0.33,
                new string[] { "..." },
                new double[] { 0.34 }));
            murderer.DialogueTree.Add(new Dialogue("Ah. I knew I wasn't gonna be able to get away with this. " +
                "I'm just sorry it ended up like this to begin with", 0.34,
                new string[] { "..." },
                new double[] { 0.35 }));
            murderer.DialogueTree.Add(new Dialogue("Suppose I'll be going away for a while now, it's only fair. Can't run from this. " +
                "Not like I could have fled from CaBone anyways.", 0.35,
                new string[] { "Sorry (End Game)" },
                new double[] { 100 }));

            // Adding NPCs to List
            NPCs.Add(bouncer);
            NPCs.Add(director);
            NPCs.Add(gangBoss);
            NPCs.Add(murderer);
        }

        private static void PopulateLocations()
        {
            // Creating locations
            Location home = new Location(LOCATION_ID_HOME, "The Office");

            Location citySquare = new Location(LOCATION_ID_CITY_SQUARE, "City Square");

            Location nightclub = new Location(LOCATION_ID_NIGHTCLUB, "Bone Dry Bar - Exterior");
                nightclub.NPCHere = NPCByID(NPC_ID_BOUNCER);

            Location insideNightClub = new Location(LOCATION_ID_INNIGHTCLUB, "Bone Dry Bar - Interior", true);

            Location museum = new Location(LOCATION_ID_MUSEUM, "Museum - Exterior");

            Location insideMuseum = new Location(LOCATION_ID_INMUSEUM, "Museum - Interior", true);

            Location museumGiftShop = new Location(LOCATION_ID_GIFTSHOP, "Museum - Gift Shop");
                museumGiftShop.NPCHere = NPCByID(NPC_ID_DIRECTOR);

            Location crimeScene = new Location(LOCATION_ID_CRIMESCENE, "Crime Scene");

            Location nightclubBackroom = new Location(LOCATION_ID_NIGHTCLUBBACKROOM, "Bone Dry Bar - Back Room", true);
                nightclubBackroom.NPCHere = NPCByID(NPC_ID_GANGBOSS);

            Location park = new Location(LOCATION_ID_PARK, "Cranium Park", true);

            Location parkBridge = new Location(LOCATION_ID_BRIDGE, "Cranium Park - Bridge");
                parkBridge.NPCHere = NPCByID(NPC_ID_MURDERER);

            Location endscreen = new Location(LOCATION_ID_ENDSCREEN, "The End");

            // Linking locations
            home.AdjacentLocations.Add(citySquare);

            citySquare.AdjacentLocations.Add(nightclub);
            citySquare.AdjacentLocations.Add(home);
            citySquare.AdjacentLocations.Add(museum);
            citySquare.AdjacentLocations.Add(park);

            nightclub.AdjacentLocations.Add(citySquare);
            nightclub.AdjacentLocations.Add(insideNightClub);

            insideNightClub.AdjacentLocations.Add(nightclub);
            insideNightClub.AdjacentLocations.Add(nightclubBackroom);

            museum.AdjacentLocations.Add(citySquare);
            museum.AdjacentLocations.Add(museumGiftShop);
            museum.AdjacentLocations.Add(insideMuseum);

            insideMuseum.AdjacentLocations.Add(museum);
            insideMuseum.AdjacentLocations.Add(crimeScene);

            museumGiftShop.AdjacentLocations.Add(museum);

            crimeScene.AdjacentLocations.Add(insideMuseum);

            nightclubBackroom.AdjacentLocations.Add(insideNightClub);

            park.AdjacentLocations.Add(citySquare);
            park.AdjacentLocations.Add(parkBridge);

            parkBridge.AdjacentLocations.Add(park);

            // Adding location dialogue
            home.DialogueTree.Add(new Dialogue("Your place of work, located just outside Skeletown", 0,
                new string[] { "Read the news", "Water the office plant" },
                new double[] { 0.1, 0.2 }));
            home.DialogueTree.Add(new Dialogue("Benny Bones was found dead inside the museum \"The Bones of History\" yesterday. " +
                "The string of storms lately seems to have ended, with the sunny day yesterday.", 0.1,
                new string[] { "Water the office plant", "Look around the office" },
                new double[] { 0.2, 0 },
                ItemByID(ITEM_ID_NEWS)));
            home.DialogueTree.Add(new Dialogue("He's looking alive and healthy, unlike Benny.", 0.2,
                new string[] { "Read the news", "Look around the office" },
                new double[] { 0.1, 0 }));

            citySquare.DialogueTree.Add(new Dialogue("Skeletons are walking around the city's downtown. Nearby is the town museum, and the bar \"Bone Dry\"", 0,
                new string[] { "Look at the townspeople", "Take a smoke break", "Go to the park" },
                new double[] { 0.1, 0.2, 0.3 }));
            citySquare.DialogueTree.Add(new Dialogue("The skeletons around town seem to disregard your presence.", 0.1,
                new string[] { "Take a smoke break", "Look around town" },
                new double[] { 0.2, 0 }));
            citySquare.DialogueTree.Add(new Dialogue("You look for a cigarette, before you remember that you don't smoke, as you lack lungs.", 0.2,
                new string[] { "Look at the townspeople", "Look around town" },
                new double[] { 0.1, 0 }));
            citySquare.DialogueTree.Add(new Dialogue("The park requires an admission fee, is it really worth entering?", 0.3,
                new string[] { "Return to the city square" },
                new double[] { 0 }));
            citySquare.Flag = new DialogueFlag(ClueByID(CLUE_ID_FIND_HUGH), ItemByID(ITEM_ID_TICKET), 0.3,
                "Buy park admission, Hugh may be in there",
                new Dialogue("You've purchased park admission, you may now enter Cranium Park", 0.31,
                new string[] { "Return to the main square" },
                new double[] { 99 }));

            museum.DialogueTree.Add(new Dialogue("The entrance is blocked with police tape, seems like you'll have to wait for the investigation to finish.", 0,
                new string[] { "Examine the museum's exterior", "Enter the museum" },
                new double[] { 0.1, 0.2 }));
            museum.DialogueTree.Add(new Dialogue("There's a membership card on the floor by the museum for \'Bone Dry\'. Maybe " +
                "someone from \"Bone Dry\" left it here last night.", 0.1,
                new string[] { "Return to the museum entrace" },
                new double[] { 99 },
                ItemByID(ITEM_ID_MEMBER_CARD)));
            museum.DialogueTree.Add(new Dialogue("\"Hey you can't come in here, it's a crime scene. Only police and staff are allowed in.\"", 0.2,
                new string[] { "Return to the museum entrace" },
                new double[] { 99 },
                ClueByID(CLUE_ID_CLOSED_MUSEUM)));
            museum.Flag = new DialogueFlag(ClueByID(CLUE_ID_CLOSED_MUSEUM), ItemByID(ITEM_ID_MUSEUM_KEY), 0.2,
                "Enter through a staff entrance",
                new Dialogue("The museum director's key unlocks the door. You now have access to the museum's interior", 0.3,
                new string[] { "Look around" },
                new double[] { 99 }));

            insideNightClub.DialogueTree.Add(new Dialogue("Dozens of skeletons in suits are crowded around the bar. On stage, you see CaBone, the boss of the local mafia, preparing a speech", 0,
                new string[] { "Listen to the speech", "Observe the crowd's faces", "Enter the backroom" },
                new double[] { 0.1, 0.2, 0.3 }));
            insideNightClub.DialogueTree.Add(new Dialogue("\"My friends! I am delighted to have you join me here for my birthday this evening.\"", 0.1,
                new string[] { "Continue listening", "Observe the crowd's faces" },
                new double[] { 0.11, 0.2 }));
            insideNightClub.DialogueTree.Add(new Dialogue("\"To be honest with you good people, yesterday we suffered a terrible loss; a gift we were expecting " +
                "never arrived.\" His expression darkens as he scans the crowd.", 0.11,
                new string[] { "Continue listening", "Observe the crowd's faces" },
                new double[] { 0.111, 0.2 }));
            insideNightClub.DialogueTree.Add(new Dialogue("\"But this is a time of joy, so enough work talk! Let's party!\"", 0.111,
                new string[] { "Look around", "Observe the crowd's faces" },
                new double[] { 0, 0.2 }, 
                ClueByID(CLUE_ID_SUS_GIFT)));
            insideNightClub.DialogueTree.Add(new Dialogue("The crowd sounds joyful, but it's hard to read the facial expressions on skulls", 0.2,
                new string[] { "Look around", "Listen to the speaker" },
                new double[] { 0, 0.1 }));
            insideNightClub.DialogueTree.Add(new Dialogue("A guard posted by the door stops you: \"The boss isn't entertaining visitors tonight, " +
                "that is unless they have something for the boss...\"", 0.3,
                new string[] { "Look around" },
                new double[] { 0 }));
            insideNightClub.Flag = new DialogueFlag(ClueByID(CLUE_ID_SUS_GIFT), ItemByID(ITEM_ID_GLOSSY_SHARD), 0.3,
                "Show the security guard the glossy shard",
                new Dialogue("\"Is that...I see. Okay, feel free to go through sir.\"", 0.31,
                new string[] { "Thanks" },
                new double[] { 0 }));

            insideMuseum.DialogueTree.Add(new Dialogue("The museum's main hall. Despite the police blocking the exterior entrances, it is empty.", 0,
                new string[] { "Look around" },
                new double[] { 0.1 }));
            insideMuseum.DialogueTree.Add(new Dialogue("There are paths to different wings of the museum; the dinosaur room, the history room and the rare gems room", 0.1,
                new string[] { "Go to the dinosaur room", "Go to the history room", "Go to the gem room" },
                new double[] { 0.11, 0.12, 0.13 }));
            insideMuseum.DialogueTree.Add(new Dialogue("A massive T-rex takes up most of the space in this wing. You briefly wonder whether one of these dinosaurs is the " +
                "true killer, before realizing how stupid that sounds", 0.11,
                new string[] { "Return to the main hall", "Go to the history room", "Go to the gem room" },
                new double[] { 0, 0.12, 0.13 }));
            insideMuseum.DialogueTree.Add(new Dialogue("This wing is decorated with artifacts from several historical periods. You wonder whether you would look good" +
                " in Napoleon Boneaparte's hat, but decide against trying it.", 0.12,
                new string[] { "Return to the main hall", "Go to the dinosaur room", "Go to the gem room" },
                new double[] { 0, 0.11, 0.13 }));
            insideMuseum.DialogueTree.Add(new Dialogue("While admiring the gems in this room, you notice a missing crystal from one of the displays.", 0.13,
                new string[] { "Return to the main hall", "Examine further"},
                new double[] { 0, 0.131 },
                ClueByID(CLUE_ID_MISSING_GEM)));
            insideMuseum.DialogueTree.Add(new Dialogue("You notice pale white shards on the floor, poorly hidden under an exhibit.", 0.131,
                new string[] { "Return to the main hall", "Go to the dinosaur room", "Go to the history room" },
                new double[] { 0, 0.11, 0.12 },
                ItemByID(ITEM_ID_SHARDS)));

            crimeScene.DialogueTree.Add(new Dialogue("Benny's body is lying in the center of the floor", 0,
                new string[] { "Examine Benny's body", "Examine the surrounding area", "Examine Benny's belongings" },
                new double[] { 0.1, 0.2, 0.3 }));
            crimeScene.DialogueTree.Add(new Dialogue("Benny's skull is cracked on the back, it seems he was attacked from behind.", 0.1,
                new string[] { "Glance around the room", "Examine the surrounding area", "Examine Benny's belongings" },
                new double[] { 0, 0.2, 0.3 }));
            crimeScene.DialogueTree.Add(new Dialogue("The area around Benny is spotless, there aren't even any pieces of Benny's skull strewn around", 0.2,
                new string[] { "Glance around the room", "Examine Benny's body", "Examine Benny's belongings" },
                new double[] { 0, 0.1, 0.3 },
                ClueByID(CLUE_ID_SPOTLESS_SCENE)));
            crimeScene.DialogueTree.Add(new Dialogue("Under Benny, you notice a ripped ticket to Cranium Park. The name on the" +
                " ticket is ripped, but you can tell it starts with H-", 0.3,
                new string[] { "Glance around the room", "Examine Benny's body", "Examine the surrounding area" },
                new double[] { 0, 0.1, 0.2 },
                ItemByID(ITEM_ID_TICKET)));
            crimeScene.Flag = new DialogueFlag(ClueByID(CLUE_ID_SPOTLESS_SCENE), ItemByID(ITEM_ID_SHARDS), 0.2,
                "Compare the shards with Benny's body",
                new Dialogue("The shards match up perfectly, it seems as though this was the true scene of the crime." +
                " In lining the shards up however, one of them seems as though they weren't part of Benny's body. In fact, it's almost reflective.", 0.21,
                new string[] { "Glance around the room", "Examine Benny's corpse", "Examine Benny's belongings" },
                new double[] { 0, 0.1, 0.3 },
                ItemByID(ITEM_ID_GLOSSY_SHARD)));

            park.DialogueTree.Add(new Dialogue("The park is beautiful, though oddly empty today. Under a nearby bridge, you notice a sleazy looking skeleton", 0,
                new string[] { "Look at the nature" },
                new double[] { 0.1 }));
            park.DialogueTree.Add(new Dialogue("The gardens are well tended, with the flower arrangements to appear like a grinning skull", 0.1,
                new string[] { "Return to the main park" },
                new double[] { 0 }));

            endscreen.DialogueTree.Add(new Dialogue("Thank you for playing to the end!", 0,
                new string[] { "..." },
                new double[] { 0.1 }));
            endscreen.DialogueTree.Add(new Dialogue("You've solved the murder of Benny Bones!", 0.1,
                new string[] { "..." },
                new double[] { 0.2 }));
            endscreen.DialogueTree.Add(new Dialogue("I hope you had fun!", 0.2,
                new string[] { "..." } ,
                new double[] { 0.2 }));

            // Add the locations to the static list
            Locations.Add(home);
            Locations.Add(citySquare);
            Locations.Add(nightclub);
            Locations.Add(insideNightClub);
            Locations.Add(museum);
            Locations.Add(insideMuseum);
            Locations.Add(museumGiftShop);
            Locations.Add(crimeScene);
            Locations.Add(nightclubBackroom);
            Locations.Add(park);
            Locations.Add(parkBridge);
            Locations.Add(endscreen);
        }

        public static Item ItemByID(int id)
        {
            foreach (Item item in Items)
            {
                if (item.ID == id)
                {
                    return item;
                }
            }

            return null;
        }

        public static NPC NPCByID(int id)
        {
            foreach (NPC NPC in NPCs)
            {
                if (NPC.ID == id)
                {
                    return NPC;
                }
            }

            return null;
        }

        public static Clue ClueByID(int id)
        {
            foreach (Clue clue in Clues)
            {
                if (clue.ID == id)
                {
                    return clue;
                }
            }

            return null;
        }

        public static Location LocationByID(int id)
        {
            foreach (Location location in Locations)
            {
                if (location.ID == id)
                {
                    return location;
                }
            }

            return null;
        }

        public static Clue ClueByDialogue(Dialogue dialogue)
        {
            return dialogue.GiveClue;
        }

        public static Item ItemByDialogue(Dialogue dialogue)
        {
            return dialogue.GiveItem;
        }

        public static Dialogue NPCDialogueByID(NPC npc, double dialogueID)
        {
            foreach (Dialogue dialogue in npc.DialogueTree)
            {
                if (dialogue.ID == dialogueID)
                {
                    return dialogue;
                }
            }

            return null;
        }

        public static Dialogue LocationDialogueByID(Location location, double dialogueID)
        {
            foreach (Dialogue dialogue in location.DialogueTree)
            {
                if (dialogue.ID == dialogueID)
                {
                    return dialogue;
                }
            }

            return null;
        }

    }
}