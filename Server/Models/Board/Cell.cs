namespace BattleShip.Models.Board
{
    public class Cell
    { 
        public Coordinates Coordinates { get; set; }
        public OccupationTypeField OccupationTypeField { get; set; }

        public Cell(int row, int column)
        {
            this.Coordinates = new Coordinates(row, column);
            this.OccupationTypeField = OccupationTypeField.Empty;
        }


        public bool IsOccupied()
        {
            return
                OccupationTypeField == OccupationTypeField.Destroyer ||
                OccupationTypeField == OccupationTypeField.Aircraft ||
                OccupationTypeField == OccupationTypeField.Battleship ||
                OccupationTypeField == OccupationTypeField.Cruiser ||
                OccupationTypeField == OccupationTypeField.Submarine;
        }

    }
}