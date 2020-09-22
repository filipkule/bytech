using System;

namespace Bythope.BytechEngine.Demo {
    public static class Program {
        [STAThread]
        static void Main() {
            using (new DemoApplication()) { }
                
        }
    }
}
