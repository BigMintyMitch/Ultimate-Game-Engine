﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UltimateEngine
{
    public class SceneObject
    {
        public Scene Scene { get; protected set; }

        public SceneObject()
        {

        }

        public virtual void SetScene(Scene scene)
        {
            Scene = scene;
        }

        protected void Instantiate(GameObject go, Point position, Transform parent = null)
        {
            Scene.Instantiate(go, position, parent);
        }

        protected void Instantiate(GameObject go, Transform parent = null)
        {
            Scene.Instantiate(go, parent);
        }

        protected void Instantiate(GameObject go, double x, double y)
        {
            Scene.Instantiate(go, x, y);
        }

        protected void Destroy(GameObject go)
        {
            Scene.Destroy(go);
        }
    }
}
