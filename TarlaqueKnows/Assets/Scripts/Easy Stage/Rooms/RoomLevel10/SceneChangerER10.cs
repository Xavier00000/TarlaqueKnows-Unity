﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerER10 : MonoBehaviour
{
    public Animator Animation;
    void Start()
    {
        FinishedLevel.currentRoom=SceneManager.GetActiveScene().buildIndex;
        if(FinishedLevel.isLevelFinished[9]==true)
        {
            Animation.Play("Finished_Level");
        }
        else
        {
            Animation.Play("Fade_In");
        }
        
    }
    public void EasyLevel10()
    {
        SceneManager.LoadScene("EasyLevel10");
    }
    public void EasyRoom11()
    {
        SceneManager.LoadScene("EasyRoom11");
    }
}
