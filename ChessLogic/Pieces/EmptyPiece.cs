﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessModel.Pieces
{
    public class EmptyPiece : Piece
    {
        public override PieceType Type => PieceType.None;
        public override PlayerColor Color => PlayerColor.None;
        public override Piece Copy() => new EmptyPiece();
        public override IEnumerable<Move> GetMoves(Position from, Board board) => Enumerable.Empty<Move>();
    }
}