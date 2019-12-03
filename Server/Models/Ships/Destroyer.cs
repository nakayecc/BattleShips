using BattleShip.Models.Board;

namespace BattleShip.Models.Ships
{
    public class Destroyer : Ship
    {
        public Destroyer(int id)
        {
            this.Id = id;
            OcuOccupationTypeField = OccupationTypeField.Destroyer;
            Name = "Destroyer";
            Size = 2;
        }
    }
}