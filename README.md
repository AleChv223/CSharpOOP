# CSharpOOP

This repository demonstrates the implementation of basic Object-Oriented Programming (OOP) concepts in C#.

## Project Structure

### 1. **EntryPoint**
   - The main entry point of the application is implemented in `EntryPoint.cs`.
   - It creates instances of the `Warrior` class and demonstrates interactions between objects.
   - Key functionalities include:
     - Creating `Warrior` objects with different constructors.
     - Demonstrating property access and validation (e.g., setting age with constraints).
     - Simulating interactions between warriors using the `Greetings` method.
     - Accessing the `Sword` weapon's properties through the `Warrior` class.

### 2. **Characters**
   - Contains the `Warrior` class, implemented in `Characters/Warriors/Warrior.cs`.
   - The `Warrior` class encapsulates the following:
     - Properties like `Height`, `Weight`, `Name`, `Age`, and `SwordWeapon`.
     - Validation logic for the `Age` property to ensure it falls within a valid range (18–45).
     - A `Greetings` method to simulate interactions between warriors.
     - Constructors to initialize warriors with different sets of attributes.

### 3. **Weapons**
   - Contains the `Sword` class, implemented in `Weapons/Sword.cs`.
   - The `Sword` class represents a weapon with a `Damage` property.
   - The default constructor initializes the sword with a base damage of 10.

## Key Features

- **Encapsulation**: Properties in the `Warrior` and `Sword` classes control access to private fields.
- **Constructor Overloading**: The `Warrior` class demonstrates multiple constructors for flexible object initialization.
- **Validation**: The `Age` property in the `Warrior` class includes validation logic to ensure proper values.
- **Object Interaction**: The `Greetings` method in the `Warrior` class demonstrates how objects interact with each other.
