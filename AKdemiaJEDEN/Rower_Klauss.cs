using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKdemiaJEDEN
{
    class Rower_Klauss
    {
        public int wheel_count;
        private Color color;
        public float dist;

        public Rower_Klauss(float dist) //musi być public/private przed każdą funkcją
        {
            this.dist = dist;
            wheel_count = 2;
        }

        public void Move(float delta)
        {
            dist += delta;
        }
        public override string ToString() //override nadpisuje domyslne metody
        {
            return $"Rower dist: {this.dist}";
        }
    }
}
