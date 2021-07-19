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
        public AABB Hitbox;
        public Tank(float x, float y) : base(x, y)
        {
            Sprite _texture = new Sprite("tankBlue.png");
            AddChild(_texture);
            Hitbox = new AABB(_texture.Width, _texture.Height);
            AddChild(Hitbox);
            OnUpdate += MoveUp;
            OnUpdate += Moveback;
            OnUpdate += rotateleft;
            OnUpdate += rotateright;
        }
        public void MoveUp(float deltatime)
        {
            if (Input.IsKeyDown(87))
            {
                Hitbox.isPressed = true;
                Vector3 facing = new Vector3(Getm12, Getm11, 0) * -100f; // used to get the direction the tank is facing
                XVelocity = facing.x;
                YVelocity = facing.y; // used to move tank in direction the tank is facing

            }
            else if (Input.IsKeyReleased(87))
            {
                Hitbox.isPressed = false;
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
            if (Input.IsKeyDown(83)) // checks if the s key is down
            {
                Hitbox.isPressed = true;
                Vector3 facing = new Vector3(Getm12, Getm11, 0) * 100f; //used to get the direction the tank is facing

                XAcceleration = facing.x; 
                YAcceleration = facing.y; // used to make tank move in direction the tank is facing
            }
            else if (Input.IsKeyReleased(83)) // runs if s key is realesed
            {
                Hitbox.isPressed = false;
                XAcceleration = 0;
                XVelocity = 0;
                YAcceleration = 0;
                YVelocity = 0;

            }
           
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
        ~Tank()
        {
            if (Parent != null)
            {
                Parent.RemoveChild(this);
            }
            RemoveChild(_texture);
            RemoveChild(Hitbox);
        }
    }
}