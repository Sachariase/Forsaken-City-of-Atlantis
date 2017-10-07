using System.Threading;
using System.Threading.Tasks;
using DungeonGenerator;
using DungeonGenerator.Templates.Abyss;
using wServer.networking;

namespace wServer.realm.worlds
{
    public class AbyssofDemons : World
    {
        public AbyssofDemons()
        {
            Name = "Abyss of Demons";
            ClientWorldName = "{dungeons.Abyss_of_Demons}";
            Dungeon = true;
            Background = 0;
            Difficulty = 2;
            AllowTeleport = true;
        }

        protected override void Init()
        {
            LoadMap("wServer.realm.worlds.maps.abyss.jm", MapType.Json);
        }
    }
}