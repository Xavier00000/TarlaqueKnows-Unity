﻿using UnityEngine;
using UnityEngine.UI;

public class ButtonContainer08 : MonoBehaviour
{
    public GameObject[] btnContainer;
    public Text[] btnConText;
    public GameObject AllParent;
    SceneChangeEL08 GameObjectScript;

    void Start()
    {
        GameObjectScript = AllParent.GetComponent<SceneChangeEL08>();
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
                }
                else if(btnConText[0].text=="U" && btnConText[1].text=="N"
                    && btnConText[2].text=="I" && btnConText[3].text=="O"
                    && btnConText[4].text=="N")
                {                    
                    GameObjectScript.Animation.Play("Show_Info");
                    FinishedLevel.isLevelFinished[7]=true;
                    FinishedLevel.nextRoomIndex=FinishedLevel.currentRoom+1;
                    HintPoints.trials=0;
                    break;
                    
                    
                }
                else if(btnConText[0].text == "" || btnConText[1].text == ""
                    || btnConText[2].text == "" || btnConText[3].text == ""
                    || btnConText[4].text == "")
                {
                    btnConText[0].color = Color.white;
                    btnConText[1].color = Color.white;
                    btnConText[2].color = Color.white;
                    btnConText[3].color = Color.white;
                    btnConText[4].color = Color.white;
                }
                else
                {
                    btnConText[0].color = Color.red;
                    btnConText[1].color = Color.red;
                    btnConText[2].color = Color.red;
                    btnConText[3].color = Color.red;
                    btnConText[4].color = Color.red;
                    HintPoints.trials++;
                    break;
                }                
            }    
    }
}