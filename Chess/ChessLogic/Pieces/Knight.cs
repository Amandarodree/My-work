﻿//AMANDA NZEKWESI, 2024, Mobile-prog1442

namespace ChessLogic
{
    public class Knight : Piece
    {
        //Properties
        public override PieceType Type => PieceType.Knight;
        public override Player Color { get; }

        //Constructor
        public Knight(Player color)
        {
            Color = color;
        }

        //Copy method
        public override Piece Copy()
        {
            Knight copy = new Knight(Color);
            copy.HasMoved = HasMoved;
            return copy;
        }

        private static IEnumerable<Position> PotentialToPositions(Position from)
        {
            foreach (Direction vDir in new Direction[] { Direction.North, Direction.South })
            {
                foreach (Direction hDir in new Direction[] { Direction.West, Direction.East })
                {
                    yield return from + 2 * vDir + hDir;
                    yield return from + 2 * hDir + vDir;
                }
            }
        }

        //Move method
        private IEnumerable<Position> MovePositions(Position from, Board board)
        {
           return PotentialToPositions(from).Where(pos => Board.IsInside(pos) 
              && (board.IsEmpty(pos) || board[pos].Color != Color));
        }

        public override IEnumerable<Move> GetMoves(Position from, Board board)
        {
            return MovePositions(from, board).Select(to => new NormalMove(from, to));
        }
    }
}
