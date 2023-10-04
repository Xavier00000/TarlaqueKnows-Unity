using UnityEngine;
using UnityEngine.UI;

public class ButtonContainer14 : MonoBehaviour
{
    public GameObject[] btnContainer;
    public Text[] btnConText;
    public GameObject AllParent;
    SceneChangeEL14 GameObjectScript;

    void Start()
    {
        GameObjectScript = AllParent.GetComponent<SceneChangeEL14>();
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
                }
                else if(btnConText[0].text=="O" && btnConText[1].text=="H"
                    && btnConText[2].text=="M")
                {                    
                    GameObjectScript.Animation.Play("Show_Info");
                    FinishedLevel.isLevelFinished[13]=true;
                    FinishedLevel.nextRoomIndex=FinishedLevel.currentRoom+1;
                    HintPoints.trials=0;
                    
                }
                else if(btnConText[0].text == "" || btnConText[1].text == ""
                    || btnConText[2].text == "")
                {
                    btnConText[0].color = Color.white;
                    btnConText[1].color = Color.white;
                    btnConText[2].color = Color.white;
                }
                else
                {
                    btnConText[0].color = Color.red;
                    btnConText[1].color = Color.red;
                    btnConText[2].color = Color.red;
                    HintPoints.trials++;
                    break;
                }                
            }    
    }
}
