using EcsRx.Collections.Entity;

namespace Bythope.BytechEngine.Core {
    public abstract class Scene {
    
        protected IBytech Bytech { get; }
        protected IEntityCollection EntityCollection => Bytech.EntityDatabase.GetCollection();
        public Scene(IBytech bytech) {
            Bytech = bytech;
        }
        public abstract void Create(object data);
        public abstract void Destroy();
    }
}