using UnityEngine;

public class ClearAndMoveText02 : MonoBehaviour
{
    public ButtonContainer02 btnConScript;
    public ButtonChoices02 btnChoiScript;
    private bool[] textCleared;

    private void Start()
    {
        // Initialize the array with false values for each text element
        textCleared = new bool[btnConScript.btnConText.Length];
    }

    public void ClearAndMoveTextToChoices()
    {
        // Check if the text in ButtonContainer01 is not empty
        for (int i = 0; i < btnConScript.btnConText.Length; i++)
        {
            if (i < btnChoiScript.btnChoices.Length)
            {
                // Check if the text has not been cleared already
                if ((btnConScript.btnConText[i].text == "SAN JOSE" || btnConScript.btnConText[i].text == "GERONA" ) && !textCleared[i])
                {
                    btnConScript.btnConText[i].text = "";  // Clear the text
                    btnChoiScript.btnChoices[i].SetActive(true);  // Re-enable the corresponding button choice
                    textCleared[i] = true;  // Mark the text as cleared
                }
            }
        }
    }
}