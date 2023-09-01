using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerER12 : MonoBehaviour
{
    public Animator Animation;
    void Start()
    {
        FinishedLevel.currentRoom=SceneManager.GetActiveScene().buildIndex;
        if(FinishedLevel.isLevelFinished[11]==true)
        {
            Animation.Play("Finished_Level");
        }
        else
        {
            Animation.Play("Fade_In");
        }
        
    }
    public void EasyLevel12()
    {
        SceneManager.LoadScene("EasyLevel12");
    }
    public void EasyRoom13()
    {
        SceneManager.LoadScene("EasyRoom13");
    }
}
