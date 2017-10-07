using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using wServer.realm;
using wServer.logic.behaviors;
using wServer.logic.loot;
using wServer.logic.transitions;

namespace wServer.logic
{
    partial class BehaviorDb
    {
        _ New = () => Behav()
        //Credits to Sachariase for this behavior!
                        .Init("Big Reaper Minion",
                new State(
                    new State("active",
                          new Orbit(0.3, 2, 10, "The Grim Reaper"),
                        new PlayerWithinTransition(11, "shoot")
                    ),
                    new Orbit(0.3, 2, 10, "The Grim Reaper"),
                    new State("shoot",
                    new Shoot(15, 3, projectileIndex: 0, shootAngle: 15, coolDown: 100, predictive: 0)
                    )
                )
            )
                .Init("Reaper Minion",
                new State(
                    new State("active",
                        new Follow(1.3, range: 0),
                        new PlayerWithinTransition(2, "explode")
                    ),
                    new State("explode",
                    new Shoot(2, 24, projectileIndex: 0, shootAngle: 15, coolDown: 0, predictive: 0),
                        new Suicide()
                    )
                )
            )
               .Init("Small Reaper Minion",
                new State(
                    new State("active",
                        new Follow(0.8, range: 1),
                        new PlayerWithinTransition(2, "explode")
                    ),
                    new State("explode",
                    new Shoot(10, 1, projectileIndex: 1, shootAngle: 45, coolDown: 150, predictive: 1),
                    new Shoot(10, 2, projectileIndex: 0, shootAngle: 90, coolDown: 100, predictive: 1),
                    new Follow(0.8, range: 1)

                    )
                )
            )
               .Init("Small Reaper Minion 1",
                new State(
                    new State("active",
                        new Follow(0.8, range: 1),
                        new PlayerWithinTransition(2, "explode")
                    ),
                    new State("explode",
                    new Shoot(10, 1, projectileIndex: 1, shootAngle: 45, coolDown: 150, predictive: 1),
                    new Shoot(10, 2, projectileIndex: 0, shootAngle: 90, coolDown: 100, predictive: 1),
                    new Follow(0.8, range: 1)

                    )
                )
            )
               .Init("Small Reaper Minion 2",
                new State(
                    new State("active",
                        new Follow(0.8, range: 1),
                        new PlayerWithinTransition(2, "explode")
                    ),
                    new State("explode",
                    new Shoot(10, 1, projectileIndex: 1, shootAngle: 45, coolDown: 150, predictive: 1),
                    new Shoot(10, 2, projectileIndex: 0, shootAngle: 90, coolDown: 100, predictive: 1),
                    new Follow(0.8, range: 1)

                    )
                )
            )
             .Init("Reaper Anchor",
            new State(
                new ConditionalEffect(ConditionEffectIndex.Invincible)
                )
                )
                .Init("Reaper Chest",
                new State(
                    new State("Idle",
                        new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                        new TimedTransition(5000, "UnsetEffect")
                    ),
                    new State("UnsetEffect")
                ),
                new Threshold(0.1,
                    new TierLoot(12, ItemType.Weapon, 0.08),
                    new TierLoot(11, ItemType.Weapon, 0.09),
                    new TierLoot(6, ItemType.Ability, 0.08),
                    new TierLoot(5, ItemType.Ability, 0.09),
                    new TierLoot(13, ItemType.Armor, 0.08),
                    new TierLoot(12, ItemType.Armor, 0.09),
                    new TierLoot(6, ItemType.Ring, 0.08),
                    new TierLoot(5, ItemType.Ring, 0.09),
                    new ItemLoot("Potion of Life", 1.00),
                    new ItemLoot("Scythe of the Grim", 0.005),
                    new ItemLoot("Spell of the Grim", 0.005),
                    new ItemLoot("Robe of the Grim", 0.005),
                    new ItemLoot("Amulet of the Grim", 0.005),
                    new ItemLoot("50 Fame", 0.05),
                    new ItemLoot("100 Fame", 0.04),
                    new ItemLoot("500 Fame", 0.03),
                    new ItemLoot("1000 Fame", 0.02),
                    new ItemLoot("5000 Fame", 0.01)
                )
                    )

            .Init("The Grim Reaper",
                new State(
                    new TransformOnDeath("Reaper Chest", returnToSpawn: true),
                    new CopyDamageOnDeath("Reaper Chest"),
                    new HpLessTransition(0.7, "HALP!"),
                    new State("Idle",
                    new Prioritize(
                    new Follow(0.8, range: 1)
                        ),
                    new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                    new PlayerWithinTransition(20, "Attacking")
                        ),
                    new State("Attacking",
                    new Taunt("Ayy, I am going to take your soul and then i'll reap your sister."),
                    new State("Bullet",
                    new Spawn("Reaper Minion", maxChildren: 100, initialSpawn: 0, coolDown: 1000),
                    new Spawn("Reaper Minion", maxChildren: 100, initialSpawn: 0, coolDown: 1300),
                    new Spawn("Reaper Minion", maxChildren: 100, initialSpawn: 0, coolDown: 1600),
                    new Shoot(10, 8, projectileIndex: 0, shootAngle: 45, coolDown: 150, predictive: 0),
                    new Shoot(10, 1, projectileIndex: 0, coolDown: 50, predictive: 1),
                    new Grenade(3, 100, 10, coolDown: 190),
                    new Follow(0.8, range: 3)
                        ),
                    new State("HALP!",
                    new ConditionalEffect(ConditionEffectIndex.Armored),
                    new Spawn("Reaper Minion", maxChildren: 100, initialSpawn: 0, coolDown: 1000),
                    new Spawn("Reaper Minion", maxChildren: 100, initialSpawn: 0, coolDown: 1300),
                    new Spawn("Reaper Minion", maxChildren: 100, initialSpawn: 0, coolDown: 1600),
                    new Spawn("Big Reaper Minion", maxChildren: 5, initialSpawn: 0, coolDown: 1000),
                    new Follow(0.8, range: 1),
                    new HpLessTransition(0.4, "Rage")
                        ),
                    new State("Rage",
                    new StayBack(1.8, 9),
                    new Spawn("Reaper Minion", maxChildren: 100, initialSpawn: 0, coolDown: 1000),
                    new Spawn("Reaper Minion", maxChildren: 100, initialSpawn: 0, coolDown: 1300),
                    new Spawn("Reaper Minion", maxChildren: 100, initialSpawn: 0, coolDown: 1600),
                    new Shoot(10, 8, projectileIndex: 0, shootAngle: 45, coolDown: 150, predictive: 1),
                    new Shoot(10, 8, projectileIndex: 0, shootAngle: 90, coolDown: 100, predictive: 1),
                    new Follow(0.8, range: 1)
                        ),
                    new NoPlayerWithinTransition(20, "Idle")
                        )
                    )
            );

    }
}