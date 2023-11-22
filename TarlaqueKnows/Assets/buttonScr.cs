using UnityEngine;
using UnityEngine.UI;

public class buttonScr : MonoBehaviour
{
    AudioManager audioManager;
    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    // You can add variables and methods here

    // This method can be linked to the button's click event in the Unity Editor
    public void OnButtonClick()
    {
        audioManager.PlaySFX(audioManager.drag);
        Debug.Log("Button Clicked!");

        // Add your custom logic here
    }

    public void menuClick()
    {
        audioManager.PlaySFX(audioManager.drop);
        Debug.Log("Button Clicked!");

        // Add your custom logic here
    }
    public void Drop()
    {
        audioManager.PlaySFX(audioManager.drag);
        Debug.Log("Button Clicked!");

        // Add your custom logic here
    }
    public void HINT()
    {
        audioManager.PlaySFX(audioManager.hint);
    }

    public void pop()
    {
        audioManager.PlaySFX(audioManager.pop);
    }

}
