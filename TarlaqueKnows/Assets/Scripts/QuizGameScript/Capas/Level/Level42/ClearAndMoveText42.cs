using UnityEngine;

public class ClearAndMoveText42 : MonoBehaviour
{
    public ButtonContainer42 btnConScript;
    public ButtonChoices42 btnChoiScript;

    public void ClearAndMoveTextToChoices()
    {

        // Check if the text in ButtonContainer29 is not empty
        for (int i = 0; i < btnConScript.btnConText.Length; i++)
        {
           

            if (i < btnChoiScript.btnChoices.Length)
            { btnConScript.btnConText[i].text = "";  // Clear the text
                btnChoiScript.btnChoices[i].SetActive(true);  // Re-enable the corresponding button choice
            }
        }

    }
}
