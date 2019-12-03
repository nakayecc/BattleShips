namespace Server.Models.Board
{
    public class Square
    { 
        public Coordinates Coordinates { get; set; }
        public FieldType fieldType { get; set; }

        public Square(int row, int column)
        {
            this.Coordinates = new Coordinates(row, column);
            this.fieldType = FieldType.Empty;
        }


        public bool IsOccupied()
        {
            return
                fieldType == FieldType.Ship;
        }

    }
}