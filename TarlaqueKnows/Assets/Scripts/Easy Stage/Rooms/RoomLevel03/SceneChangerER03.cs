using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerER03 : MonoBehaviour
{
    public Animator Animation;
    void Start()
    {
        FinishedLevel.currentRoom=SceneManager.GetActiveScene().buildIndex;
        if(FinishedLevel.isLevelFinished[2]==true)
        {
            Animation.Play("Finished_Level");
        }
        else
        {
            Animation.Play("Fade_In");
        }
        
    }
    public void EasyLevel03()
    {
        SceneManager.LoadScene("EasyLevel03");
    }
    public void EasyRoom04()
    {
        SceneManager.LoadScene("EasyRoom04");
    }
}
