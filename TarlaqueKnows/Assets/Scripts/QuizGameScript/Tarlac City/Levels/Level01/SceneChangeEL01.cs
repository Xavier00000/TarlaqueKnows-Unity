using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeEL01 : MonoBehaviour
{
    public Animator Animation;
    public GameObject BackWarnBox;
    void Start()
    {
        FinishedLevel.onLevel01=true;        
    }
    public void FadeOut()
    {
        Animation.Play("Fade_Out");
    }
    public void EasyRoom01()
    {
      
        SceneManager.LoadScene("EasyLevel02");
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
