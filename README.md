<div align="center">

# 🏋️ Fitness & Macro Calculator (C# WinForms)

[![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![.NET Framework](https://img.shields.io/badge/.NET_Framework-512BD4?style=for-the-badge&logo=.net&logoColor=white)](https://dotnet.microsoft.com/)
[![Guna UI2](https://img.shields.io/badge/Guna_UI2-007ACC?style=for-the-badge&logo=visualstudio&logoColor=white)](https://gunavisualstudio.com/)

A modern, standalone desktop application built with **C#** and **Guna UI2** for precise daily calorie requirements (BMR & TDEE) and macronutrient breakdown calculations based on fitness goals and lifestyle activity levels.

</div>

---

## 📸 Screenshots Showcase

|⚡ Real-Time Macro Calculation Results |
| :------------------------------------------------------------------------------------------------------------------------------------------: |
| <img src="https://github.com/AbuAlwah/FitnessMacroCalculator/blob/main/Main-Interface-Overview-Runing.png?raw=true"/> |

---

## ✨ Features

- **Accurate BMR Formula:** Implements the gold-standard **Mifflin-St Jeor** equation customized for age, weight, height, and gender.
- **TDEE & Goal Adjustment:** Calculates Total Daily Energy Expenditure (TDEE) according to 5 activity levels and dynamically adjusts calories for Cutting, Maintenance, or Bulking.
- **Precision Macro Breakdown:** Automatically distributes daily macronutrients (Protein: 2g/kg, Fats: 1g/kg, Carbs: remaining caloric intake).
- **Robust Input Validation:** Uses `double.TryParse` logic to prevent runtime application crashes from blank or invalid text inputs.
- **Modern Dark UI/UX:** Built with Guna UI2 components featuring smooth rounded panels, custom icons, responsive layouts, and modern dark-mode aesthetics.

---

## 🛠️ Tech Stack & Libraries

- **Language:** [C# (.NET Framework)](https://docs.microsoft.com/en-us/dotnet/csharp/)
- **UI Framework:** Windows Forms (WinForms)
- **UI Component Library:** [Guna.UI2.WinForms](https://gunavisualstudio.com/)

---

## ⚙️ Installation & Getting Started

### Option 1: Quick Run (Direct Download)
1. Go to the **[Releases](https://github.com/AbuAlwah/FitnessMacroCalculator/releases)** section on GitHub.
2. Download the latest `FitnessCalculator.zip` file.
3. Extract the ZIP archive and run `FitnessCalculator.exe` directly.

---

### Option 2: Build from Source

1. **Clone the Repository:**
   ```bash
   git clone https://github.com/AbuAlwah/FitnessMacroCalculator.git
