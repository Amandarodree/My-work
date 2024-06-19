//AMANDA NZEKWESI, 2024, Mobile-prog1442
// Purpose: Contains the Enum for the Player and the Opponent method to return the opposite player.

namespace ChessLogic
{
    //the Enum: For storing which players turn it is, the winning player and also the color of the pieces
    public enum Player
    {
        None,
        White,
        Black
    }

    public static class PlayerExtensions
    {
       public static Player Opponent(this Player player)
       {
            //using a switch statement to return the opposite player

            return player switch
            {
                Player.White => Player.Black,
                Player.Black => Player.White,
                _ => Player.None,
            };

       }
    }
}
