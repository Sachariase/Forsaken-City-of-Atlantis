using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wServer.realm.worlds
{
    public class EpicTomboftheAncients : World
    {
        public EpicTomboftheAncients()
        {
            Name = "Epic Tomb of the Ancients";
            ClientWorldName = "Epic Tomb of the Ancients";
            Background = 0;
            Difficulty = 5;
            AllowTeleport = true;
        }

        protected override void Init()
        {
            LoadMap("wServer.realm.worlds.maps.EpicTomb1.jm", MapType.Json);
        }
    }
}
