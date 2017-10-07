#region

using wServer.logic.behaviors;
using wServer.logic.loot;
using wServer.logic.transitions;
#endregion

namespace wServer.logic
{
    partial class BehaviorDb
    {
        private _ EpicTomb = () => Behav() //Idk xD Har du addet "epic bes"? Ikke selve xml.................flot
        .Init("Epic Bes",
                new State(
                    new State("idle",
                        new Taunt("THIS WILL NOW BE YOUR TOMB!"),
                        new ConditionalEffect(ConditionEffectIndex.Armored),
                        new Orbit(.6, 5, target: "Epic Tomb Boss Anchor", radiusVariance: 0.5),
                        new HpLessTransition(.99, "weakning")
                        ),
                    new State("weakning",
                        new Orbit(.6, 5, target: "Epic Tomb Boss Anchor", radiusVariance: 0.5),
                        new Taunt("Impudence! I am an immortal, I needn't take you seriously."),
                        new Shoot(50, 24, projectileIndex: 3, coolDown: 6000, coolDownOffset: 2000),
                        new HpLessTransition(.97, "active")
                        ),
                    new State("active",
                        new Orbit(.7, 5, target: "Epic Tomb Boss Anchor", radiusVariance: 0.5),
                        new Taunt("The others use tricks, but I shall stun you with my brute strength!"),
                        new Shoot(50, 8, projectileIndex: 2, coolDown: 1000, coolDownOffset: 500),
                        new Shoot(50, 4, projectileIndex: 1, coolDown: 3000, coolDownOffset: 500),
                        new Shoot(50, 6, projectileIndex: 0, coolDown: 3100, coolDownOffset: 500),
                        new HpLessTransition(.9, "boomerang")
                        ),
                    new State("boomerang",
                        new ConditionalEffect(ConditionEffectIndex.Armored),
                        new Orbit(.6, 5, target: "Epic Tomb Boss Anchor", radiusVariance: 0.5),
                        new Taunt("Nut, disable our foes!"),
                        new Shoot(50, 8, projectileIndex: 2, coolDown: 1000, coolDownOffset: 500),
                        new Shoot(50, 8, 10, 1, coolDown: 4750, coolDownOffset: 500),
                        new Shoot(50, 1, 10, 0, coolDown: 4750, coolDownOffset: 500),
                        new HpLessTransition(.66, "double shot")
                        ),
                    new State("double shot",
                        new ConditionalEffect(ConditionEffectIndex.Armored),
                        new Orbit(.7, 5, target: "Epic Tomb Boss Anchor", radiusVariance: 0.5),
                        new Shoot(50, 8, projectileIndex: 2, coolDown: 1000, coolDownOffset: 500),
                        new Shoot(50, 8, 10, 1, coolDown: 4750, coolDownOffset: 500),
                        new Shoot(50, 2, 10, 0, coolDown: 4750, coolDownOffset: 500),
                        new HpLessTransition(.5, "artifacts")
                        ),
                    new State("triple shot",
                        new ConditionalEffect(ConditionEffectIndex.Armored),
                        new Orbit(.6, 5, target: "Epic Tomb Boss Anchor", radiusVariance: 0.5),
                        new Taunt("Awe at my wondrous defense!"),
                        new Shoot(50, 8, projectileIndex: 2, coolDown: 1000, coolDownOffset: 500),
                        new Shoot(50, 8, 10, 1, coolDown: 4750, coolDownOffset: 500),
                        new Shoot(50, 3, 10, 0, coolDown: 4750, coolDownOffset: 500),
                        new HpLessTransition(.2, "rage")
                        ),
                    new State("artifacts",
                        new ConditionalEffect(ConditionEffectIndex.Armored),
                        new Taunt("My epic artifacts shall prove my wall of defense is impenetrable!"),
                        new Orbit(.6, 5, target: "Epic Tomb Boss Anchor", radiusVariance: 0.5),
                        new Shoot(50, 8, projectileIndex: 2, coolDown: 1000, coolDownOffset: 500),
                        new Shoot(50, 8, 10, 1, coolDown: 4750, coolDownOffset: 500),
                        new Shoot(50, 2, 10, 0, coolDown: 4750, coolDownOffset: 500),
                        new Spawn("Epic Pyramid Artifact 1", 3, 3, 2000),
                        new Reproduce("Epic Pyramid Artifact 1", 10, 3, 1500),
                        new Spawn("Epic Pyramid Artifact 2", 3, 0, 3500000),
                        new Reproduce("Epic Pyramid Artifact 2", 10, 3, 1500),
                        new Spawn("Epic Pyramid Artifact 3", 3, 0, 3500000),
                        new Reproduce("Epic Pyramid Artifact 3", 10, 3, 1500),
                        new HpLessTransition(.33, "triple shot")
                        ),
                    new State("rage",
                        new Taunt("The end of your path is here!"),
                        new Follow(1.3, range: 1, duration: 5000, coolDown: 0),
                        new Flash(0xfFF0000, 1, 9000001),
                        new Shoot(50, 8, 10, 1, coolDown: 4750, coolDownOffset: 500),
                        new Shoot(50, 4, 10, 4, coolDown: 300),
                        new Shoot(50, 3, 10, 0, coolDown: 4750, coolDownOffset: 500)
                        )
                    ),
                    new Threshold(0.32,
                        new ItemLoot("Potion of Life", 1)
                    ),
                    new Threshold(0.1,
                        new ItemLoot("Ring of the Pyramid", 0.2),
                        new ItemLoot("Tome of Holy Protection", 0.1),
                        new ItemLoot("Wine Cellar Incantation", 0.6)
                    ),
                    new Threshold(0.2
                    )
            )

