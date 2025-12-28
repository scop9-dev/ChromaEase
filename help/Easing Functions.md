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
```

#### This tween interpolates a numeric value from 0.0 to 1.0 over 1.5 seconds.

#### The value progression is time-based and frame-rate independent. Internally, elapsed time is normalized to a range between 0 and 1, then transformed using the EaseInOutCubic easing function.

#### The cubic ease-in-out curve produces a smooth acceleration at the beginning, a faster transition in the middle, and a gentle deceleration toward the end, making it ideal for natural-looking animations.

#### At each update step, the interpolated value is passed to the callback function, allowing the tween to drive any numeric property without coupling to a specific UI or rendering system.

#### Once the duration is reached, the tween completes automatically and stops updating.
