using System.Collections.Generic;
using Server.Models.Board;

namespace Server.Models.Ships
{
    public class Carrier : Ship
    {
        public string Name = "Carrier";
        public Carrier(List<Square> field) : base(field)
        {
        }
    }
}