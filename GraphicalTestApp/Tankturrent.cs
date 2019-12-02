using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Tankturrent : Entity
    {
        Sprite _texture;
        public Tankturrent(float x, float y) : base(x, y)
        {
            X = x;
            Y = y;
            _texture = new Sprite("barrelBlue.png");
            _texture.X = -5;
            _texture.Y = 2;
            AddChild(_texture);
            OnUpdate += Rotateleft;
            OnUpdate += Rotateright;
        }
        void Rotateleft(float deltatime)
        {
            if (Input.IsKeyDown(81))
            {
                Rotate(-1f * deltatime);
            }
        }
        void Rotateright(float deltatime)
        {
            if (Input.IsKeyDown(69))
            {
                Rotate(1f * deltatime);
            }
        }
    }
}
