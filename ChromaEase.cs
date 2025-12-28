using System.Drawing;

namespace ChromaEase
{
    public static class Tweener
    {
        public static void CreateTween(
            Action<float> setter,
            float start,
            float end,
            float duration,
            Func<float, float>? easing = null)
        {
            easing ??= Easing.Linear;
            TweenRunner.Add(new Tween(setter, start, end, duration, easing));
        }

        public static void CreateColorTween(
            Action<Color> setter,
            Color start,
            Color end,
            float duration,
            Func<float, float>? easing = null)
        {
            easing ??= Easing.Linear;
            TweenRunner.Add(new ColorTween(setter, start, end, duration, easing));
        }
    }
}
