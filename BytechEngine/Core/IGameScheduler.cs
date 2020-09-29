using EcsRx.Scheduling;
using System;
using System.Reactive;

namespace Bythope.BytechEngine.Core {
    public interface IGameScheduler : IUpdateScheduler {
        IObservable<ElapsedTime> OnPreRender { get; }
        IObservable<ElapsedTime> OnRender { get; }
        IObservable<ElapsedTime> OnPostRender { get; }
        IObservable<Unit> OnResume { get; }
        IObservable<Unit> OnPause { get; }
    }
}
