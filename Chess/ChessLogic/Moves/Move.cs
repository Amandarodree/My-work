//AMANDA NZEKWESI
namespace ChessLogic
{
    public abstract class Move
    {
        //Properties
        public abstract MoveType Type { get; }
        public abstract Position FromPos { get; }   
        public abstract Position ToPos { get; }
        public abstract bool Execute(Board board);

        //Method to check if a move is legal
        public virtual bool IsLegal(Board board)
        {
            Player player = board[FromPos].Color;
            Board boardCopy = board.Copy();
            Execute(boardCopy);
            return !boardCopy.IsInCheck(player);
        }
    }
}
