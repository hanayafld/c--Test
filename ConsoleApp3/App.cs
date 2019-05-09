using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class DieEventArgs : EventArgs
    {
        public int hp;
    }


    public class App
    {
        public void Start()
        {
            GameLauncher launcher = new GameLauncher();

            launcher.Init();
            launcher.Run();
        }
    }
}
