using UnityEngine;
using UnityEngine.UI;

public class LanguageSelector : MonoBehaviour
{
    [SerializeField] private Button englishButton;
    [SerializeField] private Button filipinoButton;
    [SerializeField] private Sprite selectedImage;  // The image for the selected state
    [SerializeField] private Sprite defaultImage;   // The default image for not selected state

    private const string SelectedLanguageKey = "SelectedLanguage";

    private void Awake()
    {
        // Check and apply language selection
        string selectedLanguage = PlayerPrefs.GetString(SelectedLanguageKey, "English");
        SetSelectedLanguage(selectedLanguage);
    }

    public void OnLanguageButtonClick(string language)
    {
        // Store the selected language
        PlayerPrefs.SetString(SelectedLanguageKey, language);
        PlayerPrefs.Save();

        // Apply the selected state to the buttons
        SetSelectedLanguage(language);
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
            filipinoButton.interactable = true;
            englishButton.interactable = false;
        }
        else if (selectedLanguage == "Filipino")
        {
            filipinoButton.GetComponent<Image>().sprite = selectedImage;
            englishButton.interactable = true;
            filipinoButton.interactable = false;
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
        PlayerPrefs.DeleteKey(SelectedLanguageKey);
        PlayerPrefs.Save();
    }
}
