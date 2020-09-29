using EcsRx.Collections.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bythope.BytechEngine.Core {
    public class SceneHandler {

        private readonly Dictionary<string, Scene> _scenes = new Dictionary<string, Scene>();
        private Scene _current = null;
        private readonly IBytech _bytech;

        public SceneHandler(IBytech bytech) {
            _bytech = bytech;
        }

        public void AddScene<T>(string name) where T : Scene {
            if (_scenes.ContainsKey(name)) {
                throw new Exception("You can not add scene named " + name + ", scene with that name is already added");
            }
            Scene scene = (Scene)Activator.CreateInstance(typeof(T), new object[] { _bytech });
            _scenes.Add(name, scene);
        }

        public void Start(string name, object data = null) {
            if (!_scenes.ContainsKey(name)) {
                throw new Exception("You can not start scene witn name " + name + ", scene does not exist!");
            }

            _bytech.Clean();
            if (_current != null) {
                _current.Destroy();
            }
            _current = _scenes[name];
            _current.Create(data);
        }

        public string[] GetSceneNames() {
            return _scenes.Keys.ToArray();
        }

    }
}
