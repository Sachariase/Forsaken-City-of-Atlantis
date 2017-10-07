using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wServer.realm.worlds
{
    public class MysteryBox : World
    {
        public MysteryBox()
        {
            Name = "Mystery Box";
            ClientWorldName = "Mystery Box";
            Background = 0;
            Difficulty = 1;
            AllowTeleport = true;
        }

        protected override void Init()
        {
            LoadMap("wServer.realm.worlds.maps.MysteryBox.jm", MapType.Json);
        }
    }
}
