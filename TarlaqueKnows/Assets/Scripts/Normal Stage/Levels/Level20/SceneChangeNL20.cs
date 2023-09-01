using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeNL20 : MonoBehaviour
{
    public Animator Animation;
    public GameObject BackWarnBox;
    public Hints20 HintScript;
    void Start()
    {
        if(FinishedLevel.isFinishedAnimation[4]==true)
        {
            Animation.Play("Fade_In2");
        }
        else
        {
            Animation.Play("Fade_In");
        }
        FinishedLevel.isFinishedAnimation[4]=true;
    }
    public void FadeOut()
    {
        Animation.Play("Fade_Out");
    }
    public void NormalRoom20()
    {
        SceneManager.LoadScene("NormalRoom20");
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
