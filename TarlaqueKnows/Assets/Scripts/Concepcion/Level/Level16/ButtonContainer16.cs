using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonContainer16 : MonoBehaviour
{
    public GameObject[] btnContainer;
    public Text[] btnConText;
    public GameObject AllParent;
    SceneChangeEL16 GameObjectScript;

    void Start()
    {
        GameObjectScript = AllParent.GetComponent<SceneChangeEL16>();
    }
    public void IsCorrect()
    {
        for(int ctr=0; ctr<btnContainer.Length; )
            {
                if(btnConText[ctr].text!=null && btnConText[ctr].text=="")
                {
                    btnConText[0].color = Color.white;
                    
                    break;
                }
                else if(btnConText[0].text== "45")
                {
                    GameObjectScript.Animation.Play("Show_Info");
                    FinishedLevel.isLevelFinished[15]=true;
                    FinishedLevel.nextRoomIndex=FinishedLevel.currentRoom+1;
                    HintPoints.trials=0;
                    break;
                }
                else if(btnConText[0].text == "")
                {
                    btnConText[0].color = Color.white;
                  
                    break;
                }
                else
                {
                    HintPoints.trials++;
                    btnConText[0].color = Color.red;
                   
                    break;
                }                
            }    
    }
}
