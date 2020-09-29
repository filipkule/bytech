using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bythope.BytechEngine.Core {
    public class GameGraphics {

        private readonly GraphicsDeviceManager _graphicsDeviceManager;

        public int Width = 1280;
        public int Height = 720;
        public bool Fullscreen = false;
        public bool VSync = true;
        public bool PreferMultiSampling = false;

        public GameGraphics(GraphicsDeviceManager graphicsDeviceManager) {
            _graphicsDeviceManager = graphicsDeviceManager;
        }

        public void Apply() {
            _graphicsDeviceManager.PreferredBackBufferWidth = Width;
            _graphicsDeviceManager.PreferredBackBufferHeight = Height;
            _graphicsDeviceManager.IsFullScreen = Fullscreen;
            _graphicsDeviceManager.SynchronizeWithVerticalRetrace = VSync;
            _graphicsDeviceManager.HardwareModeSwitch = true;
            _graphicsDeviceManager.PreferMultiSampling = PreferMultiSampling;
            _graphicsDeviceManager.ApplyChanges();
        }
    }
}
