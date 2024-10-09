# KeypadPhoneConverter

## Description
The **KeypadPhoneConverter** is a .NET Core Console Application that simulates typing text using a traditional mobile phone keypad. It takes user input as a series of key presses (e.g., pressing '2' once outputs 'A', pressing it twice outputs 'B', etc.). The project is designed with clean, and maintainable architecture.

- **Input example**: "4433555 555666#"
- **Output**: "HELLO"

## Features
- Converts keypress sequences into readable text using an old mobile phone keypad logic.
- Supports multi-tap keypress input with space for pauses and backspace (`*` key).
- Designed with clean, modular architecture using dependency injection and the Single Responsibility Principle.
- Easily extendable.
- Can easily write unit and intergration tests for each service.

## Architecture Overview
This project is designed with the following architecture. 
- **Console Application**: Simple, scalable project type.
- **App**: Handles the overall flow of the app and coordinates dependencies.
- **Service**: Contains the core logic and focuses on maintaining clean and testable logic.
- **Infrastructure**: Provides a bridge between different layers to keep them decoupled.
- **Data(Extendable)**: Can add Data layer if any input,output data is needed to store in database without affecting the existing architecture.

## Getting Started
### Prerequisites
1. **.NET 8.0 SDK**  
  [Download .NET SDK](https://dotnet.microsoft.com/en-us/download)

### Installation
1. **Clone the repository**  
   ```bash
   git clone https://github.com/khinlaynwe-coder/KeypadPhoneConverter.git
2. **Navigate to the project directory**
   ```bash
   cd KeypadPhoneConverter
3. **Build the application**
   ```bash
   dotnet build
3. **Run the application**
   ```bash
   dotnet run
