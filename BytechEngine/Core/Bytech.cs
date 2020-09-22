using Microsoft.Xna.Framework;

namespace Bythope.BytechEngine.Core {
    class Bytech : IBytech {

        public GraphicsDeviceManager GraphicsDeviceManager { get; }

        public Bytech(IGameContext gameContext) {
            var game = (Game)gameContext;
            GraphicsDeviceManager = new GraphicsDeviceManager(game);
        }
    }
}
