using BattleShip.Models.Board;

namespace BattleShip.Models.Ships
{
    public class Submarine : Ship
    {
        public Submarine(int id)
        {
            this.Id = id;
            OcuOccupationTypeField = OccupationTypeField.Submarine;
            Name = "Submarine";
            Size = 3;
        }
    }
}