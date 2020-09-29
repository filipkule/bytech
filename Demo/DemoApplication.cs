

using Bythope.BytechEngine.Core;
using Bythope.BytechEngine.Demo.Scenes;

namespace Bythope.BytechEngine.Demo {
    public class DemoApplication : BytechApplication {

        protected override void OnRun(IBytech bytech) {
            bytech.Scenes.AddScene<MainScene>("main");
            bytech.Scenes.Start("main");
        }

        protected override void OnExit() {
            
        }

    }
}
