using System.Collections.Generic;
using System.Linq;

namespace Server.Models.Ships
{
    public class Fleet
    {
        public List<Ship> Ships { get; }

        public bool IsDestroyed()
        {
            return Ships.Count == Ships.Count(ship => ship.IsDestroyed);
        }
    }
}