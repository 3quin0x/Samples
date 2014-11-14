﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaveEngine.Framework;
using WaveEngine.Framework.Graphics;

namespace WaveOculusDemoProject.Components
{
    /// <summary>
    /// This behavior sets its entity position to the camera position
    /// </summary>
    public class FollowCameraBehavior : Behavior
    {
        [RequiredComponent]
        private Transform3D transform;

        public FollowCameraBehavior()
        {
            this.UpdateOrder = 1;
        }
        
        protected override void Update(TimeSpan gameTime)
        {
            this.transform.Position = this.RenderManager.ActiveCamera3D.Position;
        }
    }
}
