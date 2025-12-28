using System.Diagnostics;

namespace ChromaEase
{
    internal static class TweenRunner
    {
        private static readonly List<ITween> tweens = new();
        private static readonly Stopwatch stopwatch = Stopwatch.StartNew();
        private static long lastTime;
        private static readonly Timer timer;

        static TweenRunner()
        {
            lastTime = stopwatch.ElapsedMilliseconds;
            timer = new Timer(Update, null!, 0, 16); // ~60 FPS
        }

        internal static void Add(ITween tween)
        {
            lock (tweens)
                tweens.Add(tween);
        }

        private static void Update(object? _)
        {
            long now = stopwatch.ElapsedMilliseconds;
            float deltaTime = (now - lastTime) / 1000f;
            lastTime = now;

            lock (tweens)
            {
                for (int i = tweens.Count - 1; i >= 0; i--)
                {
                    if (!tweens[i].Update(deltaTime))
                        tweens.RemoveAt(i);
                }
            }
        }
    }
}
