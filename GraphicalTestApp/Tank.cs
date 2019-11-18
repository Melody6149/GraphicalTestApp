using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Tank : Entity
    {
        Sprite _texture;
        public Tank(float x, float y) : base(x, y)
        {
            X = x;
            Y = y;
            _texture = new Sprite("GraphicalTestApp\topdowntanks\PNG\Tanks\tankBlue.png");
        }
    }
}
