using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartStage : MonoBehaviour
{
    public GameObject Panel,LockedPanel;
    void Awake()
    {   
        DontDestroyOnLoad(this.gameObject);
    }
    void Update()
    {
        if(HintPoints.HintsPoints<0)
        {
            Panel.SetActive(true);
            LockedPanel.SetActive(true);
        }
    }
    public void RestartCurrentStage()
    {
        if(FinishedLevel.isLevelFinished[14]==false)
        {
            SceneManager.LoadScene("EasyRoom01");
            HintPoints.HintsPoints=200;
            for(int ctr=0; ctr<15; ctr++)
            {
                FinishedLevel.isLevelFinished[ctr]=false;
            }
        }
        else if(FinishedLevel.isLevelFinished[29]==false)
        {
            SceneManager.LoadScene("NormalRoom16");
            HintPoints.HintsPoints=200;
            for(int ctr=15; ctr<29; ctr++)
            {
                FinishedLevel.isLevelFinished[ctr]=false;
            }
            for(int ctr=0; ctr<FinishedLevel.isFinishedAnimation.Length; ctr++)
            {
                FinishedLevel.isFinishedAnimation[ctr]=false;
            }
        }
        else if(FinishedLevel.isLevelFinished[39]==false)
        {
            SceneManager.LoadScene("HardRoom31");
            HintPoints.HintsPoints=200;
            for(int ctr=30; ctr<39; ctr++)
            {
                FinishedLevel.isLevelFinished[ctr]=false;
            }
        }
    }

}
