using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonContainer73 : MonoBehaviour
{
    public GameObject[] btnContainer;
    public Text[] btnConText;
    public GameObject AllParent;
    SceneChangeEL73 GameObjectScript;

    void Start()
    {
        GameObjectScript = AllParent.GetComponent<SceneChangeEL73>();
    }
    public void IsCorrect()
    {
        for(int ctr=0; ctr<btnContainer.Length;)
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
                btnConText[9].color = Color.white;
                btnConText[10].color = Color.white;
                btnConText[11].color = Color.white;
                btnConText[12].color = Color.white;
                btnConText[13].color = Color.white;


                break;
                }
                else if(btnConText[0].text=="M" && btnConText[1].text=="O" && btnConText[2].text=="R" && btnConText[3].text=="A" && btnConText[4].text== "L"  && btnConText[5].text == "E" && btnConText[6].text == "S" 
                && btnConText[7].text == "H" && btnConText[8].text == "O" && btnConText[9].text == "U" && btnConText[10].text == "S" && btnConText[11].text == "E" )
                {
                    GameObjectScript.Animation.Play("Show_Info");
                    FinishedLevel.isLevelFinished[72]=true;
                FinishedLevel.nextRoomIndex = FinishedLevel.currentRoom + 1;
                HintPoints.trials=0;
                    break;
                }
                else if(btnConText[0].text == "" || btnConText[1].text == "" || btnConText[2].text == "" ||
                    btnConText[3].text == "" || btnConText[4].text == "" || btnConText[5].text == ""
                     || btnConText[6].text == "" || btnConText[7].text == "" || btnConText[8].text == "" ||
                     btnConText[9].text == "" || btnConText[10].text == "" || btnConText[11].text == "" || 
                     btnConText[12].text == "" || btnConText[13].text == "")
            {
                    btnConText[0].color = Color.white;
                    btnConText[1].color = Color.white;
                    btnConText[2].color = Color.white;
                    btnConText[3].color = Color.white;
                    btnConText[4].color = Color.white;
                    btnConText[5].color = Color.white;
                    btnConText[6].color = Color.white;
                    btnConText[7].color = Color.white;
                btnConText[9].color = Color.white;
                btnConText[10].color = Color.white;
                btnConText[11].color = Color.white;
                btnConText[12].color = Color.white;
                btnConText[13].color = Color.white;



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
                btnConText[9].color = Color.red;
                btnConText[10].color = Color.red;
                btnConText[11].color = Color.red;
                btnConText[12].color = Color.red;
                btnConText[13].color = Color.red;
                break;
                }                
            }    
    
    }
   
}
