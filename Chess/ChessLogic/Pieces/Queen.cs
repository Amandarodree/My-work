//AMANDA NZEKWESI, 2024, Mobile-prog1442

namespace ChessLogic
{
    public class Queen : Piece
    {
        //Properties
        public override PieceType Type => PieceType.Queen;
        public override Player Color { get; }

        private static readonly Direction[] dirs = new Direction[]
        {
            Direction.North,
            Direction.NorthEast,
            Direction.East,
            Direction.SouthEast,
            Direction.South,
            Direction.SouthWest,
            Direction.West,
            Direction.NorthWest
        };

        //Constructor
        public Queen(Player color)
        {
            Color = color;
        }

        //Copy method
        public override Piece Copy()
        {
            Queen copy = new Queen(Color);
            copy.HasMoved = HasMoved;
            return copy;
        }

        //GetMoves method
        public override IEnumerable<Move> GetMoves(Position from, Board board)
        {
            return MovePositionsInDirs(from, board, dirs)
                .Select(to => new NormalMove(from, to));
        }
    }
}
