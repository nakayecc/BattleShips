using Server.Models.Board;

namespace Server.Services
{
    public class Board
    {

        public GameBoard GameBoard { get; set; }

        public void InitBoard()
        {
            this.GameBoard = new GameBoard();
        }

        public void ChangeSquare(FieldType field, int squareIndex)
        {
            GameBoard.Board[squareIndex -1].fieldType = GameBoard.Board[squareIndex -1].fieldType = field ;
        }

    }
}