# FlyByTab Unity Script

This Unity script allows a GameObject to fly in the direction of the camera when the `Tab` key is held down. The script also disables the collider of the GameObject to ensure smooth movement. It is designed with Object-Oriented Programming (OOP) principles in mind for better modularity and maintainability.

## Features

- **Fly in the Camera Direction**: The GameObject flies in the direction the camera is facing when the `Tab` key is pressed.
- **Collider Management**: Automatically disables the collider of the GameObject when the scene starts.
- **OOP Design**: The code is structured using OOP principles for better organization and extensibility.

## Code Structure

### 1. `FlyBehavior`
- **Purpose**: Handles the logic for moving the GameObject in the direction of the camera.
- **Methods**: 
  - `Fly(Transform transform, Transform cameraTransform)`: Moves the GameObject based on the camera's forward direction.
- **Attributes**:
  - `float speed`: The speed at which the GameObject flies.

### 2. `DisableCollider`
- **Purpose**: Manages the collider of the GameObject.
- **Methods**:
  - `Disable()`: Disables the collider component attached to the GameObject.
- **Attributes**:
  - `Collider objectCollider`: The collider component to be managed.

### 3. `FlyByTab`
- **Purpose**: The main MonoBehaviour class that integrates flying behavior and collider management.
- **Methods**:
  - `Start()`: Initializes the flying behavior and disables the collider.
  - `Update()`: Checks for input and triggers the flying behavior.
- **Attributes**:
  - `float speed`: The speed of flying, adjustable in the Unity Inspector.

## Getting Started

### Prerequisites

- **Unity**: Make sure you have Unity installed.
- **Basic C# Knowledge**: Familiarity with C# and Unity scripting.

### Installation

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/yourusername/FlyByTab.git
   ```
2. **Add the Script to Your Unity Project**:
   - Copy the `FlyByTab.cs` file to your Unity project's `Assets/Scripts` folder.

### Usage

1. **Attach the Script**:
   - Attach the `FlyByTab` script to the GameObject you want to control.
   - Ensure the GameObject has a Collider component (e.g., BoxCollider, SphereCollider).

2. **Adjust Speed**:
   - You can adjust the flying speed by modifying the `speed` variable in the Unity Inspector.

3. **Run the Scene**:
   - Press the `Tab` key to make the GameObject fly in the direction of the camera.

## Customization

- **Speed Adjustment**: Modify the `speed` variable to change how fast the GameObject flies.
- **Extend Functionality**: The modular structure allows you to easily add more features or extend the existing ones by creating new classes or modifying the `FlyBehavior` or `DisableCollider` classes.
