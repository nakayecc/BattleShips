using System;

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

        public bool IsNeighbour(Square square)
        {
            int horizontalDistance = Math.Abs(Coordinates.Column - square.Coordinates.Column);
            int verticalDistance = Math.Abs(Coordinates.Row - square.Coordinates.Row);
            bool leftRighNeighbour = (horizontalDistance + verticalDistance == 1);
            bool obliqueNeighbour = horizontalDistance == 1 && verticalDistance == 1;
            
            return leftRighNeighbour || obliqueNeighbour;
            
        }

    }
}