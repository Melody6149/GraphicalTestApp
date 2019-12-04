using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Bullet : Entity
    {
        Sprite _texture;
        AABB _hitbox;
        public Bullet(float x , float y) :base(x ,y)
        {
            x = X;
            y = Y;
            _texture = new Sprite("bulletBlue.png");
            _hitbox = new AABB(_texture.Width, _texture.Height);
            AddChild(_texture);
            AddChild(_hitbox);
        }

        ~Bullet()
            {

        }
    }
}
