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
        int _bullets = 3;
        public Tankturrent(float x, float y) : base(x, y)
        {
            X = x;
            Y = y;
            _texture = new Sprite("barrelBlue.png");
            _texture.X = -9;
            _texture.Y = -45;
            AddChild(_texture);
            OnUpdate += Rotateleft;
            OnUpdate += Rotateright;
            OnUpdate += shoot;
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

        public void shoot(float deltatime)
        {
            if (_bullets > 0)
            {
                if (Input.IsKeyPressed(32))
                {
                    Bullet bullet = new Bullet(XAbsolute, YAbsolute);
                    Parent.Parent.AddChild(bullet);
                    Vector3 facing = new Vector3(Getm12, Getm11, 0);
                    bullet.XVelocity = facing.x * -100;
                    bullet.YVelocity = facing.y * -100;
                    bullet.Rotate(GetRotation());
                    //_bullets--;
                }
            }
        }
    }
}
