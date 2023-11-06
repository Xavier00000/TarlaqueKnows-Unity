using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonContainer39 : MonoBehaviour
{
    public GameObject[] btnContainer;
    public Text[] btnConText;
    public GameObject AllParent;
    SceneChangeEL39 GameObjectScript;

    void Start()
    {
        GameObjectScript = AllParent.GetComponent<SceneChangeEL39>();
    }
    public void IsCorrect()
    {
        for(int ctr=0; ctr<btnContainer.Length; )
            {
                if(btnConText[ctr].text!=null && btnConText[ctr].text=="")
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

          



                break;
                }
                else if(btnConText[0].text=="M" && btnConText[1].text=="T" 
                && btnConText[2].text=="T" && btnConText[3].text== "E" && btnConText[4].text == "L" && btnConText[5].text == "A" && btnConText[6].text == "K" && btnConText[7].text == "A" && btnConText[8].text == "W"  && btnConText[9].text == "A" )
            {
                    GameObjectScript.Animation.Play("Show_Info");
                FinishedLevel.isLevelFinished[34] = true;
                FinishedLevel.nextRoomIndex = FinishedLevel.currentRoom + 1;

                HintPoints.trials=0;
                    break;
                }
                else if(btnConText[0].text == "" || btnConText[1].text == "" || btnConText[2].text == "" ||
                    btnConText[3].text == "" || btnConText[4].text == "" || btnConText[5].text == ""
                     || btnConText[6].text == "" && btnConText[7].text == "" || btnConText[8].text == "" || btnConText[9].text == "")
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

                break;
                }                
            }    
    }
}
