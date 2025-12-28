namespace ChromaEase
{
    internal class Tween : ITween
    {
        private readonly Action<float> setter;
        private readonly float start;
        private readonly float end;
        private readonly float duration;
        private readonly Func<float, float> easing;

        private float elapsed;

        internal Tween(Action<float> setter, float start, float end, float duration, Func<float, float> easing)
        {
            this.setter = setter;
            this.start = start;
            this.end = end;
            this.duration = duration;
            this.easing = easing;
        }

        public bool Update(float deltaTime)
        {
            elapsed += deltaTime;
            float t = Math.Clamp(elapsed / duration, 0f, 1f);
            t = easing(t);

            setter(start + (end - start) * t);
            return elapsed < duration;
        }
    }
}
