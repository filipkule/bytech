using EcsRx.Collections.Database;
using EcsRx.Collections.Entity;
using EcsRx.Events;
using EcsRx.Executor;
using EcsRx.Infrastructure.Dependencies;
using EcsRx.Systems;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace Bythope.BytechEngine.Core {
    class Bytech : IBytech {

        public IGameScheduler Scheduler { get; }
        public GraphicsDevice GraphicsDevice { get; }
        public GameGraphics Graphics { get; }
        public GameWindow Window { get; }
        public ContentManager ContentManager { get; }
        public IDependencyContainer Container { get; private set; }
        public IEntityDatabase EntityDatabase { get; private set; }
        public IEventSystem EventSystem { get; private set; }
        public ISystemExecutor SystemExecutor { get; private set; }
        public SceneHandler Scenes { get; }


        private GraphicsDeviceManager _graphicsDeviceManager;
        private readonly Game _game;
        private readonly Runtime _runtime;
        private readonly bool _debug = false;

        public Bytech(Runtime runtime) {
            Scheduler = runtime.GameContext;
            _runtime = runtime;
            _game = (Game)runtime.GameContext;
            _graphicsDeviceManager = new GraphicsDeviceManager(_game);
            GraphicsDevice = _graphicsDeviceManager.GraphicsDevice; // TODO: check the differnece for GraphicsDevice
            Graphics = new GameGraphics(_graphicsDeviceManager);
            Window = _game.Window;
            ContentManager = _game.Content;
            Scenes = new SceneHandler(this);

            Window.Title = "Bytech Game";
            Window.AllowUserResizing = false;
            Window.AllowAltF4 = false;
            Window.IsBorderless = true;

            // TODO add access to this game parameters
            // _game.IsFixedTimeStep;
            // _game.IsMouseVisible;
            // _game.LaunchParameters;
            // _game.MaxElapsedTime;
            // _game.ResetElapsedTime();
#if (DEBUG)
            _debug = true;
#endif
        }

        public void Setup() {
            Container = _runtime.Container;
            EntityDatabase = _runtime.EntityDatabase;
            EventSystem = _runtime.EventSystem;
            SystemExecutor = _runtime.SystemExecutor;

            Clean();
            Graphics.Apply();
        }

        public void Clean() {
            // clean entity collections and create default one
            List<int> idList = new List<int>();
            foreach (IEntityCollection collection in EntityDatabase.Collections) {
                idList.Add(collection.Id);
            }
            foreach (var id in idList) {
                EntityDatabase.RemoveCollection(id, true);
            }
            EntityDatabase.CreateCollection(0);

            // clean all systems
            foreach(ISystem system in SystemExecutor.Systems) {
                SystemExecutor.RemoveSystem(system);
            }
        }

        public bool IsInDebug() => _debug;
        public void Terminate() => _game.Exit();
        public bool IsActive() => _game.IsActive;

    }
}
