# WorldCup

⚽ **WorldCup** is a C# college project designed to display statistics from the 2018 Men's World Cup and the 2019 Women's World Cup. It comprises three components:

- **WorldCupLibrary**: A .NET Framework Class Library responsible for data manipulation.
- **WorldCupWF**: A Windows Forms application.
- **WorldCupWPF**: A Windows Presentation Foundation application.

## 📊 Data Sources

The applications fetch data from the following APIs:

- **2018 Men's World Cup**: [https://world-cup-json-2018.herokuapp.com](https://world-cup-json-2018.herokuapp.com)
- **2019 Women's World Cup**: [https://worldcup.sfg.io](https://worldcup.sfg.io)

## 🛠️ Technologies Used

- **C#**: Core programming language for the applications.
- **.NET Framework**: Provides the necessary runtime and libraries.
- **WinForms**: For the traditional Windows desktop application interface.
- **WPF**: For a modern, rich user interface experience.
- **RESTful APIs**: For fetching World Cup data.

## 📂 Project Structure

- `WorldCupLibrary/`: Contains the data manipulation logic shared between applications.
- `WorldCupWF/`: The Windows Forms application.
- `WorldCupWPF/`: The Windows Presentation Foundation application.
- `WorldCup.sln`: The Visual Studio solution file.
- `.gitignore`: Specifies files to ignore in version control.
- `README.md`: This documentation file.
