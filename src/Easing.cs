using System;

namespace ChromaEase
{
    public static class Easing
    {
        public static float Linear(float t) => t;

        public static float EaseInQuad(float t) => t * t;
        public static float EaseOutQuad(float t) => 1 - (1 - t) * (1 - t);
        public static float EaseInOutQuad(float t) =>
            t < 0.5f ? 2f * t * t : 1f - MathF.Pow(-2f * t + 2f, 2f) / 2f;

        public static float EaseInCubic(float t) => t * t * t;
        public static float EaseOutCubic(float t) => 1f - MathF.Pow(1f - t, 3f);
        public static float EaseInOutCubic(float t) =>
            t < 0.5f ? 4f * t * t * t : 1f - MathF.Pow(-2f * t + 2f, 3f) / 2f;

        public static float EaseInQuart(float t) => t * t * t * t;
        public static float EaseOutQuart(float t) => 1f - MathF.Pow(1f - t, 4f);
        public static float EaseInOutQuart(float t) =>
            t < 0.5f ? 8f * t * t * t * t : 1f - MathF.Pow(-2f * t + 2f, 4f) / 2f;

        public static float EaseInQuint(float t) => t * t * t * t * t;
        public static float EaseOutQuint(float t) => 1f - MathF.Pow(1f - t, 5f);
        public static float EaseInOutQuint(float t) =>
            t < 0.5f ? 16f * t * t * t * t * t : 1f - MathF.Pow(-2f * t + 2f, 5f) / 2f;

        public static float EaseInBack(float t)
        {
            const float c1 = 1.70158f;
            const float c3 = c1 + 1f;
            return c3 * t * t * t - c1 * t * t;
        }

        public static float EaseOutBack(float t)
        {
            const float c1 = 1.70158f;
            const float c3 = c1 + 1f;
            return 1f + c3 * MathF.Pow(t - 1f, 3f) + c1 * MathF.Pow(t - 1f, 2f);
        }

        public static float EaseInOutBack(float t)
        {
            const float c1 = 1.70158f;
            const float c2 = c1 * 1.525f;
            return t < 0.5f
                ? (MathF.Pow(2f * t, 2f) * ((c2 + 1f) * 2f * t - c2)) / 2f
                : (MathF.Pow(2f * t - 2f, 2f) * ((c2 + 1f) * (t * 2f - 2f) + c2) + 2f) / 2f;
        }
    }
}
