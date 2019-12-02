using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(1280, 760, "Graphical Test Application");

            Actor root = new Actor();
            game.Root = root;

            //## Set up game here ##//
            Tank tank = new Tank(300, 300);
            Tankturrent turrent = new Tankturrent(0,0);
            root.AddChild(tank);
            tank.AddChild(turrent);
            game.Run();
        }

        
    }
}
