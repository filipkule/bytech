using Bythope.BytechEngine.Core;
using Bythope.BytechEngine.Demo.Game.Systems;

using EcsRx.Infrastructure.Extensions;
using EcsRx.Systems;
using System;

namespace Bythope.BytechEngine.Demo {
    public class DemoApplication : BytechApplication {

        protected override void OnRun(Runtime runtime) {
            runtime.EntityDatabase.GetCollection().CreateEntity();
            var system = runtime.Container.Resolve<TestSystem>();
            runtime.SystemExecutor.AddSystem(system);
            var systems = runtime.SystemExecutor.Systems;
            Console.WriteLine();
        }

        protected override void OnExit() {
            Console.WriteLine("exit");
        }
    }
}
