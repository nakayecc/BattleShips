using System.Collections.Generic;
using Server.Models.Board;

namespace Server.Models.Ships
{
    public class Cruiser : Ship
    {
        public string Name = "Cruiser";
        public Cruiser(List<Square> field) : base(field)
        {
        }
    }
}