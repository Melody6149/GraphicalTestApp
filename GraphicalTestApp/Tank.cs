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
        AABB hitbox;
        public Tank(float x, float y) : base(x, y)
        {
            Sprite _texture = new Sprite("tankBlue.png");
           AddChild(_texture);
            hitbox = new AABB(_texture.Width, _texture.Height);
            AddChild(hitbox);
            OnUpdate += MoveUp;
            OnUpdate += Moveback;
            OnUpdate += rotateleft;
            OnUpdate += rotateright;
        }
        public void MoveUp(float deltatime)
        {
            if (Input.IsKeyDown(87))
            {
                hitbox.isPressed = true;
                Vector3 facing = new Vector3(getm12, getm11, 0) * -100f;

                XAcceleration = facing.x;
                YAcceleration = facing.y;
            }
            else if (Input.IsKeyReleased(87))
            {
                hitbox.isPressed = false;
                XAcceleration = 0;
                XVelocity = 0;
                YAcceleration = 0;
                YVelocity = 0;
            }
            //if (YVelocity < -.01f)
            //{
            //    YVelocity = -.01f;
            //}

        }
        public void Moveback(float deltatime)
        {
            if (Input.IsKeyDown(83))
            {
                hitbox.isPressed = true;
                Vector3 facing = new Vector3(getm12, getm11, 0) * 100f;
                
                XAcceleration = facing.x;
                YAcceleration = facing.y;
            }
            else if (Input.IsKeyReleased(83))
            {
                hitbox.isPressed = false;
                XAcceleration = 0;
                XVelocity = 0;
                YAcceleration = 0;
                YVelocity = 0;

            }
            //if (YVelocity > .01f)
            //{
            //    YVelocity = .01f;
            //}
        }
        public void rotateleft(float deltatime)
        {
            if (Input.IsKeyDown(65))
            {
                Rotate(-1f * deltatime);
            }
        }

        public void rotateright(float deltatime)
        {
            if (Input.IsKeyDown(68))
            {
                Rotate(1f * deltatime);
            }
        }
    }
}