using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerER04 : MonoBehaviour
{
    public Animator Animation;
    void Start()
    {        
        FinishedLevel.currentRoom=SceneManager.GetActiveScene().buildIndex;
        if(FinishedLevel.isLevelFinished[3]==true)
        {
            Animation.Play("Finished_Level");
        }
        else
        {
            Animation.Play("Fade_In");
        }
        
    }
    public void EasyLevel04()
    {
        SceneManager.LoadScene("EasyLevel04");
    }
    public void EasyRoom05()
    {
        SceneManager.LoadScene("EasyRoom05");
    }
}
