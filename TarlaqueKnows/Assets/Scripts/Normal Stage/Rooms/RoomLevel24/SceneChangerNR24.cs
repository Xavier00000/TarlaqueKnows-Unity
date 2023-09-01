﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerNR24 : MonoBehaviour
{
    public Animator Animation;
    void Start()
    {
        FinishedLevel.currentRoom=SceneManager.GetActiveScene().buildIndex;
        if(FinishedLevel.isLevelFinished[23]==true)
        {
            Animation.Play("Finished_Level");
        }
        else
        {
            Animation.Play("Fade_In");
        }
        
    }
    public void NormalLevel24()
    {
        SceneManager.LoadScene("NormalLevel24");
    }
    public void NormalRoom25()
    {
        SceneManager.LoadScene("NormalRoom25");
    }
}
