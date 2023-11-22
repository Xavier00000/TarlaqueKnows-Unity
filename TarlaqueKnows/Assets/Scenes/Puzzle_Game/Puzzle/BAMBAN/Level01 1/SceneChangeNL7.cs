using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeNL7 : MonoBehaviour
{
    public Animator Animation;
    public GameObject BackWarnBox;
    public HintsPuzzle7 HintScript;
    void Start()
    {
        FinishedLevelP.onLevel01 = true;

        if (FinishedLevelP.isFinishedAnimation[0])
        {
            Animation.CrossFade("Fade_In", 0.3f, -1, 0f);
        }
        else
        {
            Animation.CrossFade("Fade_In", 0.3f, -1, 0f);
        }

        FinishedLevelP.isFinishedAnimation[0] = true;
    }

    public void FadeIn()
    {
        Animation.Play("Fade_In");
    }

    public void FadeOut()
    {
        Animation.Play("Fade_Out");
    }
    public void NormalRoom16()
    {
        SceneManager.LoadScene("NormalLevel6 2");
    }
    public void ContinueAnim()
    {
        Animation.Play("Continue");
    }
    public void AddPoints()
    {
        HintPointsPuzzle.HintsPoints += 50;
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
        SceneManager.LoadScene("PuzzleMunicipality");
    }
}
