﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeNL28 : MonoBehaviour
{
    public Animator Animation;
    public GameObject BackWarnBox;
    public Hints28 HintScript;
    void Start()
    {
        if(FinishedLevel.isFinishedAnimation[12]==true)
        {
            Animation.Play("Fade_In2");
        }
        else
        {
            Animation.Play("Fade_In");
        }
        FinishedLevel.isFinishedAnimation[12]=true;
    }
    public void FadeOut()
    {
        Animation.Play("Fade_Out");
    }
    public void NormalRoom28()
    {
        SceneManager.LoadScene("NormalRoom28");
    }
    public void ContinueAnim()
    {
        Animation.Play("Continue");
    }
    public void AddPoints()
    {
        HintPoints.HintsPoints+=50;
    }
    public void ShowBackWarnBox()
    {
        BackWarnBox.SetActive(true);
        HintScript.HintConfirmBox[0].SetActive(false);
        HintScript.HintConfirmBox[1].SetActive(false);
        HintScript.NEHPBox.SetActive(false);
    }
    public void CloseWarnBox()
    {
        HintScript.BackWarningBox.SetActive(false);
    }
    public void GoBack()
    {
        Animation.Play("Fade_Out_Back");
    }
    public void CancelBack()
    {
        BackWarnBox.SetActive(false);
    }
    public void MenuScreen()
    {
        SceneManager.LoadScene("MenuScene");
    }
}