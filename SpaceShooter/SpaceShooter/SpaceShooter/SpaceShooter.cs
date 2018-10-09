using Probe31Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShooter.SpaceShooter
{
    public class SpaceShooter : Engine
    {
        public SpaceShooter() 
            : base(Constants.widthBase, Constants.heightBase, Settings.Instance.Scale, "Space Shooter", Settings.Instance.Fullscreen)
        {
        }
    }
}
