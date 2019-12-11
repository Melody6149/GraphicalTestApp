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
        public Bullet(float x, float y) : base(x, y)
        {
            x = X;
            y = Y;
            _texture = new Sprite("bulletBlue.png");
            _hitbox = new AABB(_texture.Width, _texture.Height);
            AddChild(_texture);
            AddChild(_hitbox);
            OnUpdate += Ifbulletsgooffscreen;
            OnUpdate += Collideswithtank;
        }

        ~Bullet()
        {
            if(Parent != null)
            {
                Parent.RemoveChild(this);
            }
            RemoveChild(_hitbox);
            RemoveChild(_texture);
            
        }

        public void Ifbulletsgooffscreen(float deltatime)
        {
            if(X < 0 || X > Game.Width || Y < 0 || Y > Game.Height)
            {
                Parent.RemoveChild(this);
            }
        }
        public void Collideswithtank(float deltatime)
        {
            //_hitbox.DetectCollision(Program.tank.Hitbox);
            if (_hitbox.DetectCollision(Program.tank.Hitbox))
            {
                
            }
        }
    }
}
