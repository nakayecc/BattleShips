using BattleShip.Models.Board;

namespace BattleShip
{
    public class Ship
    {
        public OccupationTypeField OcuOccupationTypeField { get; set; }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Size { get; set; }
        public int Hit { get; set; }


        public bool IsSunk()
        {
            return Hit >= Size ? true : false;
        }

    }
}