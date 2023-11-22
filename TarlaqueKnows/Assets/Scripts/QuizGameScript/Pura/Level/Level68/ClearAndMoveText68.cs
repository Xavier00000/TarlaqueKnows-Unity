using UnityEngine;

public class ClearAndMoveText68 : MonoBehaviour
{
    public ButtonContainer68 btnConScript;
    public ButtonChoices68 btnChoiScript;

    public void ClearAndMoveTextToChoices()
    {

        // Check if the text in ButtonContainer01 is not empty
        for (int i = 0; i < btnConScript.btnConText.Length; i++)
        {
           

            if (i < btnChoiScript.btnChoices.Length)
            { btnConScript.btnConText[i].text = "";  // Clear the text
                btnChoiScript.btnChoices[i].SetActive(true);  // Re-enable the corresponding button choice
            }
        }

    }
}