        .Init("Epic Nut",
                new State(
                    new State("idle",
                        new Taunt("ENOUGH OF YOUR VANDALISM!"),
                        new ConditionalEffect(ConditionEffectIndex.Armored),
                        new Orbit(.6, 5, target: "Epic Tomb Boss Anchor", radiusVariance: 0.5),
                        new HpLessTransition(.99, "weakning")
                        ),
                    new State("weakning",
                        new Orbit(.6, 5, target: "Epic Tomb Boss Anchor", radiusVariance: 0.5),
                        new Taunt("Geb, eradicate these cretins from our tomb!"),
                        new Shoot(50, 24, projectileIndex: 3, coolDown: 6000, coolDownOffset: 2000),
                        new HpLessTransition(.97, "active")
                        ),
                    new State("active",
                        new Orbit(.7, 5, target: "Epic Tomb Boss Anchor", radiusVariance: 0.5),
                        new Taunt("Bes, become my wall of defense!"),
                        new Shoot(50, 1, projectileIndex: 6, coolDown: 8000, shootAngle: 10, coolDownOffset: 500),
                        new Shoot(50, 1, projectileIndex: 5, coolDown: 5000, coolDownOffset: 3000),
                        new Shoot(50, 1, projectileIndex: 5, coolDown: 6000, coolDownOffset: 4000),
                        new HpLessTransition(.9, "boomerang")
                        ),
                    new State("boomerang",
                        new ConditionalEffect(ConditionEffectIndex.Armored),
                        new Taunt("My attacks shall make your lethargic lives end much more switfly!"),
                        new Orbit(.6, 5, target: "Epic Tomb Boss Anchor", radiusVariance: 0.5),
                        new Shoot(50, 4, projectileIndex: 2, coolDown: 3000, coolDownOffset: 1000),
                        new Shoot(50, 5, projectileIndex: 3, coolDown: 4000, coolDownOffset: 3000),
                        new Shoot(50, 5, projectileIndex: 4, coolDown: 5000, coolDownOffset: 5000),
                        new Shoot(50, 6, projectileIndex: 3, coolDown: 4000, coolDownOffset: 3000),
                        new HpLessTransition(.2, "rage")
                        ),
                    new State("rage",
                        new Taunt("This cannot be! You shall not succeed!"),

                        new Follow(1.3, range: 1, duration: 5000, coolDown: 0),
                        new Flash(0xfFF0000, 1, 9000001),
                        new Shoot(50, 3, projectileIndex: 2, coolDown: 3000, coolDownOffset: 1000),
                        new Shoot(50, 6, projectileIndex: 3, coolDown: 4000, coolDownOffset: 3000),
                        new Shoot(50, 3, projectileIndex: 2, coolDown: 3000, coolDownOffset: 1000),
                        new InvisiToss("Scarab", 1, 0, coolDown: 1500),
                        new Shoot(50, 8, 10, 1, coolDown: 4750, coolDownOffset: 500),
                        new Shoot(50, 4, 10, 4, coolDown: 300),
                        new Shoot(50, 3, 10, 0, coolDown: 4750, coolDownOffset: 500),
                        new Shoot(50, 6, projectileIndex: 4, coolDown: 4000, coolDownOffset: 2500),
                        new Shoot(50, 4, projectileIndex: 4, coolDown: 5000, coolDownOffset: 5000) //,
                        )
                    ),
                    new Threshold(0.32,
                        new ItemLoot("Potion of Life", 1)
                    ),
                    new Threshold(0.1,
                        new ItemLoot("Ring of the Sphinx", 0.2),
                        new ItemLoot("Wine Cellar Incantation", 0.6)
                    //new ItemLoot("Legendary Food", 0.09),
                    ),
                    new Threshold(0.2
                    )
            )

