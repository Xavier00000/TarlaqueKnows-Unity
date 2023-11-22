using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeEL23 : MonoBehaviour
{
    public Animator Animation;
    public GameObject BackWarnBox;
   
    public void FadeOut()
    {
        Animation.Play("Fade_Out");
    }
    public void EasyRoom01()
    {
        SceneManager.LoadScene("EasyLevel24");
    }
    public void ContinueAnim()
    {
        Animation.Play("Continue");
    }
    public void ContinueHints()
    {
        Animation.Play("Hints");
    }
    public void AddPoints()
    {
        HintPoints.HintsPoints+=50;
    }
    public void ShowBackWarnBox()
    {
        BackWarnBox.SetActive(true);
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
        SceneManager.LoadScene("Start Scene");
    }
}
