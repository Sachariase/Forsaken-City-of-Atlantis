#region

using System;
using System.Collections.Generic;
using System.Linq;
using db.data;
using log4net;

#endregion

namespace wServer.realm.entities
{
    internal class MerchantLists
    {
        public static int[] AccessoryClothList;
        public static int[] AccessoryDyeList;
        public static int[] ClothingClothList;
        public static int[] ClothingDyeList;

        public static Dictionary<int, Tuple<int, CurrencyType>> prices = new Dictionary<int, Tuple<int, CurrencyType>>
        {
            {0xb41, new Tuple<int, CurrencyType>(0, CurrencyType.Fame)}, //Tablet UT
            {0xbab, new Tuple<int, CurrencyType>(0, CurrencyType.Fame)}, //Crown UT
            {0xbad, new Tuple<int, CurrencyType>(0, CurrencyType.Fame)}, //Bracer UT

            //WEAPONS
            {0xaf6, new Tuple<int, CurrencyType>(400, CurrencyType.Fame)}, //Wand Of Recompense T12
            {0xa87, new Tuple<int, CurrencyType>(225, CurrencyType.Fame)}, //Wand Of Ancient Warning T11
            {0xb02, new Tuple<int, CurrencyType>(400, CurrencyType.Fame)}, //Bow Of Covert Havens T12
            {0xa8d, new Tuple<int, CurrencyType>(225, CurrencyType.Fame)}, //Bow Of Innocent Blood T11
            {0xb08, new Tuple<int, CurrencyType>(400, CurrencyType.Fame)}, //Staff of the Cosmic Whole T12
            {0xaa2, new Tuple<int, CurrencyType>(225, CurrencyType.Fame)}, //Staff of Astral Knowledge T11

            {0xb0b, new Tuple<int, CurrencyType>(400, CurrencyType.Fame)}, //Sword of Acclaim T12
            {0xa47, new Tuple<int, CurrencyType>(225, CurrencyType.Fame)}, //Skysplitter Sword T11
            {0xaff, new Tuple<int, CurrencyType>(400, CurrencyType.Fame)}, //Dagger Of Foul Malevolence T12
            {0xa8a, new Tuple<int, CurrencyType>(225, CurrencyType.Fame)}, //Agateclaw Dagger T11
            {0xc50, new Tuple<int, CurrencyType>(400, CurrencyType.Fame)}, //Masamune T12
            {0xc4f, new Tuple<int, CurrencyType>(225, CurrencyType.Fame)}, //Muramasa T11

            //Rings
            {0xba3, new Tuple<int, CurrencyType>(300, CurrencyType.Fame)}, //Ring Of Unbound Attack T6
            {0xba4, new Tuple<int, CurrencyType>(300, CurrencyType.Fame)}, //Ring Of Unbound Defense T6
            {0xba5, new Tuple<int, CurrencyType>(300, CurrencyType.Fame)}, //Ring Of Unbound Speed T6
            {0xba6, new Tuple<int, CurrencyType>(300, CurrencyType.Fame)}, //Ring Of Unbound Vitality T6
            {0xba7, new Tuple<int, CurrencyType>(300, CurrencyType.Fame)}, //Ring Of Unbound Wisdom T6
            {0xba8, new Tuple<int, CurrencyType>(300, CurrencyType.Fame)}, //Ring Of Unbound Dexterity T6
            {0xba9, new Tuple<int, CurrencyType>(300, CurrencyType.Fame)}, //Ring Of Unbound Health T6
            {0xbaa, new Tuple<int, CurrencyType>(300, CurrencyType.Fame)}, //Ring Of Unbound Magic T6
            {0xac7, new Tuple<int, CurrencyType>(100, CurrencyType.Fame)}, //Ring Of Exalted Attack T5
            {0xac8, new Tuple<int, CurrencyType>(100, CurrencyType.Fame)}, //Ring Of Exalted Defense T5
            {0xac9, new Tuple<int, CurrencyType>(100, CurrencyType.Fame)}, //Ring Of Exalted Speed T5
            {0xaca, new Tuple<int, CurrencyType>(100, CurrencyType.Fame)}, //Ring Of Exalted Vitality T5
            {0xacb, new Tuple<int, CurrencyType>(100, CurrencyType.Fame)}, //Ring Of Exalted Wisdom T5
            {0xacc, new Tuple<int, CurrencyType>(100, CurrencyType.Fame)}, //Ring Of Exalted Dexterity T5
            {0xacd, new Tuple<int, CurrencyType>(100, CurrencyType.Fame)}, //Ring Of Exalted Health T5
            {0xace, new Tuple<int, CurrencyType>(100, CurrencyType.Fame)}, //Ring Of Exalted Magic T5
            //ARMORS
            {0xb05, new Tuple<int, CurrencyType>(400, CurrencyType.Fame)}, //Robe of the Grand Sorcerer T13
            {0xa96, new Tuple<int, CurrencyType>(225, CurrencyType.Fame)}, //Robe of the Elder Warlock T12
            {0xa95, new Tuple<int, CurrencyType>(100, CurrencyType.Fame)}, //Robe of the Moon Wizard T11
            {0xafc, new Tuple<int, CurrencyType>(400, CurrencyType.Fame)}, //Acropolis Armor T13
            {0xa93, new Tuple<int, CurrencyType>(225, CurrencyType.Fame)}, //Abyssal Armor T12
            {0xa92, new Tuple<int, CurrencyType>(100, CurrencyType.Fame)}, //Vengeance Armor T11
            {0xaf9, new Tuple<int, CurrencyType>(400, CurrencyType.Fame)}, //Hydra Skin Armor T13
            {0xa90, new Tuple<int, CurrencyType>(225, CurrencyType.Fame)}, //Griffon Hide Armor T12
            {0xa8f, new Tuple<int, CurrencyType>(100, CurrencyType.Fame)}, //Hippogriff Hide Armor t11
     
            //ABILITIES
            {0xb25, new Tuple<int, CurrencyType>(200, CurrencyType.Fame)}, //Tome Of Holy Guidance T6
            {0xb22, new Tuple<int, CurrencyType>(200, CurrencyType.Fame)}, //Colossus Shield T6
            {0xb24, new Tuple<int, CurrencyType>(200, CurrencyType.Fame)}, //Elemental Detonation Spell T6
            {0xb26, new Tuple<int, CurrencyType>(200, CurrencyType.Fame)}, //Seal of the Blessed Champion T6
            {0xb27, new Tuple<int, CurrencyType>(200, CurrencyType.Fame)}, //Cloak of Ghostly Concealment T6
            {0xb28, new Tuple<int, CurrencyType>(200, CurrencyType.Fame)}, //Quiver of Elvish Mastery T6
            {0xb29, new Tuple<int, CurrencyType>(200, CurrencyType.Fame)}, //Helm of the Great General T6
            {0xb2a, new Tuple<int, CurrencyType>(200, CurrencyType.Fame)}, //Baneserpent Poison T6
            {0xb2b, new Tuple<int, CurrencyType>(200, CurrencyType.Fame)}, //Bloodsucker Skull T6
            {0xb2c, new Tuple<int, CurrencyType>(200, CurrencyType.Fame)}, //Giantcatcher Trap T6
            {0xb2d, new Tuple<int, CurrencyType>(200, CurrencyType.Fame)}, //Planefetter Orb T6
            {0xb23, new Tuple<int, CurrencyType>(200, CurrencyType.Fame)}, //Prism of Apparitions T6
            {0xb33, new Tuple<int, CurrencyType>(200, CurrencyType.Fame)}, //Scepter of Storms T6
            {0xc59, new Tuple<int, CurrencyType>(200, CurrencyType.Fame)}, //Doom Circle T6

            //PET FOOD
            {0xccc, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Ambrosia
            {0xccb, new Tuple<int, CurrencyType>(25, CurrencyType.Fame)}, //Fries
            {0xcca, new Tuple<int, CurrencyType>(120, CurrencyType.Fame)}, //Grapes Of Wrath
            {0xcc9, new Tuple<int, CurrencyType>(5, CurrencyType.Fame)}, //Soft Drink
            {0xcc8, new Tuple<int, CurrencyType>(200, CurrencyType.Fame)}, //Superburger
            {0xcc7, new Tuple<int, CurrencyType>(400, CurrencyType.Fame)}, //Double Cheese Burger Deluxe
            {0xcc6, new Tuple<int, CurrencyType>(50, CurrencyType.Fame)}, //Great Taco
            {0xcc5, new Tuple<int, CurrencyType>(70, CurrencyType.Fame)}, //Power Pizza
            {0xcc4, new Tuple<int, CurrencyType>(80, CurrencyType.Fame)}, //Chocolate Ice Cream Cookie

            //EGGS
            {0xc87, new Tuple<int, CurrencyType>(800, CurrencyType.Fame)}, //rare feline egg
            {0xc8b, new Tuple<int, CurrencyType>(800, CurrencyType.Fame)}, //rare canine egg
            {0xc8f, new Tuple<int, CurrencyType>(800, CurrencyType.Fame)}, //rare avian egg
            {0xc93, new Tuple<int, CurrencyType>(800, CurrencyType.Fame)}, //rare exotic egg
            {0xc97, new Tuple<int, CurrencyType>(800, CurrencyType.Fame)}, //rare farm egg
            {0xc9b, new Tuple<int, CurrencyType>(800, CurrencyType.Fame)}, //rare woodland egg
            {0xc9f, new Tuple<int, CurrencyType>(800, CurrencyType.Fame)}, //rare reptile egg
            {0xca3, new Tuple<int, CurrencyType>(800, CurrencyType.Fame)}, //rare insect egg
            {0xca7, new Tuple<int, CurrencyType>(800, CurrencyType.Fame)}, //rare pinguin egg
            {0xcab, new Tuple<int, CurrencyType>(800, CurrencyType.Fame)}, //rare aquatic egg
            {0xcaf, new Tuple<int, CurrencyType>(800, CurrencyType.Fame)}, //rare spooky egg
            {0xcb3, new Tuple<int, CurrencyType>(800, CurrencyType.Fame)}, //rare humanoid egg
            {0xcb7, new Tuple<int, CurrencyType>(800, CurrencyType.Fame)}, //rare ???? egg
            {0xcbb, new Tuple<int, CurrencyType>(800, CurrencyType.Fame)}, //rare automaton egg
            {0xcbf, new Tuple<int, CurrencyType>(800, CurrencyType.Fame)}, //rare mystery egg
            {0xcc0, new Tuple<int, CurrencyType>(1500, CurrencyType.Fame)}, //Legendary mystery egg
            {0xc6c, new Tuple<int, CurrencyType>(150, CurrencyType.Fame)}, //backpack

            //KEYS
            {0x2290, new Tuple<int, CurrencyType>(200, CurrencyType.Fame)}, //Bella's Key - just temporary for testing
            {0x7800, new Tuple<int, CurrencyType>(400, CurrencyType.Fame)}, //Mystery Box 3 Key - Mid of Nexus

            {0x701, new Tuple<int, CurrencyType>(75, CurrencyType.Fame)}, //Undead Lair Key
            {0x705, new Tuple<int, CurrencyType>(50, CurrencyType.Fame)}, //Pirate Cave Key
            {0x70a, new Tuple<int, CurrencyType>(75, CurrencyType.Fame)}, //Abyss of Demons Key
            {0x70b, new Tuple<int, CurrencyType>(50, CurrencyType.Fame)}, //Snake Pit Key
            {0x710, new Tuple<int, CurrencyType>(100, CurrencyType.Fame)}, //Tomb of the Ancients Key
            {0x71f, new Tuple<int, CurrencyType>(75, CurrencyType.Fame)}, //Sprite World Key
            {0xc11, new Tuple<int, CurrencyType>(100, CurrencyType.Fame)}, //Ocean Trench Key
            {0xc19, new Tuple<int, CurrencyType>(75, CurrencyType.Fame)}, //Totem Key
            {0xc23, new Tuple<int, CurrencyType>(100, CurrencyType.Fame)}, //Manor Key
            {0xc2e, new Tuple<int, CurrencyType>(100, CurrencyType.Fame)}, //Davy's Key
            {0xc2f, new Tuple<int, CurrencyType>(100, CurrencyType.Fame)}, //Lab Key
            {0xcce, new Tuple<int, CurrencyType>(125, CurrencyType.Fame)}, //Deadwater Docks Key
            {0xccf, new Tuple<int, CurrencyType>(125, CurrencyType.Fame)}, //Woodland Labyrinth Key
            {0xcda, new Tuple<int, CurrencyType>(125, CurrencyType.Fame)}, //The Crawling Depths Key
            {0xcdd, new Tuple<int, CurrencyType>(250, CurrencyType.Fame)}, //Shatters Key
            {0x748C, new Tuple<int, CurrencyType>(250, CurrencyType.Fame)}, //Ice Cave Key
            {0x6121, new Tuple<int, CurrencyType>(400, CurrencyType.Fame)}, //Reaper Key

            //FAME
            {0x10F, new Tuple<int, CurrencyType>(50, CurrencyType.Fame)}, //50 Fame
            {0x115, new Tuple<int, CurrencyType>(100, CurrencyType.Fame)}, //100 Fame
            {0x116, new Tuple<int, CurrencyType>(500, CurrencyType.Fame)}, //500 Fame
            {0x117, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //1000 Fame
            {0x118, new Tuple<int, CurrencyType>(5000, CurrencyType.Fame)}, //5000 Fame

            //SKINS
            {0x6703, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Mini Oryx Skin 1
            {0x6705, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Mini Thessal Skin 2
            {0x6707, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Mini Phylactery Skin 3
            {0x6709, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Baby Djinja Skin 4
            {0x6801, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Mini Rosen Skin 5
            {0x6803, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Mini Geb Skin 6
            {0x6805, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Mini Skuld Skin 7
            {0x6807, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Mini Archmage Skin 8 
            {0x6809, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Mini Swoll Skin 9
            {0x6011, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Slurp Knight Skin 10 
            {0x6513, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Vampire Lord Skin 11
            {0x6515, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Headless Rider Skin 12
            {0x6517, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Pilgrim Father Skin 13
            {0x6519, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Pilgrim Mother Skin 14
            {0x6521, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Wizard Supreme Skin 15
            {0x6523, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Rudolph the Berzerk Skin 16
            {0x6525, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Miss Santa Skin 17
            {0x6527, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Snow Queen Skin 18
            {0x6529, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Dragon Tamer Skin 19
            {0x6531, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Inuit Skin 20
            {0x6533, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Snowcloaked Rogue Skin 21
            {0x6535, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Chinese Dress Trickster Skin 22
            {0x6537, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Penguin Knight Skin 23
            {0x6539, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Frimar Knight Skin 24
            {0x6541, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Frozen King Skin 25
            {0x6543, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Blizzard Sorcerer Skin 26
            {0x6545, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Ice King Priest Skin 27
            {0x6547, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Icicle Dial Mystic Skin 28
            {0x6549, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Yuki Onna Mystic Skin 29
            {0x6607, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Juliet Trickster Skin 30
            {0x6609, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Heartseeker Huntress Skin 31
            {0x6611, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Romeo Assassin Skin 32
            {0x6613, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Mardi Gras Sorcerer Skin 33
            {0x6615, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Carnivalmancer Skin 34
            {0x2adf, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Wind Flower Skin 35
            {0x2ae0, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Leprechaun Mystic Skin 36
            {0x2aed, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Mini Nut Arhcer Skin 37
            {0x2ae1, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Miss Shamrock Wizard Skin 38
            {0x2ae2, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Sheep Warrior Skin 39
            {0x2ae3, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Sheep Rogue Skin 40
            {0x2ae4, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Sheep Wizard Skin 41
            {0x2ae5, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Sheep Archer Skin 42
            {0x2ae6, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Sheep Priest Skin 43
            {0x2ae7, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Lil' Bo-Peep Mystic Skin 44
            {0x2ae8, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //The Flamingo Wizard Skin 45
            {0x2aea, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Dr. Spellbomb Skin 46
            {0x2ae9, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Mini Stheno Skin 47
            {0x2aeb, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Iron Maiden Skin 48
            {0x2aec, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Explorer Skin 49
            {0x4ad8, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Mystic Emeritus Skin 50
            {0x4ad9, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Silver Ninja Skin 51
            {0x4ada, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Woodland Huntress Skin 52
            {0x4adb, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Bunny Trickster Skin 53
            {0x4adc, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Shrine Priestess Skin 54
            {0x4add, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Red Outlaw Skin 55
            {0x4ade, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Shadow Mage Skin 56
            {0x4adf, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Shield Maiden Skin 57
            {0x4bb0, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Markswoman Huntress Skin 58
            {0x4bb1, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Elf Archer Skin 59
            {0x4bb2, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Ordinary Magician Skin 60
            {0x4bb3, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Heroic Knight Skin 61
            {0x4bb4, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Ancient Sorcerer Skin 62
            {0x4bb5, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Dark Elf Assassin Skin 63
            {0x4bba, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Cunning Sorcerer Skin 64
            {0x4bc3, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Beach Trickster Skin 65
            {0x4bc4, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Hula Mystic Skin 66
            {0x4bc5, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Redcoat Assassin Skin 67
            {0x4bc6, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Patriot Paladin Skin 68
            {0x4bc7, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Swimsuit Mystic Skin 69
            {0x4bc8, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Swimsuit Huntress Skin 70
            {0x4bc9, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Swimsuit Trickster Skin 71
            {0x4bca, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Slashing Beauty Ninja Skin 72
            {0x4bcd, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Sunflower Archer Skin 73
            {0x4bce, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Thief Queen Skin 74
            {0x4bd0, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Mini Queen Bee Huntress Skin 75
            {0x4bea, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Bard Preistess Skin 76
            {0x4beb, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Princess Warrior Skin 77
            {0x4bec, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Light Cavalry Warrior Skin 78
            {0x4bed, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Clockwork Mystic Skin 79
            {0x4bee, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Twilight Acolyte Rogue Skin 80
            {0x4bef, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Ethereal Princess Archer Skin 81
            {0x4bf0, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Antique Diver Knight Skin 82
            {0x4bf1, new Tuple<int, CurrencyType>(1000, CurrencyType.Fame)}, //Guerilla Archer Skin 83
        };

        //Mystery Box Key
        public static int[] store7List =
        {
            0x7800
        };

        //All Skins
        public static int[] store25List =
        {
            0x6703, 0x6705, 0x6707, 0x6709, 0x6801, 0x6803, 0x6805, 0x6807, 0x6809, 0x6011, 0x6513, 0x6515, 0x6517, 0x6519, 0x6521, 0x6523, 0x6525, 0x6527, 0x6529, 0x6531, 0x6533, 0x6535,
            0x6537, 0x6539, 0x6541, 0x6543, 0x6545, 0x6547, 0x6549, 0x6607, 0x6609, 0x6611, 0x6613, 0x6615, 0x2adf, 0x2ae0, 0x2aed, 0x2ae1, 0x2ae2, 0x2ae3, 0x2ae4, 0x2ae5, 0x2ae6, 0x2ae7,
            0x2ae8, 0x2aea, 0x2ae9, 0x2aeb, 0x2aec, 0x4ad8, 0x4ad9, 0x4ada, 0x4adb, 0x4adc, 0x4add, 0x4ade, 0x4adf, 0x4bb0, 0x4bb1, 0x4bb2, 0x4bb3, 0x4bb4, 0x4bb5, 0x4bba, 0x4bc3, 0x4bc4,
            0x4bc5, 0x4bc6, 0x4bc7, 0x4bc8, 0x4bc9, 0x4bca, 0x4bcd, 0x4bce, 0x4bd0, 0x4bea, 0x4beb, 0x4bec, 0x4bed, 0x4bee, 0x4bef, 0x4bf0, 0x4bf1
        };

        //Keys need to add etcetc
        public static int[] store1List =
        {
            0x2290, 0x701, 0x705, 0x70a, 0x70b, 0x710, 0x71f, 0xc11, 0xc19, 0xc23, 0xc2e, 0xc2f, 0xcce, 0xccf, 0xcda, 0xcdd, 0x748c, 0x6121
        };

        //Pet eggs
        public static int[] store2List =
        {
            0xc87, 0xc8b, 0xc8f, 0xc93, 0xc97, 0xc9b, 0xc9f, 0xca3, 0xca7, 0xcab, 0xcaf, 0xcb3, 0xcb7, 0xcbb, 0xcbf, 0xcc0, 0xc6c
        };

        //Pet food
        public static int[] store3List = {
            0xccc, 0xccb, 0xcca, 0xcc9, 0xcc8, 0xcc7, 0xcc6, 0xcc5, 0xcc4
        };

        //Abilites
        public static int[] store4List =
        {
            0xb25, 0xb22, 0xb24, 0xb26, 0xb27, 0xb28, 0xb29, 0xb2a, 0xb2b, 0xb2c, 0xb2d, 0xb23, 0xb33, 0xc59
        };

        //Armor
        public static int[] store5List =
        {
            0xb05, 0xa96, 0xa95, 0xafc, 0xa93, 0xa92, 0xaf9, 0xa90, 0xa8f
        };

        //Wands&staves&bows
        public static int[] store6List =
        {
            0xaf6, 0xa87, 0xb02, 0xa8d, 0xb08, 0xaa2, 0xb0b, 0xa47, 0xaff, 0xa8a, 0xc50, 0xc4f
        };

        //Rings
        public static int[] store8List =
        {
            0xba3, 0xba4, 0xba5, 0xba6, 0xba7, 0xba8, 0xba9, 0xbaa, 0xac7, 0xac8, 0xac9, 0xaca, 0xacb, 0xacc, 0xacd, 0xace
        };



        ////fame
        //public static int[] store9list =
        //{
        //    0x10f, 0x115, 0x116, 0x117, 0x118
        //};

        ////50 Fame
        //public static int[] storefame1List =
        //{
        //    0x10F
        //};

        ////100 Fame
        //public static int[] storefame2List =
        //{
        //    0x115
        //};

        ////500 Fame
        //public static int[] storefame3List =
        //{
        //    0x116
        //};

        ////1000 Fame
        //public static int[] storefame4List =
        //{
        //    0x117
        //};

        //public static int[] storefame5List =
        //{
        //    0x118
        //};



        private static readonly ILog log = LogManager.GetLogger(typeof(MerchantLists));

        public static void InitMerchatLists(XmlData data)
        {
            log.Info("Loading merchant lists...");
            List<int> accessoryDyeList = new List<int>();
            List<int> clothingDyeList = new List<int>();
            List<int> accessoryClothList = new List<int>();
            List<int> clothingClothList = new List<int>();

            foreach (KeyValuePair<ushort, Item> item in data.Items.Where(_ => noShopCloths.All(i => i != _.Value.ObjectId)))
            {
                if (item.Value.Texture1 != 0 && item.Value.ObjectId.Contains("Clothing") && item.Value.Class == "Dye")
                {
                    prices.Add(item.Value.ObjectType, new Tuple<int, CurrencyType>(51, CurrencyType.Fame));
                    clothingDyeList.Add(item.Value.ObjectType);
                }

                if (item.Value.Texture2 != 0 && item.Value.ObjectId.Contains("Accessory") && item.Value.Class == "Dye")
                {
                    prices.Add(item.Value.ObjectType, new Tuple<int, CurrencyType>(51, CurrencyType.Fame));
                    accessoryDyeList.Add(item.Value.ObjectType);
                }

                if (item.Value.Texture1 != 0 && item.Value.ObjectId.Contains("Cloth") &&
                    item.Value.ObjectId.Contains("Large"))
                {
                    prices.Add(item.Value.ObjectType, new Tuple<int, CurrencyType>(160, CurrencyType.Fame));
                    clothingClothList.Add(item.Value.ObjectType);
                }

                if (item.Value.Texture2 != 0 && item.Value.ObjectId.Contains("Cloth") &&
                    item.Value.ObjectId.Contains("Small"))
                {
                    prices.Add(item.Value.ObjectType, new Tuple<int, CurrencyType>(160, CurrencyType.Fame));
                    accessoryClothList.Add(item.Value.ObjectType);
                }
            }

            ClothingDyeList = clothingDyeList.ToArray();
            ClothingClothList = clothingClothList.ToArray();
            AccessoryClothList = accessoryClothList.ToArray();
            AccessoryDyeList = accessoryDyeList.ToArray();
            log.Info("Merchat lists added.");
        }

        private static readonly string[] noShopCloths =
        {
            "Large Ivory Dragon Scale Cloth", "Small Ivory Dragon Scale Cloth",
            "Large Green Dragon Scale Cloth", "Small Green Dragon Scale Cloth",
            "Large Midnight Dragon Scale Cloth", "Small Midnight Dragon Scale Cloth",
            "Large Blue Dragon Scale Cloth", "Small Blue Dragon Scale Cloth",
            "Large Red Dragon Scale Cloth", "Small Red Dragon Scale Cloth",
            "Large Jester Argyle Cloth", "Small Jester Argyle Cloth",
            "Large Alchemist Cloth", "Small Alchemist Cloth",
            "Large Mosaic Cloth", "Small Mosaic Cloth",
            "Large Spooky Cloth", "Small Spooky Cloth",
            "Large Flame Cloth", "Small Flame Cloth",
            "Large Heavy Chainmail Cloth", "Small Heavy Chainmail Cloth",
        };
    }
}