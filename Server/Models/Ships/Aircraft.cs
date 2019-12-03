using BattleShip.Models.Board;

namespace BattleShip.Models.Ships
{
    public class Aircraft : Ship
    {
        public Aircraft(int id)
        {
            this.Id = id;
            Name = "Aircraft Cruiser";
            Size = 5;
            OcuOccupationTypeField = OccupationTypeField.Aircraft;
        }
    }
}