# ChromaEase

![NuGet](https://img.shields.io/nuget/v/ChromaEase?style=flat-square)
![License](https://img.shields.io/badge/license-Apache2.0-blue?style=flat-square)
![.NET](https://img.shields.io/badge/.NET-8.0+-green?style=flat-square)

ChromaEase is a **lightweight and high-performance tweening library for .NET**, allowing smooth transitions for numeric and color values in your applications. Perfect for animations, UI transitions, or any situation where smooth interpolation is required.

---

## 🌟 Features

- Tween numeric values (`float`, `double`) with ease
- Tween `Color` values with smooth interpolation
- Supports **linear**, **ease-in**, **ease-out**, and **ease-in-out** easing functions
- High-performance runner for consistent updates
- Compatible with **WinForms**, **WPF**, and console applications
- Minimal dependencies, lightweight and efficient
- ChromaEase internally uses a powerful runner to update tweens consistently over time.

---

## 💾 Installation

You can install ChromaEase via NuGet:

```bash
dotnet add package ChromaEase --version 1.0.0
```

Or via the NuGet Package Manager:

```powershell
Install-Package ChromaEase -Version 1.0.0
```

## Usage

```csharp
using ChromaEase;
using System.Drawing;

// Tween a float value
ChromaEase.CreateTween(
    v => Console.WriteLine($"Progress: {v}"), 
    0, 100, 2.0f
);

// Tween a color value
ChromaEase.CreateColorTween(
    c => Console.WriteLine($"Color: {c}"), 
    Color.Red, Color.Blue, 2.0f
);
```

#### Explanation:

- The first parameter is a callback called every frame with the interpolated value.

- The next two parameters are the start and end values.

- The last parameter is the duration in seconds.

### WARNING 
> All ####easing functions receive a normalized value `t` between 0 and 1

---

## 📚 Documentation

For detailed examples, API reference, and advanced usage, visit the [Help Folder](https://github.com/scop9-dev/ChromaEase/help)

---

## Contributing

Contributions are welcome!

#### 1. Fork the repository

#### 2. Create a feature branch (git checkout -b feature/NewFeature)

#### 3. Commit your changes (git commit -m 'Add new feature')

#### 4. Push to the branch (git push origin feature/NewFeature)

#### 5. Open a Pull Request

Please make sure your code follows the C# naming conventions and include tests for new features.

---

## License

ChromaEase is open source under the [Apache 2.0 License](https://github.com/scop9-dev/ChromaEase/blob/main/LICENSE)

---

## Contact

Created and maintained by scop9-dev

GitHub: [scop9-dev](https://github.com/scop9-dev)

NuGet: [ChromaEase](https://www.nuget.org/packages/ChromaEase/1.0.0)
