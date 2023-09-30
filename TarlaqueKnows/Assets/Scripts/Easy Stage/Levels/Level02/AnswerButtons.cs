using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class AnswerButtons : MonoBehaviour
{
    public Text answerText;
    public Image correctImage; // Reference to the correct image you want to display.
    public float displayTime = 2.0f; // Time in seconds to display the correct image.
    public GameObject levelInfoPanel; // Reference to the Level Info Panel GameObject.
    public Button nextSceneButton; // Reference to the button for moving to the next scene.

    public void CheckAnswer()
    {
        if (answerText.text == "TARLAC CITY")
        {
            Debug.Log("Correct!");

            // Display the correct image.
            if (correctImage != null)
            {
                correctImage.gameObject.SetActive(true);
                StartCoroutine(HideCorrectImage());
            }
        }
        else
        {
            Debug.Log("Wrong!");
        }
    }

    IEnumerator HideCorrectImage()
    {
        yield return new WaitForSeconds(displayTime);

        // Hide the correct image after the specified time.
        if (correctImage != null)
        {
            correctImage.gameObject.SetActive(false);
        }

        // Show the Level Info Panel and the next scene button.
        if (levelInfoPanel != null)
        {
            levelInfoPanel.SetActive(true);
        }
    }

    public void LoadNextScene()
    {
        // Add logic here to load the next scene.
        SceneManager.LoadScene("NextSceneName"); // Replace "NextSceneName" with the actual name of your next scene.
    }
}