            .Init("Epic Geb",
                new State(
                    new State("idle",
                        new Taunt("YOU HAVE AWAKENED US"),
                        new ConditionalEffect(ConditionEffectIndex.Armored),
                        new Orbit(.6, 5, target: "Epic Tomb Boss Anchor", radiusVariance: 0.5),
                        new HpLessTransition(.99, "weakning")
                        ),
                    new State("weakning",
                        new Orbit(.6, 5, target: "Epic Tomb Boss Anchor", radiusVariance: 0.5),
                        new Taunt("Geb, eradicate these cretins from our tomb!"),
                        new Shoot(50, 24, projectileIndex: 3, coolDown: 6000, coolDownOffset: 2000),
                        new HpLessTransition(.97, "active")
                        ),

                    new State("active",
                        new Orbit(.6, 5, target: "Epic Tomb Boss Anchor", radiusVariance: 0.5),
                        new Taunt("I shall destroy you from your soul to your flesh!"),
                        new Shoot(50, 2, projectileIndex: 2, coolDown: 1900, coolDownOffset: 2000),
                        new Shoot(50, 6, projectileIndex: 0, coolDown: 1250, coolDownOffset: 1500),
                        new Shoot(50, 6, projectileIndex: 0, coolDown: 1250, coolDownOffset: 1500),
                        new Shoot(50, 12, projectileIndex: 2, coolDown: 2500, coolDownOffset: 2000),
                        new HpLessTransition(.2, "rage")
                    ),

                    new State("rage",
                        new Taunt("Argh! You shall pay for your crimes!"),

                        new Follow(1.3, range: 1, duration: 5000, coolDown: 0),
                        new Flash(0xfFF0000, 1, 9000001),
                        new Shoot(50, 24, projectileIndex: 0, coolDown: 2500, coolDownOffset: 2500),
                        new Shoot(50, 24, projectileIndex: 0, coolDown: 2500, coolDownOffset: 2500),
                        new Shoot(50, 8, 10, 1, coolDown: 4750, coolDownOffset: 500),
                        new Shoot(50, 4, 10, 4, coolDown: 300),
                        new Shoot(50, 3, 10, 0, coolDown: 4750, coolDownOffset: 500),
                        new Shoot(50, 6, projectileIndex: 2, coolDown: 3100, coolDownOffset: 2000),
                        new Shoot(50, 3, projectileIndex: 1, coolDown: 1500, coolDownOffset: 2000)
                    )
                ),
                new Threshold(0.32,
                        new ItemLoot("Potion of Life", 3)
                ),
                new Threshold(0.1,
                    new ItemLoot("Ring of the Nile", 0.02),
                    new ItemLoot("Wine Cellar Incantation", 0.06)
                //new ItemLoot("Legendary Food", 0.09),
                ),
                new Threshold(0.2
                )
            )

