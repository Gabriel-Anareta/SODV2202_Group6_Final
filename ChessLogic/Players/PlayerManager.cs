﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessModel
{
    public static class PlayerManager
    {
        /// <summary>
        /// Gets the next player in order
        /// </summary>
        /// <param name="color"></param>
        /// <returns>Returns a PlayerColor that is next in the order</returns>
        public static PlayerColor Next(this PlayerColor color)
        {
            return color switch
            {
                PlayerColor.White => PlayerColor.Black,
                PlayerColor.Black => PlayerColor.White,
                PlayerColor.Red => PlayerColor.Green,
                PlayerColor.Green => PlayerColor.Yellow,
                PlayerColor.Yellow => PlayerColor.Blue,
                PlayerColor.Blue => PlayerColor.Red,
                _ => PlayerColor.None
            };
        }
    }
}
