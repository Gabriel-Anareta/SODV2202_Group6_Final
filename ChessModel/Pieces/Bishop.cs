﻿
namespace ChessModel
{
    /// <summary>
    /// Represents a bishop - implements piece
    /// </summary>
    /// <param name="color"></param>
    public class Bishop : Piece
    {
        private static readonly List<Direction> Directions = new List<Direction>
        {
            Direction.NorthEast,
            Direction.NorthWest,
            Direction.SouthEast,
            Direction.SouthWest
        };

        public Bishop(PlayerColor color)
        {
            Type = PieceType.Bishop;
            Color = color;
            Image = color.GetImage(Type);
        }

        public override Piece Copy()
        {
            Bishop copy = new Bishop(this.Color);
            copy.HasMoved = this.HasMoved;
            return copy;
        }

        public override IEnumerable<Move> GetMoves(Position from, Board board)
            => MovesInDirections(from, board, Directions)
                .Select(to => new NormalMove(from, to));
    }
}
