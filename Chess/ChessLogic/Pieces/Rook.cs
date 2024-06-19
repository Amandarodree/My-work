//AMANDA NZEKWESI, 2024, Mobile-prog1442

namespace ChessLogic
{
    public class Rook : Piece
    {
        //Properties
        public override PieceType Type => PieceType.Rook;
        public override Player Color { get; }

        private static readonly Direction[] dirs = new Direction[]
        {
            Direction.North,
            Direction.East,
            Direction.South,
            Direction.West
        };

        //Constructor
        public Rook(Player color)
        {
            Color = color;
        }

        //Copy method
        public override Piece Copy()
        {
            Rook copy = new Rook(Color);
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
