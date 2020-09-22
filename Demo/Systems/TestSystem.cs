using Bythope.BytechEngine.Core;
using EcsRx.Groups;
using EcsRx.Groups.Observable;
using EcsRx.Systems;
using System;

namespace Bythope.BytechEngine.Demo.Game.Systems {
    class TestSystem : IManualSystem {
        public IGroup Group => new EmptyGroup();

        public TestSystem(IBytech bytech) {
            
        }

        public void StartSystem(IObservableGroup observableGroup) {
            throw new NotImplementedException();
        }

        public void StopSystem(IObservableGroup observableGroup) {
            throw new NotImplementedException();
        }
    }
}
