using EcsRx.Collections.Database;
using EcsRx.Events;
using EcsRx.Executor;
using EcsRx.Infrastructure.Dependencies;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Bythope.BytechEngine.Core {
    public interface IBytech {

        IGameScheduler Scheduler { get; }
        GraphicsDevice GraphicsDevice { get; }
        GameGraphics Graphics { get; }
        GameWindow Window { get; }
        ContentManager ContentManager { get; }
        IDependencyContainer Container { get; }
        IEntityDatabase EntityDatabase { get; }
        IEventSystem EventSystem { get; }
        ISystemExecutor SystemExecutor { get; }
        SceneHandler Scenes { get; }

        bool IsInDebug();
        void Terminate();
        bool IsActive();
        void Clean();

    }
}
