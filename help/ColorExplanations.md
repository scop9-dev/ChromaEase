# Color Tweening – ChromaEase

This document explains how color tweening works in ChromaEase and how colors are interpolated over time using the ARGB color model.

## Purpose

Color tweening allows a smooth transition between two colors over a fixed duration.
ChromaEase achieves this by interpolating each color channel independently using a normalized time value.

This process is deterministic, frame-rate independent, and does not depend on any UI framework.

## Core Principle

A color is composed of four channels:

- Alpha
- Red
- Green
- Blue

Each channel is interpolated separately using the same normalized time value.

## Time Handling

At each update step, the elapsed time is accumulated.

```csharp
elapsed += deltaTime;
```

#### The elapsed time is then converted into a normalized value between 0 and 1.

```csharp
t = Clamp(elapsed / duration, 0, 1);
```

This normalized value represents the progression of the tween over its total duration.

## Easing Application

The normalized time value can be transformed using an easing function.

```csharp
t = easing(t);
```

Easing functions control how the transition progresses over time while keeping the total duration unchanged.

Custom easing functions must accept a value between 0 and 1 and return a value within the same range.

## Color Interpolation

Each ARGB channel is interpolated using linear interpolation.

```csharp
interpolated = start + (end - start) * t
```

Applied to color channels:

```csharp
Alpha = Astart + (Aend - Astart) * t
Red = Rstart + (Rend - Rstart) * t
Green = Gstart + (Gend - Gstart) * t
Blue = Bstart + (Bend - Bstart) * t
```

This guarantees smooth transitions and predictable intermediate colors.

## Applying the Result

The interpolated values are combined into a new color and passed to the user-provided callback.

The callback receives the updated color at each update step.

ChromaEase does not depend on any rendering or UI system.
The callback can be used with WinForms, WPF, console applications, or custom engines.

## Completion

The tween continues updating while the elapsed time is less than the total duration.

When the duration is reached, the tween is considered complete and removed from the runner.

Example

```csharp
CreateColorTween(
setter,
Red,
Blue,
2.0,
EaseInOutQuad
);
```

This example transitions a color from red to blue over two seconds using a quadratic ease-in-out curve.

## Summary

_Colors are interpolated per ARGB channel.
Time is normalized between 0 and 1.
Easing functions shape the interpolation curve.
Execution is frame-rate independent.
The system is lightweight and predictable._
