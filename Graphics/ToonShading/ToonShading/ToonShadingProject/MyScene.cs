// Copyright (C) 2014 Weekend Game Studio
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to
// deal in the Software without restriction, including without limitation the
// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
// sell copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
// THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
// IN THE SOFTWARE.

#region Using Statements
using System;
using WaveEngine.Common;
using WaveEngine.Common.Graphics;
using WaveEngine.Common.Math;
using WaveEngine.Components.Cameras;
using WaveEngine.Components.Graphics2D;
using WaveEngine.Components.Graphics3D;
using WaveEngine.Framework;
using WaveEngine.Framework.Graphics;
using WaveEngine.Framework.Resources;
using WaveEngine.Framework.Services;
using WaveEngine.Materials;
#endregion

namespace ToonShadingProject
{
    public class MyScene : Scene
    {
        protected override void CreateScene()
        {            
            FreeCamera camera = new FreeCamera("MainCamera", new Vector3(0, 20, 30), Vector3.Zero);
            camera.BackgroundColor = Color.CornflowerBlue;
            EntityManager.Add(camera.Entity);            

            Entity sphere = new Entity("Sphere")
                .AddComponent(new Transform3D() { Scale = new Vector3(10f) })
                .AddComponent(new Spinner() { AxisTotalIncreases = new Vector3(0, 1, 0) })
                .AddComponent(Model.CreateTeapot())
                .AddComponent(new MaterialsMap(new ToonShadingMaterial(string.Empty, "Content/DiffuseRamp.wpk")))
                .AddComponent(new ModelRenderer());

            EntityManager.Add(sphere);
        }
    }
}
