using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerER15 : MonoBehaviour
{
    public Animator Animation;
    void Start()
    {
        FinishedLevel.currentRoom=SceneManager.GetActiveScene().buildIndex;
        if(FinishedLevel.isLevelFinished[14]==true)
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
        SceneManager.LoadScene("EasyLevel15");
    }
    public void NormalRoom16()
    {
        SceneManager.LoadScene("NormalRoom16");
    }
}
