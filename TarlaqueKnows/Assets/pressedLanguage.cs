using UnityEngine;
using UnityEngine.UI;

public class pressedLanguage : MonoBehaviour
{
    [SerializeField] Button englishButton;
    [SerializeField] Button filipinoButton;
    [SerializeField] Sprite selectedImage;  // The image for the selected state
    [SerializeField] Sprite defaultImage;   // The default image for not selected state

    private void Awake()
    {
        // Check and apply language selection
        string selectedLanguage = PlayerPrefs.GetString("SelectedLanguage", "English");
        SetSelectedLanguage(selectedLanguage);
    }

    public void OnEnglishButtonClick()
    {
        // Your existing language selection logic for English

        // Store the selected language
        PlayerPrefs.SetString("SelectedLanguage", "English");
        PlayerPrefs.Save();

        // Apply the selected state to the buttons
        SetSelectedLanguage("English");
    }

    public void OnFilipinoButtonClick()
    {
        // Your existing language selection logic for Filipino

        // Store the selected language
        PlayerPrefs.SetString("SelectedLanguage", "Filipino");
        PlayerPrefs.Save();

        // Apply the selected state to the buttons
        SetSelectedLanguage("Filipino");
    }

    private void SetSelectedLanguage(string selectedLanguage)
    {
        Debug.Log("Setting language: " + selectedLanguage);

        // Reset the sprites for both buttons
        englishButton.GetComponent<Image>().sprite = defaultImage;
        filipinoButton.GetComponent<Image>().sprite = defaultImage;

        // Set the selected sprite based on the selected language
        if (selectedLanguage == "English")
        {
            englishButton.GetComponent<Image>().sprite = selectedImage;
            filipinoButton.Select();
        }
        else if (selectedLanguage == "Filipino")
        {
            filipinoButton.GetComponent<Image>().sprite = selectedImage;
            englishButton.Select();
        }
    }

    private void OnEnable()
    {
        Debug.Log("Button enabled: " + gameObject.name);
    }

    private void OnDisable()
    {
        Debug.Log("Button disabled: " + gameObject.name);
    }

    public void ClearLanguageSelection()
    {
        PlayerPrefs.DeleteKey("SelectedLanguage");
        PlayerPrefs.Save();
    }
}
