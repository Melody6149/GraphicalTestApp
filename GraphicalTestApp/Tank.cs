using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Tank : Entity
    {
        
        public Tank(float x, float y) : base(x, y)
        {
            Sprite _texture = new Sprite("tankBlue.png");
           AddChild(_texture);
            AABB hitbox = new AABB(_texture.Width, _texture.Height);
            AddChild(hitbox);
            OnUpdate += MoveUp;
            OnUpdate += Moveback;
        }
        public void MoveUp(float deltatime)
        {
           
            
            if (Input.IsKeyPressed(87))
            {
             
                YAcceleration--;
            }
            else if (Input.IsKeyReleased(87))
            {
                YAcceleration = 0;
                YVelocity = 0;
            }
            if (YVelocity < -.01f)
            {
                YVelocity = -.01f;
            }
        }
        public void Moveback(float deltattime)
        {
            if (Input.IsKeyPressed(83))
            {
                YAcceleration++;
            }
            else if (Input.IsKeyReleased(83))
            {
                YAcceleration = 0;
                YVelocity = 0;

            }
            if (YVelocity > .01f)
            {
                YVelocity = .01f;
            }
        }
    }
}
