﻿using Bythope.BytechEngine.Core;
using System;
using System.Reactive.Linq;

namespace Bythope.BytechEngine {
    public abstract class BytechApplication : IDisposable {
        
        private Runtime Runtime { get; }

        public BytechApplication() {
            Runtime = new Runtime();
            Runtime.OnRun.FirstAsync().Subscribe(x => OnRun(Runtime.Bytech));
            Runtime.OnExit.FirstAsync().Subscribe(x => OnExit());
            Runtime.Setup();
        }

        protected abstract void OnRun(IBytech bytech);

        protected abstract void OnExit();
        
        public void Dispose() => Runtime.Dispose();
    }
}
