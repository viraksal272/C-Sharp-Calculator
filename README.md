# 🧮 Modern Responsive WinForms Calculator

A production-ready, space-optimized **Windows Forms (WinForms)** calculator built using C# and .NET. This application features state management processing, dynamic control event binding, a custom real-time inline math builder, and an interactive theme switcher.

---

## 📸 Preview
<p align="center">
<img width="457" height="467" alt="image" src="https://github.com/user-attachments/assets/350336a8-42aa-4da6-ac04-dee68eae0efd" />
<img width="452" height="467" alt="image" src="https://github.com/user-attachments/assets/d5294a12-d900-449c-9824-639db220e2d9" />

</p>
---

## 🚀 Key Features

* **Inline Expression Building:** Unlike traditional calculators that wipe data on input, this system prints the entire arithmetic chain sequentially (e.g., `25 + 25`) across a single display grid.
* **Smart Operation Chaining:** Intercepts out-of-order sequence actions. Clicking an operator dynamically computes running totals behind the scenes before updating the active layout view state.
* **Advanced Code Reuse (DRY):** Dynamically wires up generic numeric event inputs using implicit object casting (`(Button)sender`), keeping the backing script lightweight.
* **Dynamic Theme Toggle:** Integrates custom algorithmic control loops to sweep across parent containers and transition the entire control layout grid cleanly between Dark and Light color palettes.
* **Smart Backspace Parsing:** Evaluates ending indices dynamically, clearing mathematical operations alongside their structural spacing paddings automatically.

---

## 🛠️ Tech Stack & Architecture

* **Language:** C# 14 / .NET 10
* **Framework:** Windows Forms (WinForms) Native Layout Engine
* **IDE:** Visual Studio 2022

---

## 💻 Getting Started / Installation

Follow these quick steps to pull down this application source configuration and build it on your local environment:

1. **Clone the Repository:**
   ```bash
   git clone https://github.com
   ```
2. Open the solution file (`.sln`) inside **Visual Studio 2022**.
3. Verify that target dependencies load without warnings.
4. Press **`F5`** or click the **Start/Play** arrow at the top tool ribbon layout to compile and execute the desktop binary.
