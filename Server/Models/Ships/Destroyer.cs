using System.Collections.Generic;
using Server.Models.Board;

namespace Server.Models.Ships
{
    public class Destroyer : Ship
    {
        public string Name = "Destroyer";
        public Destroyer(List<Square> field) : base(field)
        {
        }
    }
}