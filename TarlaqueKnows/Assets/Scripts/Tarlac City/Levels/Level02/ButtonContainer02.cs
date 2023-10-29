using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class ButtonContainer02 : MonoBehaviour
{
    public GameObject[] btnContainer;
    public Text[] btnConText;
    public GameObject AllParent;
    SceneChangeEL02 GameObjectScript;
    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    void Start()
    {
        GameObjectScript = AllParent.GetComponent<SceneChangeEL02>();
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
                else if(btnConText[0].text=="TARLAC CITY")
                {
                audioManager.PlaySFX(audioManager.levelComplete);
                GameObjectScript.Animation.Play("Show_Info");
                    FinishedLevel.isLevelFinished[1]=true;
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
                audioManager.PlaySFX(audioManager.error);
                HintPoints.trials++;
                    btnConText[0].color = Color.red;
                   
                    break;
                }                
            }    
    }
}