        //Minions
        //.Init("Epic Pyramid Artifact 1",
        //    new State(
        //        new Prioritize(
        //            new Orbit(1, 2, target: "Epic Bes", radiusVariance: 0.5),
        //            new Follow(0.85, range: 1, duration: 5000, coolDown: 0)
        //            ),
        //        new Shoot(3, coolDown: 2500)
        //        ))

        //.Init("Epic Pyramid Artifact 2",
        //    new State(
        //        new Prioritize(
        //            new Orbit(1, 2, target: "Epic Geb", radiusVariance: 0.5),
        //            new Follow(0.85, range: 1, duration: 5000, coolDown: 0)
        //            ),
        //        new Shoot(3, coolDown: 2500)
        //        ))

        //.Init("Epic Pyramid Artifact 3",
        //    new State(
        //        new Prioritize(
        //            new Orbit(1, 2, target: "Epic Nut", radiusVariance: 0.5),
        //            new Follow(0.85, range: 1, duration: 5000, coolDown: 0)
        //            ),
        //        new Shoot(3, coolDown: 2500)
        //        ))





        .Init("Epic Pyramid Artifact 1",
              new State(
                 new Prioritize(
                    new Orbit(1, 3, 30, "Epic Bes")
                 ),
                    new Shoot(4, count: 1, shootAngle: 12, coolDown: 1000)
                 )
                 )
                        .Init("Epic Pyramid Artifact 2",
                                new State(
                                        new State("Normal",
                                                new Prioritize(
                                                        new Orbit(1, 3, 30, "Epic Nut")
                                                ),
                                                new Shoot(4, count: 1, shootAngle: 12, coolDown: 1000),
                                                new EntityNotExistsTransition("Epic Nut", 50, "Attacker Exist?")
                                        ),
                                        new State("Attacker Exist?",
                                                new Prioritize(
                                                        new Orbit(1, 3, 30, "Epic Geb")
                                                ),
                                                new Shoot(4, count: 1, shootAngle: 12, coolDown: 1000),
                                                new EntityNotExistsTransition("Epic Geb", 50, "Suicide")
                                        ),
                                        new State("Suicide",
                                                new Suicide()
                                        )
                                )
                        )

        .Init("Epic Pyramid Artifact 3",
              new State(
                                        new State("Normal",
                                new Prioritize(
                             new Orbit(1, 3, 30, "Epic Geb")
                            ),
                                 new Shoot(4, count: 1, shootAngle: 12, coolDown: 1000),
                                                new EntityNotExistsTransition("Epic Geb", 50, "Support Exist?")
                                        ),
                                        new State("Support Exist?",
                                                new Prioritize(
                                                        new Orbit(1, 3, 30, "Epic Nut")
                                                ),
                                                new Shoot(4, count: 1, shootAngle: 12, coolDown: 1000),
                                                new EntityNotExistsTransition("Epic Nut", 50, "Suicide")
                                        ),
                                                new State("Suicide",
                                                new Suicide()
                 )
                                )
                        )




            .Init("Epic Bes Statue",
                new State(
                    new State(
                        new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                        new EntityNotExistsTransition("Epic Inactive Sarcophagus", 1000, "checkActive"),
                        new EntityNotExistsTransition("Epic Active Sarcophagus", 1000, "checkInactive")
                        ),
                    new State("checkActive",
                        new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                        new EntityNotExistsTransition("Epic Active Sarcophagus", 1000, "ItsGoTime")
                        ),
                    new State("checkInactive",
                        new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                        new EntityNotExistsTransition("Epic Inactive Sarcophagus", 1000, "ItsGoTime")
                        ),
                    new State("ItsGoTime",
                        new Transform("Epic Bes")
                        )
                    ))

