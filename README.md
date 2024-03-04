# Multiplication Application

## Overview
This C# application demonstrates the use of abstract classes through various multiplication strategies. It showcases how to implement abstract methods in derived classes and utilize polymorphism in a simple, extendable design.

## Structure
The project is organized into the following folders:

- `AbstractClasses`: Contains abstract base classes defining templates for multiplication operations.
- `Implementations`: Houses concrete classes that implement specific multiplication strategies.
- `Program.cs`: The entry point of the application, demonstrating the use of each multiplication strategy's result.

## Implementations
The application includes the following multiplication strategies:
- `SimpleMultiplier`: Performs straightforward multiplication.
- `DoubleMultiplier`: Doubles the result of the multiplication.
- `TripleMultiplier`: Triples the result of the multiplication.
- `NegativeMultiplier`: Negates the result of the multiplication.
- `ZeroMultiplier`: Returns zero regardless of the input.
- `IncrementMultiplier`: Increments the result of the multiplication by one.

## How to Run
Ensure you have .NET installed on your system. Navigate to the project's root directory in your terminal and run the following command:

dotnet run

This will compile and execute the `Program.cs` file, demonstrating each multiplication strategy's result.

## Extending the Application
To add a new multiplication strategy:
1. Create a new class in the `Implementations` folder inheriting from `Multiplier`.
2. Override the `Multiply` method with your new strategy.
3. Instantiate and demonstrate your new class in `Program.cs`.

## Author
This application was developed by Oleg Vinokurov.

## License
This project is open for free use.

