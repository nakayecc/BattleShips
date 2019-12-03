using BattleShip.Models.Board;

namespace BattleShip.Models.Ships
{
    public class Battleship : Ship
    {
        public Battleship(int id)
        {
            this.Id = id;
            OcuOccupationTypeField = OccupationTypeField.Battleship;
            Name = "Battleship";
            Size = 4;
        }
    }
}