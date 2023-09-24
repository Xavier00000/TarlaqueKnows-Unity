using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonContainer01 : MonoBehaviour
{
    public GameObject[] btnContainer;
    public Text[] btnConText;
    public GameObject AllParent;
    SceneChangeEL01 GameObjectScript;

    void Start()
    {
        GameObjectScript = AllParent.GetComponent<SceneChangeEL01>();
    }
    public void IsCorrect()
    {
        for (int ctr = 0; ctr < btnContainer.Length; ctr++)
        {
            if (btnConText[ctr].text != null && btnConText[ctr].text == "")
            {
                btnConText[0].color = Color.white;
                btnConText[1].color = Color.white;
                btnConText[2].color = Color.white;
                btnConText[3].color = Color.white;
                btnConText[4].color = Color.white;
                btnConText[5].color = Color.white;
                btnConText[6].color = Color.white;
                btnConText[7].color = Color.white;
                btnConText[8].color = Color.white;
                break;
            }
            else if (btnConText[0].text == "C" && btnConText[1].text == "A" &&
                btnConText[2].text == "P" && btnConText[3].text == "I" &&
                btnConText[4].text == "T" && btnConText[5].text == "O" &&
                btnConText[6].text == "L" && btnConText[7].text == "T" && btnConText[8].text == "A")
            {
                GameObjectScript.Animation.Play("Show_Info");
                FinishedLevel.isLevelFinished[0] = true;
                HintPoints.trials = 0;
                break;
            }
            else if (btnConText[0].text == "" || btnConText[1].text == "" || btnConText[2].text == "" ||
                btnConText[3].text == "" || btnConText[4].text == "" || btnConText[5].text == ""
                 || btnConText[6].text == "" || btnConText[7].text == "" || btnConText[8].text == "")
            {
                btnConText[0].color = Color.white;
                btnConText[1].color = Color.white;
                btnConText[2].color = Color.white;
                btnConText[3].color = Color.white;
                btnConText[4].color = Color.white;
                btnConText[5].color = Color.white;
                btnConText[6].color = Color.white;
                btnConText[7].color = Color.white;
                btnConText[8].color = Color.white;
                break;
            }
            else
            {
                HintPoints.trials++;
                btnConText[0].color = Color.red;
                btnConText[1].color = Color.red;
                btnConText[2].color = Color.red;
                btnConText[3].color = Color.red;
                btnConText[4].color = Color.red;
                btnConText[5].color = Color.red;
                btnConText[6].color = Color.red;
                btnConText[7].color = Color.red;
                btnConText[8].color = Color.red;
                break;
            }
        }
    }
}
