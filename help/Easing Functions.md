## Easing Functions

ChromaEase provides a collection of commonly used easing functions via the `Easing` class.

All easing functions take a normalized value `t` between `0` and `1` and return an interpolated value.

### Available easings

- Linear
- EaseInQuad / EaseOutQuad / EaseInOutQuad
- EaseInCubic / EaseOutCubic / EaseInOutCubic
- EaseInQuart / EaseOutQuart / EaseInOutQuart
- EaseInQuint / EaseOutQuint / EaseInOutQuint
- EaseInBack / EaseOutBack / EaseInOutBack

### Example

```csharp
ChromaEase.CreateTween(
    value => Console.WriteLine(value),
    0f,
    1f,
    1.5f,
    Easing.EaseInOutCubic
);
