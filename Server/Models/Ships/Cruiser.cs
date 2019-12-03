
using BattleShip.Models.Board;

namespace BattleShip.Models.Ships
{
    public class Cruiser : Ship
    {
        public Cruiser(int id)
        {
            this.Id = id;
            OcuOccupationTypeField = OccupationTypeField.Cruiser;
            Name = "Cruiser";
            Size = 3;
        }
    }
}