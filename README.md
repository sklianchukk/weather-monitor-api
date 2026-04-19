# WeatherMonitor - MVP Project

A Windows Forms desktop application for monitoring current weather conditions, developed as part of a laboratory assignment. The project follows the **Model-View-Presenter (MVP)** architectural pattern to ensure a clean separation of concerns between business logic and the user interface.

## 📋 Project Requirements
As specified in the assignment, the application provides the following features:
- **Manual City Entry:** A text field to input any city name for weather retrieval.
- **Capital Cities Selection:** A dropdown menu (ComboBox) featuring at least 20 popular European capitals.
- **Weather Data:** Displays temperature (°C), atmospheric pressure (hPa), and humidity (%).
- **Weather Icons:** Dynamic icon updates (e.g., sun, clouds, rain) based on the current weather description.
- **External API Integration:** Real-time data fetching via the OpenWeatherMap API.

## 🛠️ Technologies
- **Language:** C#
- **Framework:** .NET (Windows Forms)
- **NuGet Packages:**
  - `Newtonsoft.Json`: Used for parsing JSON responses from the API.
  - `System.Net.Http`: Used for handling asynchronous network requests.

## 🏗️ MVP Architecture
The project is structured into three main layers:
1. **Model:** Handles data logic and communication with the OpenWeatherMap API.
2. **View:** Manages UI elements and forwards user events (e.g., search button click, list selection) to the Presenter.
3. **Presenter:** Acts as a mediator that retrieves data from the Model and updates the View accordingly.

## 🚀 Getting Started
1. Clone the repository:
   ```bash
   git clone https://github.com/BohdanSklianchuk/WeatherMonitor.git
