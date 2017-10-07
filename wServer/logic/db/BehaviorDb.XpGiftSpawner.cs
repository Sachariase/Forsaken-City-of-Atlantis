using wServer.logic.behaviors;
using wServer.logic.transitions;
using wServer.logic.loot;

namespace wServer.logic
{
    partial class BehaviorDb
    {
        private _ XPGiftSpawner = () => Behav()
        .Init("XP Gift Spawner",
            new State(
                new ConditionalEffect(ConditionEffectIndex.Invincible),
                new State("Idle",
                    new PlayerWithinTransition(10, "spawn")
                    ),
                new State("spawn",
                    new Spawn("XP Gift C", 3, coolDown: 2000),
                    new TimedTransition(3500, "spawn2")
                    ),
                new State("spawn2",
                    new Spawn("XP Gift C", 3, coolDown: 2000),
                    new TimedTransition(3500, "spawn")
            )
         )
    );
    }
}