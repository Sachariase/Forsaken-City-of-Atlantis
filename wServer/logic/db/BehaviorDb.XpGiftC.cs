using wServer.logic.behaviors;
using wServer.logic.transitions;
using wServer.logic.loot;

namespace wServer.logic
{
    partial class BehaviorDb
    {
        private _ XPGiftC = () => Behav()
            .Init("XP Gift C",
                new State(
                    new PlayerWithinTransition(15, "player_nearby"),
                    new State("player_nearby",
                        new Prioritize(
                            new StayCloseToSpawn(0.5, 6),
                            new Wander(0.5)
                            ),
                        new Taunt(0.001, 1000, "Cluck", "Cluck Cluck")
                        )
                    ),
                new Threshold(0.1,
                    new ItemLoot("Sword of the Mad God", 0.09),
                    new ItemLoot("Onyx Shield of the Mad God", 0.09),
                    new ItemLoot("Almandine Armor of Anger", 0.09),
                    new ItemLoot("Almandine Ring of Wrath", 0.09),
                    new ItemLoot("Wine Cellar Incantation", 0.01),
                    new TierLoot(9, ItemType.Weapon, 0.5),
                    new TierLoot(9, ItemType.Weapon, 0.4),
                    new TierLoot(10, ItemType.Weapon, 0.3),
                    new TierLoot(11, ItemType.Weapon, 0.2),
                    new TierLoot(8, ItemType.Armor, 0.5),
                    new TierLoot(9, ItemType.Armor, 0.4),
                    new TierLoot(10, ItemType.Armor, 0.3),
                    new TierLoot(11, ItemType.Armor, 0.2),
                    new ItemLoot("Potion of Life", 1.00)
                    )
            );
    }
}