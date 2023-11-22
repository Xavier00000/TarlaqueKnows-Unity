using UnityEngine;

public class ClearAndMoveText05 : MonoBehaviour
{
    public ButtonContainer05 btnConScript;
    public ButtonChoices05 btnChoiScript;
    private bool[] textCleared;

    public void ClearAndMoveTextToChoices()
    {

        // Check if the text in ButtonContainer01 is not empty
        for (int i = 0; i < btnConScript.btnConText.Length; i++)
        {


            if (i < btnChoiScript.btnChoices.Length)
            {
                btnConScript.btnConText[i].text = "";  // Clear the text
                btnChoiScript.btnChoices[i].SetActive(true);
                // Re-enable the corresponding button choice
            }

        }


    }
}
