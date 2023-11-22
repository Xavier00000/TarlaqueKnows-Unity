using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerER13 : MonoBehaviour
{
    public Animator Animation;
    void Start()
    {
        FinishedLevel.currentRoom=SceneManager.GetActiveScene().buildIndex;
        if(FinishedLevel.isLevelFinished[54]==true)
        {
            Animation.Play("Finished_Level");
        }
        else
        {
            Animation.Play("Fade_In");
        }
        
    }
    public void EasyLevel15()
    {
        SceneManager.LoadScene("Start Scene");
    }
    public void NormalRoom16()
    {
        SceneManager.LoadScene("Start Scene");
    }
}
