﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetChariot1
{
    public class Position
    {
        public int x { get; set; }
        public int y { get; set; }
        public Position(int X, int Y)
        {
            x = X;
            y = Y;
        }
        public bool Equals(Position p) { return (this.x == p.x && this.y == p.y);
        }

    }
}
