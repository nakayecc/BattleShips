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

        public void ChangeSquare(Square square, int squareIndex)
        {
            GameBoard.Board[squareIndex] = square;
        }

    }
}