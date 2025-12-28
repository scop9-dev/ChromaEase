using System.Drawing;

namespace ChromaEase
{
    internal class ColorTween : ITween
    {
        private readonly Action<Color> setter;
        private readonly Color start, end;
        private readonly float duration;
        private readonly Func<float, float> easing;
        private float elapsed;

        internal ColorTween(Action<Color> setter, Color start, Color end, float duration, Func<float, float> easing)
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

            setter(Color.FromArgb(
                (int)(start.A + (end.A - start.A) * t),
                (int)(start.R + (end.R - start.R) * t),
                (int)(start.G + (end.G - start.G) * t),
                (int)(start.B + (end.B - start.B) * t)
            ));

            return elapsed < duration;
        }
    }
}
