using System.Collections.Generic;
using Server.Models.Board;

namespace Server.Models.Ships
{
    public class Battleship : Ship
    {
        public string Name = "Battleship";
        public Battleship(List<Square> field) : base(field)
        {
        }
    }
}