# 🔋 Battery Status WPF Application

A lightweight WPF desktop application that displays real-time **battery charge status** and **charge percentage** in a modern, transparent UI.

<div align="center">
  <img src="BatteryStatusWPF_V/GitHubPreview/BSV_Preview.gif" alt="GIF_Preview" />
</div>

## Features
- **Modern Acrylic UI**: Sleek, transparent window with a borderless design.
- **Real-time Battery Monitoring**: Updates every second.
- **Draggable Window**: Allows smooth dragging of the borderless window.
- **Custom Fonts**: Uses "Roboto Mono Light" for a polished appearance.

## Technologies Used
- **Languages**: C#, XAML
- **Frameworks & Libraries**:  
  - [WPF (Windows Presentation Foundation)](https://learn.microsoft.com/en-us/dotnet/desktop/wpf/)  
  - [FluentWpfChromes](https://github.com/vbobroff-app/FluentWpfChromes)
- **Tools**: Visual Studio, .NET Framework

## How It Works
- Uses `SystemInformation.PowerStatus` to retrieve battery details.
- A `DispatcherTimer` updates the status and percentage every second.
- Enables dragging via the `DragMove` method while maintaining a borderless design.

## Installation & Usage
1. Clone the repository:
   ```bash
   git clone https://github.com/aquastones/BatteryStatusWPF_V.git
   ```
2. Open in Visual Studio 2022
3. Build and run the project
4. An .exe can be found at bin/Release
