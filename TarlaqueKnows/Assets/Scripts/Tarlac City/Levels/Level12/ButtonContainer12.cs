using UnityEngine;
using UnityEngine.UI;

public class ButtonContainer12 : MonoBehaviour
{
    public GameObject[] btnContainer;
    public Text[] btnConText;
    public GameObject AllParent;
    SceneChangeEL12 GameObjectScript;

    void Start()
    {
        GameObjectScript = AllParent.GetComponent<SceneChangeEL12>();
    }
    public void IsCorrect()
    {
        for(int ctr=0; ctr<btnContainer.Length; ctr++)
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
                }
                else if(btnConText[0].text=="C" && btnConText[1].text=="O"
                    && btnConText[2].text=="N" && btnConText[3].text=="G"
                    && btnConText[4].text=="R"&& btnConText[5].text=="U"
                    && btnConText[6].text=="E" && btnConText[7].text=="N"
                    && btnConText[8].text=="T")
                {                    
                    GameObjectScript.Animation.Play("Show_Info");
                    FinishedLevel.isLevelFinished[11]=true;
                    FinishedLevel.nextRoomIndex=FinishedLevel.currentRoom+1;
                    HintPoints.trials=0;
                    
                }
                else if(btnConText[0].text == "" || btnConText[1].text == ""
                    || btnConText[2].text == "" || btnConText[3].text == ""
                    || btnConText[4].text == ""|| btnConText[5].text == ""
                    || btnConText[6].text == "" || btnConText[7].text == ""
                    || btnConText[8].text == "")
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
                }
                else
                {
                    btnConText[0].color = Color.red;
                    btnConText[1].color = Color.red;
                    btnConText[2].color = Color.red;
                    btnConText[3].color = Color.red;
                    btnConText[4].color = Color.red;
                    btnConText[5].color = Color.red;
                    btnConText[6].color = Color.red;
                    btnConText[7].color = Color.red;
                    btnConText[8].color = Color.red;
                    HintPoints.trials++;
                    break;                    
                }                
            }    
    }
}
