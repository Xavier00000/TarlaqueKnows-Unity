using UnityEngine;
using UnityEngine.UI;

public class ButtonPressState : MonoBehaviour
{
    private Button button;
    private bool isPressed;

    private void Start()
    {
        // Find the button by its name "EN_BTN" in the hierarchy
        button = GameObject.Find("EN_BTN").GetComponent<Button>();

        if (button == null)
        {
            Debug.LogError("Button component not found. Make sure the button is named 'EN_BTN' in the UI.");
            return;
        }

        // Load the button state from PlayerPrefs when the game starts
        isPressed = PlayerPrefs.GetInt("ButtonState", 0) == 1;

        // Update the button's appearance based on the loaded state
        UpdateButtonState();

        // Add a click event listener to the button
        button.onClick.AddListener(ToggleButtonState);
    }

    private void ToggleButtonState()
    {
        isPressed = !isPressed;
        UpdateButtonState();

        // Save the button state in PlayerPrefs
        PlayerPrefs.SetInt("ButtonState", isPressed ? 1 : 0);
        PlayerPrefs.Save();
    }

    private void UpdateButtonState()
    {
        // Customize the button's appearance or behavior based on the state.
        if (isPressed)
        {
            button.GetComponentInChildren<Text>().text = "Pressed";
            // Perform actions when the button is pressed.
        }
        else
        {
            button.GetComponentInChildren<Text>().text = "Not Pressed";
            // Perform actions when the button is released.
        }
    }
}
