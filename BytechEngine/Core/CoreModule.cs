using Bythope.BytechEngine.Core;
using EcsRx.Infrastructure.Dependencies;
using EcsRx.Infrastructure.Extensions;
using EcsRx.Scheduling;

namespace Bythope.BytechEngine.Core {
    class CoreModule : IDependencyModule {

        private readonly IGameContext _gameContext;
        private readonly IBytech _bytech;

        public CoreModule(IGameContext gameContext, IBytech bytech) {
            _gameContext = gameContext;
            _bytech = bytech;
        }
        public void Setup(IDependencyContainer container) {

            container.Unbind<IUpdateScheduler>();
            container.Bind<IUpdateScheduler>(x => x.ToInstance(_gameContext));
            container.Bind<IGameScheduler>(x => x.ToInstance(_gameContext));
            container.Bind<IBytech>(x => x.ToInstance(_bytech));
            
        }
    }
}