            .Init("Epic Nut Statue",
                new State(
                    new State(
                        new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                        new EntityNotExistsTransition("Epic Inactive Sarcophagus", 1000, "checkActive"),
                        new EntityNotExistsTransition("Epic Active Sarcophagus", 1000, "checkInactive")
                        ),
                    new State("checkActive",
                        new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                        new EntityNotExistsTransition("Epic Active Sarcophagus", 1000, "ItsGoTime")
                        ),
                    new State("checkInactive",
                        new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                        new EntityNotExistsTransition("Epic Inactive Sarcophagus", 1000, "ItsGoTime")
                        ),
                    new State("ItsGoTime",
                        new Transform("Epic Nut")
                        )
                    ))

            .Init("Epic Geb Statue",
                new State(
                    new State(
                        new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                        new EntityNotExistsTransition("Epic Inactive Sarcophagus", 1000, "checkActive"),
                        new EntityNotExistsTransition("Epic Active Sarcophagus", 1000, "checkInactive")
                        ),
                    new State("checkActive",
                        new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                        new EntityNotExistsTransition("Epic Active Sarcophagus", 1000, "ItsGoTime")
                        ),
                    new State("checkInactive",
                        new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                        new EntityNotExistsTransition("Epic Inactive Sarcophagus", 1000, "ItsGoTime")
                        ),
                    new State("ItsGoTime",
                        new Transform("Epic Geb")
                        )
                    ))

        .Init("Epic Inactive Sarcophagus",
                new State(
                    new State("activate",
                        new Transform("Epic Active Sarcophagus")
                        )
                    ))

            .Init("Epic Scarab",
                new State(
                    new NoPlayerWithinTransition(7, "Idle"),
                    new PlayerWithinTransition(7, "Chase"),
                    new State("Idle",
                        new Wander(.1)
                    ),
                    new State("Chase",
                        new Follow(1.5, 7, 0),
                        new Shoot(3, projectileIndex: 1, coolDown: 500)
                    )
                )
                )

        .Init("Epic Active Sarcophagus",
                new State(
                    new State(
                        new HpLessTransition(95, "stun")
                        ),
                    new State("stun",
                        new Shoot(50, 8, 10, 0, coolDown: 1250, coolDownOffset: 500),
                        new Shoot(50, 8, 10, 0, coolDown: 1500, coolDownOffset: 1000),
                        new Shoot(50, 8, 10, 0, coolDown: 1750, coolDownOffset: 1500),
                        new TimedTransition(1500, "idle")
                        ),
                    new State("idle",
                        new ChangeSize(100, 100)
                        )
                    ),

                    new Threshold(0.32,
                        new ItemLoot("Tincture of Mana", 0.15),
                        new ItemLoot("Tincture of Dexterity", 0.15),
                        new ItemLoot("Tincture of Life", 0.15)
                    ),
                    new Threshold(0.2
                    )
            )

        .Init("Tomb Spawn Bridge",
            new State(
                new State("Idle",
                    new ConditionalEffect(ConditionEffectIndex.Invincible, true),
                    new EntityNotExistsTransition("Epic Active Sarcophagus", 500, "Open")
                    ),
                new State("Open",
                    new ChangeGroundOnDeath(new[] { "Black" }, new[] { "Sandstone Tile" },
                        1),
                    new Suicide()
                    )
                )
            )

        .Init("Tomb Remove Wall",
                new State(
                    new State("Idle",
                        new EntityNotExistsTransition("Epic Active Sarcophagus", 60, "Despawn")
                        ),
                    new State("Despawn",
                        new Decay(0)
                        )
                    )
            )

            .Init("Epic Tomb Boss Anchor",
                new State(
                    new ConditionalEffect(ConditionEffectIndex.Invincible, true),
                    new RealmPortalDrop(),
                    new State("Idle",
                        new EntitiesNotExistsTransition(300, "Death", "Epic Nut", "Epic Geb", "Epic Bes",
                            "Epic Active Sarcophagus", "Epic Bes Statue", "Epic Nut Statue", "Epic Geb Statue")
                    ),
                    new State("Death",
                        new RemoveEntity(10, "Tomb Portal of Cowardice"),
                        new Suicide()
                    )
                )

            );
    }
}