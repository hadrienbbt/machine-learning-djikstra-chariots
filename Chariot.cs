using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projettaquin
{
    public class Chariot
    {
        public bool orientation { get; protected set; } // 0 = nord ; 1 = sud
        public struct Position
        {
            public int x { get; set; }
            public int y { get; set; }

            public Position(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
        public Position position;

        public static Random rnd = new Random();
        public int hauteur { get; protected set; }
        public Chariot(Entrepot e)
        {
            int posX, posY;

            do
            {
                posX = Chariot.GenererAlea(0, 25);
                posY = Chariot.GenererAlea(0, 25);
                // vérifier que Position(posX,poY) est valide

            } while (e.grille[posX, posY] == 1 || e.grille[posX, posY] == 7);
            orientation = GenererAlea(0, 2) == 0 ? false : true;
            this.position = new Position(posX,posY);
        }

        public static int GenererAlea(int min, int max)
        {
            return rnd.Next(min, max);
        }
    }
}
