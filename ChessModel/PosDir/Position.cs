﻿namespace ChessModel
{
    /// <summary>
    /// represents a position given by a file and a rank
    /// </summary>
    public class Position(int file, int rank)
    {
        public int File { get; set; } = file;
        public int Rank { get; set; } = rank;

        public PlayerColor SquareColor()
        {
            if ((File + Rank) % 2 == 0)
                return PlayerColor.White;

            return PlayerColor.Black;
        }

        public override bool Equals(object? obj)
        {
            return obj is Position position &&
                   File == position.File &&
                   Rank == position.Rank;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(File, Rank);
        }

        public static bool operator ==(Position? left, Position? right)
        {
            return EqualityComparer<Position>.Default.Equals(left, right);
        }

        public static bool operator !=(Position? left, Position? right)
        {
            return !(left == right);
        }

        /// <summary>
        /// overloaded + operator on position
        /// </summary>
        /// <param name="pos"></param>
        /// <param name="dir"></param>
        /// <returns>Returns a new position with the added direction value</returns>
        public static Position operator +(Position pos, Direction dir)
        {
            return new Position(pos.File + dir.FileDelta, pos.Rank + dir.RankDelta);
        }

        public static Position ToPosition(string pos)
        {
            char fileArg = pos[0];
            string rankArg = pos.Substring(1);
            int file = (int)Enum.Parse(typeof(FileValue), fileArg.ToString());
            int rank = int.Parse(rankArg);
            return new Position(file, rank);
        }

        public override string ToString()
            => $"{(FileValue)File}{Rank}";
    }
}
