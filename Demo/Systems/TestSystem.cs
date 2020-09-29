using Bythope.BytechEngine.Core;
using EcsRx.Groups;
using EcsRx.Groups.Observable;
using EcsRx.Systems;

namespace Bythope.BytechEngine.Demo.Game.Systems {
    class TestSystem : IManualSystem {
        public IGroup Group => new EmptyGroup();

        public TestSystem(IBytech bytech) {
            
        }

        public void StartSystem(IObservableGroup observableGroup) {
            
        }

        public void StopSystem(IObservableGroup observableGroup) {
           
        }
    }
}
