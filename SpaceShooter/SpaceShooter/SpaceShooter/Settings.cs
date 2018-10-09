using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShooter.SpaceShooter
{
    [Serializable]
    public class Settings
    {
        public bool Fullscreen { get; set; }
        public int Scale { get; set; }

        public static Settings Instance;
       

        public Settings()
        {
            Initialize();
            Instance = this;            
        }

        public void Initialize()
        {
            Fullscreen = false;
            Scale = 1;
        }
    }
}
