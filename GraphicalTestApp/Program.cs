using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Program
    {
        public static Tank tank;
        public static Tank tank2;
        static void Main(string[] args)
        {
            Game game = new Game(1280, 760, "Tank game");

            Actor root = new Actor();
            game.Root = root;

            //## Set up game here ##//
            tank = new Tank(300, 300);
            tank2 = new Tank(600, 600);
            Tankturrent turrent = new Tankturrent(0,0);
            Tankturrent turrent2 = new Tankturrent(0, 0);
            root.AddChild(tank2);
            root.AddChild(tank);
            tank.AddChild(turrent);
            tank2.AddChild(turrent2);
            game.Run();
        }

        
    }
}
