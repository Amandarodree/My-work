﻿//AMANDA NZEKWESI, 2024, Mobile-prog1442

namespace ChessLogic
{
    public class Position
    {
        //Properties
        public int Row { get; }
        public int Column { get; }

        //Constructor
        public Position(int row, int column) 
        { 
            Row = row; 
            Column = column; 
        }

        public Player SquareColor()
        {
            if ((Row + Column) % 2 == 0)
            {
                return Player.White;
            }

            return Player.Black;
        }

        public override bool Equals(object obj)
        {
            return obj is Position position &&
                   Row == position.Row &&
                   Column == position.Column;
        }

        //Overriding
        public override int GetHashCode()
        {
            return HashCode.Combine(Row, Column);
        }

        public static bool operator ==(Position left, Position right)
        {
            return EqualityComparer<Position>.Default.Equals(left, right);
        }

        public static bool operator !=(Position left, Position right)
        {
            return !(left == right);
        }

        //Overloading the + operator
        public static Position operator +(Position pos, Direction dir)
        {
            return new Position(pos.Row + dir.RowDelta, pos.Column + dir.ColumnDelta);
        }
    }
}
