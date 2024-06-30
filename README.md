

# SimpleJoystick

SimpleJoystick is a Unity asset that provides an easy-to-use joystick control for your mobile games. It allows you to add smooth and responsive joystick input to your games with minimal setup.

## Features
- **Simple Setup:** Add the joystick prefab to your scene and you're ready to go.
- **Customizable:** Easily adjust the size, position, and appearance of the joystick to fit your game's design.
- **Smooth Input:** Provides smooth and accurate input for character movement and other actions.
- **Mobile-Friendly:** Optimized for mobile devices, ensuring a responsive and lag-free experience.

## Installation
1. **Clone the repository:**
    ```bash
    git clone https://github.com/hyunamy/SimpleJoystick.git
    ```
2. **Open the project in Unity:**
    - Open Unity Hub and click on the "Add" button.
    - Navigate to the folder where you cloned the repository and select it.

3. **Import the SimpleJoystick package:**
    - In the Unity Editor, go to `Assets > Import Package > Custom Package...`
    - Select the SimpleJoystick.unitypackage file from the cloned repository and import all assets.

## Usage
1. **Add the Joystick to your Scene:**
    - Drag the `SimpleJoystick` prefab from the `Prefabs` folder into your scene.

2. **Configure the Joystick:**
    - Adjust the size, position, and other settings in the Inspector to fit your game's UI.

3. **Use the Joystick Input:**
    - Access the joystick input in your scripts to control your game objects.
    ```csharp
    public class PlayerController : MonoBehaviour
    {
        public SimpleJoystick joystick;

        void Update()
        {
            Vector2 direction = joystick.GetInputDirection();
            // Use the direction to move your player or perform other actions
        }
    }
    ```

## Contributing
We welcome contributions to improve SimpleJoystick! If you have any suggestions or find any issues, please open an issue or submit a pull request.

## License
This project is licensed under the MIT License. See the LICENSE file for details.

## Contact
For any questions or support, please open an issue on the [GitHub repository](https://github.com/hyunamy/SimpleJoystick).

---

Thank you for using SimpleJoystick! We hope it makes your game development process easier and more enjoyable.
